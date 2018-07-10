﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using KS.Controllers;
using KS.QuestionAnswerRatings;
using KS.QuestionAnswers;
using KS.QuestionAnswers.Dto;
using KS.QuestionRatings;
using KS.Questions;
using KS.Questions.Dto;
using KS.QuestionViewCounts;
using KS.QuestionViewCounts.Dto;
using KS.Web.Views.Shared.Components.QuestionAnswerRatingSubmit;
using KS.Web.Views.Shared.Components.QuestionRatingSubmit;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Controllers
{
    public class QuestionController : KSControllerBase
    {
        private readonly IQuestionAppService _questionAppService;
        private readonly IQuestionAnswerAppService _questionAnswerAppService;
        private readonly IQuestionRatingAppService _questionRatingAppService;
        private readonly IQuestionAnswerRatingAppService _questionAnswerRatingAppService;
        private readonly IQuestionViewCountAppService _questionViewCountAppService;

        public QuestionController(IQuestionAppService questionAppService, 
            IQuestionAnswerAppService questionAnswerAppService, 
            IQuestionRatingAppService questionRatingAppService, 
            IQuestionAnswerRatingAppService questionAnswerRatingAppService, 
            IQuestionViewCountAppService questionViewCountAppService)
        {
            _questionAppService = questionAppService;
            _questionAnswerAppService = questionAnswerAppService;
            _questionRatingAppService = questionRatingAppService;
            _questionAnswerRatingAppService = questionAnswerRatingAppService;
            _questionViewCountAppService = questionViewCountAppService;
        }


        [HttpGet]
        public async Task<IActionResult> Answer(int questionId)
        {
            QuestionDto model =  await _questionAppService.GetQuestionDetail(questionId);
            if(model != null ) model.QuestionAnswerInput.QuestionId = model.Id;

            if (model != null && model.CreatorUserId != AbpSession.UserId)
            {
                await _questionViewCountAppService.Create(new CreateQuestionViewCountDto()
                {
                    QuestionId = model.Id,
                    Count = 1
                });                
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Answer(CreateQuestionAnswerDto model)
        {
            await _questionAnswerAppService.Create(model);

            return Redirect(Url.Action("Answer", "Question", new {questionId = model.QuestionId}));
        }


        public async Task<PartialViewResult> QuestionRatingSubmitModal(QuestionRatingSubmitModalViewModel input)
        {
            var questionRatingDto = await _questionRatingAppService.GetUserSubmitedQuestionRatingAsync(input.QuestionId,
                AbpSession.UserId.GetValueOrDefault());

            var viewModel = new QuestionRatingSubmitModalViewModel()
            {
                QuestionId = input.QuestionId,                
            };

            if (questionRatingDto != null)
            {
                viewModel.Id = questionRatingDto.Id;
                viewModel.Rating = questionRatingDto.Rating;
                viewModel.Reason = questionRatingDto.Reason;
            }

            return PartialView("/Views/Shared/Components/QuestionRatingSubmit/_QuestionRatingSubmitModal.cshtml", viewModel);
        }


        public async Task<PartialViewResult> QuestionAnswerRatingSubmitModal(QuestionAnswerRatingSubmitModalViewModel input)
        {
            var questionAnswerRatingDto = await _questionAnswerRatingAppService.GetUserSubmitedQuestionAnswerRatingAsync(input.QuestionAnswerId,
                AbpSession.UserId.GetValueOrDefault());

            var viewModel = new QuestionAnswerRatingSubmitModalViewModel()
            {
                QuestionAnswerId = input.QuestionAnswerId                
            };

            if (questionAnswerRatingDto != null)
            {
                viewModel.Id = questionAnswerRatingDto.Id;
                viewModel.Rating = questionAnswerRatingDto.Rating;
                viewModel.Reason = questionAnswerRatingDto.Reason;
            }

            return PartialView("/Views/Shared/Components/QuestionAnswerRatingSubmit/_QuestionAnswerRatingSubmitModal.cshtml", viewModel);
        }

    }
}
