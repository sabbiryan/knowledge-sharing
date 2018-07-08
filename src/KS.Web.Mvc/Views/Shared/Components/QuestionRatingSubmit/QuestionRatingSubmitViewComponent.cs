using System.Threading.Tasks;
using Abp.AutoMapper;
using KS.Questions;
using KS.Sessions;
using KS.Web.Views.Shared.Components.TenantChange;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Views.Shared.Components.RatingSubmit
{
    public class QuestionRatingSubmitViewComponent : KSViewComponent
    {
        private readonly IQuestionAppService _questionAppService;

        public QuestionRatingSubmitViewComponent(IQuestionAppService questionAppService)
        {
            _questionAppService = questionAppService;
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
