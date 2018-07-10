using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using KS.Core.Models;
using KS.QuestionAnswers.Dto;
using KS.Questions;

namespace KS.QuestionAnswers
{
    public class QuestionAnswerAppService : AsyncCrudAppService<QuestionAnswer, QuestionAnswerDto, int, PagedResultRequestDto, CreateQuestionAnswerDto, QuestionAnswerDto>, IQuestionAnswerAppService
    {
        private readonly IRepository<QuestionAnswer> _questionRepository;

        public QuestionAnswerAppService(IRepository<QuestionAnswer> questionRepository) : base(questionRepository)
        {
            _questionRepository = questionRepository;
        }

    }
}
