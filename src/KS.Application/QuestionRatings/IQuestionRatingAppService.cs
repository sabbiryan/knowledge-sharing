using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.QuestionRatings.Dto;
using KS.Questions.Dto;

namespace KS.QuestionRatings
{
    public interface IQuestionRatingAppService : IAsyncCrudAppService<QuestionRatingDto, int, PagedResultRequestDto, CreateQuestionRatingDto, QuestionRatingDto>
    {
    }
}