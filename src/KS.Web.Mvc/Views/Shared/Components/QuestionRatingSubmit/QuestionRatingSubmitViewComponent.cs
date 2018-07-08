using System.Threading.Tasks;
using KS.QuestionRatings;
using KS.Questions;
using KS.Web.Views.Shared.Components.RatingSubmit;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Views.Shared.Components.QuestionRatingSubmit
{
    public class QuestionRatingSubmitViewComponent : KSViewComponent
    {
        private readonly IQuestionRatingAppService _questionRatingAppService;

        public QuestionRatingSubmitViewComponent(IQuestionRatingAppService questionRatingAppService)
        {
            _questionRatingAppService = questionRatingAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int questionId)
        {
            //var loginInfo = await _questionAppService.GetUserSubmitedQuestionRating(AbpSession.UserId, questionId);
            //var model = loginInfo.MapTo<QuestionRatingSubmitViewModel>();

            var model = new QuestionRatingSubmitViewModel(){
                QuestionId = questionId
            };

            return View(model);
        }
    }
}
