using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using KS.Core.Models;
using KS.Reports.Dto;
using Microsoft.EntityFrameworkCore;

namespace KS.Reports
{
    public class ReportsAppService : KSAppServiceBase, IReportsAppService
    {
        private readonly IRepository<Question> _questionRepository;
        private readonly IRepository<QuestionAnswer> _questionAnsweRepository;
        private readonly IRepository<QuestionAnswerRating> _questionAnswerRatingRepository;
        private readonly IRepository<QuestionAnswerViewCount> _questionAnswerViewCountRepository;

        public ReportsAppService(IRepository<Question> questionRepository, 
            IRepository<QuestionAnswer> questionAnsweRepository, 
            IRepository<QuestionAnswerRating> questionAnswerRatingRepository, 
            IRepository<QuestionAnswerViewCount> questionAnswerViewCountRepository)
        {
            _questionRepository = questionRepository;
            _questionAnsweRepository = questionAnsweRepository;
            _questionAnswerRatingRepository = questionAnswerRatingRepository;
            _questionAnswerViewCountRepository = questionAnswerViewCountRepository;
        }

        public PagedResultDto<FrequencyReportDto> GetFrequencyReportData(PagedResultRequestDto inputDto)
        {
            List<FrequencyReportDto>  frequencyReportDtos = new List<FrequencyReportDto>();

            var list = _questionRepository.GetAll().Include(x => x.CreatorUser).Include(x => x.QuestionAnswers)
                .GroupBy(x => x.CreatorUserId)
                .AsNoTracking().ToList();

            var questionAnswers = _questionAnsweRepository.GetAll().ToList();

            foreach (var l in list)
            {
                var questions = l.ToList();
                var frequencyReportDto = new FrequencyReportDto()
                {
                    UserFullName = questions.FirstOrDefault()?.CreatorUser.FullName,
                    QuestionSubmitCount = questions.Count,
                };

                var answers = questionAnswers.Where(x => x.CreatorUserId == l.Key).ToList();
                frequencyReportDto.QuestionAnswerSubmitCount = answers.Count;
                frequencyReportDto.AverageRatingOfQuestionAnswer = answers.Sum(x => x.RatingValue) / answers.Count;

                frequencyReportDto.QuestionAnswerViewedToOthersCount = 0;

                frequencyReportDtos.Add(frequencyReportDto);
            }


            PagedResultDto<FrequencyReportDto> resultDto =
                new PagedResultDto<FrequencyReportDto> (frequencyReportDtos.Count, frequencyReportDtos);

            return resultDto;
        }
    }

}