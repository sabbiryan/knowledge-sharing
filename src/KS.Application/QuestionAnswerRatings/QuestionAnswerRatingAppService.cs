using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.QuestionAnswerRatings.Dto;
using KS.QuestionRatings;
using KS.Questions.Dto;
using Microsoft.EntityFrameworkCore;

namespace KS.QuestionAnswerRatings
{
    public class QuestionAnswerRatingAppService : AsyncCrudAppService<QuestionAnswerRating, QuestionAnswerRatingDto, int, PagedResultRequestDto, CreateQuestionAnswerRatingDto, QuestionAnswerRatingDto>, IQuestionAnswerRatingAppService
    {
        private readonly IRepository<QuestionAnswerRating> _questionAnswerRatingRepository;
        private readonly IRepository<QuestionAnswer> _questionAnswerRepository;

        public QuestionAnswerRatingAppService(IRepository<QuestionAnswerRating> questionAnswerRatingRepository, 
            IRepository<QuestionAnswer> questionAnswerRepository) : base(questionAnswerRatingRepository)
        {
            _questionAnswerRatingRepository = questionAnswerRatingRepository;
            _questionAnswerRepository = questionAnswerRepository;
        }


        public override async Task<QuestionAnswerRatingDto> Create(CreateQuestionAnswerRatingDto input)
        {
            QuestionAnswerRatingDto questionAnswerRatingDto;
            if(input.Id > 0)
            {
                var questionRating = await _questionAnswerRatingRepository.GetAsync(input.Id);
                questionAnswerRatingDto = questionRating.MapTo<QuestionAnswerRatingDto>();

                questionAnswerRatingDto.Rating = input.Rating;
                questionAnswerRatingDto.Reason = input.Reason;

                questionAnswerRatingDto = await base.Update(questionAnswerRatingDto);
            }
            else
            {
                questionAnswerRatingDto = await base.Create(input);
            }            

            var questionAnswer = await _questionAnswerRepository.GetAll().Where(x => x.Id == input.QuestionAnswerId)
                .Include(x => x.QuestionAnswerRatings).FirstOrDefaultAsync();

            if (questionAnswer != null)
            {
                questionAnswer.RatingValue = (questionAnswer.QuestionAnswerRatings.Sum(x => (int)x.Rating) / questionAnswer.QuestionAnswerRatings.Count);
                questionAnswer.Rating = (Rating)questionAnswer.RatingValue;

                await _questionAnswerRepository.UpdateAsync(questionAnswer);
            }

            return questionAnswerRatingDto;
        }

        public async Task<QuestionAnswerRatingDto> GetUserSubmitedQuestionAnswerRatingAsync(int questionAnswerId, long userId)
        {
            var questionAnswerRating = await _questionAnswerRatingRepository.FirstOrDefaultAsync(x =>
                x.CreatorUserId == userId && x.QuestionAnswerId == questionAnswerId);

            var questionRatingDto = questionAnswerRating.MapTo<QuestionAnswerRatingDto>();

            return questionRatingDto;
        }
    }
}
