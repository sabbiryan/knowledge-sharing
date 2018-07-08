using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.QuestionRatings.Dto;
using KS.Questions;
using KS.Questions.Dto;
using Microsoft.EntityFrameworkCore;

namespace KS.QuestionRatings
{
    public class QuestionRatingAppService : AsyncCrudAppService<QuestionRating, QuestionRatingDto, int, PagedResultRequestDto, CreateQuestionRatingDto, QuestionRatingDto>, IQuestionRatingAppService
    {
        private readonly IRepository<QuestionRating> _questionRatingRepository;
        private readonly IRepository<Question> _questionRepository;

        public QuestionRatingAppService(IRepository<QuestionRating> questionRatingRepository, 
            IRepository<Question> questionRepository) : base(questionRatingRepository)
        {
            _questionRatingRepository = questionRatingRepository;
            _questionRepository = questionRepository;
        }


        public override async Task<QuestionRatingDto> Create(CreateQuestionRatingDto input)
        {
            var questionRatingDto = await base.Create(input);

            var question = await _questionRepository.GetAll().Where(x => x.Id == input.QuestionId)
                .Include(x => x.QuestionRatings).FirstOrDefaultAsync();

            var rating = (int) (question.QuestionRatings.Sum(x => (int) x.Rating) / question.QuestionRatings.Count);
            question.Rating = (Rating)rating;

            await _questionRepository.UpdateAsync(question);

            return questionRatingDto;
        }
    }
}
