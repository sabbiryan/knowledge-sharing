using System;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using KS.QuestionAnswerRatings;
using KS.QuestionRatings;
using KS.Questions;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Views.Shared.Components.QuestionAnswerRatingSubmit
{
    public class QuestionAnswerRatingSubmitViewComponent : KSViewComponent
    {
        private readonly IQuestionAnswerRatingAppService _questionAnswerRatingAppService;
        private readonly IQuestionAnswerAppService _questionAnswerAppService;
         

        public QuestionAnswerRatingSubmitViewComponent(IQuestionAnswerRatingAppService questionAnswerRatingAppService, 
            IQuestionAnswerAppService questionAnswerAppService)
        {
            _questionAnswerRatingAppService = questionAnswerRatingAppService;
            _questionAnswerAppService = questionAnswerAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int questionAnswerId)
        {
            var questionAnswerDto = await _questionAnswerAppService.Get(new EntityDto<int>(questionAnswerId));

            var model = new QuestionAnswerRatingSubmitViewModel(){
                QuestionAnswerId = questionAnswerId,
                Rating = questionAnswerDto.Rating.GetValueOrDefault(),
                RatingValue = Math.Round(questionAnswerDto.RatingValue, 2)
            };

            return View(model);
        }
    }
}
