using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.QuestionAnswerRatings.Dto;

namespace KS.QuestionAnswerRatings
{
    public interface IQuestionAnswerRatingAppService : IAsyncCrudAppService<QuestionAnswerRatingDto, int, PagedResultRequestDto, CreateQuestionAnswerRatingDto, QuestionAnswerRatingDto>
    {
        Task<QuestionAnswerRatingDto> GetUserSubmitedQuestionAnswerRatingAsync(int questionAnswerId, long userId);
    }
}