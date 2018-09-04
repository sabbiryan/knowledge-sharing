using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.QuestionAnswers.Dto;
using KS.QuestionViewCounts.Dto;

namespace KS.QuestionViewCounts
{
    public interface IQuestionViewCountAppService : IAsyncCrudAppService<QuestionViewCountDto, int, PagedResultRequestDto, CreateQuestionViewCountDto, QuestionViewCountDto>
    {
        Task CreateViewCount(CreateQuestionViewCountDto createQuestionViewCountDto);
    }
}