using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.QuestionAnswers.Dto;

namespace KS.QuestionAnswers
{
    public interface IQuestionAnswerAppService : IAsyncCrudAppService<QuestionAnswerDto, int, PagedResultRequestDto, CreateQuestionAnswerDto, QuestionAnswerDto>
    {
    }
}