using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.Core.Models.Emums;
using KS.QuestionAnswers.Dto;
using KS.Questions.Dto;

namespace KS.Questions
{
    public interface IQuestionAnswerAppService : IAsyncCrudAppService<QuestionAnswerDto, int, PagedResultRequestDto, CreateQuestionAnswerDto, QuestionAnswerDto>
    {
    }
}