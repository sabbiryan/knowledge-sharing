using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Questions.Dto;

namespace KS.Questions
{
    public class QuestionAppService : AsyncCrudAppService<Question, QuestionDto, int, PagedResultRequestDto, CreateQuestionDto, QuestionDto>, IQuestionAppService
    {
        private readonly IRepository<Question> _questionRepository;

        public QuestionAppService(IRepository<Question> questionRepository) : base(questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task AskAQuestionAsync(CreateQuestionDto input)
        {
            var question = input.MapTo<Question>();

            await _questionRepository.InsertAsync(question);
        }

        public Task RatingAQuestion(int questionId, Rating rating)
        {
            throw new NotImplementedException();
        }
    }
}
