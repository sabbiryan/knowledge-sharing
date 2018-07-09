using System;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using KS.QuestionRatings;
using KS.Questions;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Views.Shared.Components.QuestionRatingSubmit
{
    public class QuestionRatingSubmitViewComponent : KSViewComponent
    {
        private readonly IQuestionRatingAppService _questionRatingAppService;
        private readonly IQuestionAppService _questionAppService;

        public QuestionRatingSubmitViewComponent(IQuestionRatingAppService questionRatingAppService, 
            IQuestionAppService questionAppService)
        {
            _questionRatingAppService = questionRatingAppService;
            _questionAppService = questionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int questionId)
        {
            var questionDto = await _questionAppService.Get(new EntityDto<int>(questionId));

            var model = new QuestionRatingSubmitViewModel(){
                QuestionId = questionId,
                Rating = questionDto.Rating.GetValueOrDefault(),
                RatingValue = Math.Round(questionDto.RatingValue, 2)
            };

            return View(model);
        }
    }
}
