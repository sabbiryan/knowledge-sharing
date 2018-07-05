﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using KS.Controllers;
using KS.Questions;
using KS.Questions.Dto;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Controllers
{
    public class QuestionController : KSControllerBase
    {
        private readonly IQuestionAppService _questionAppService;
        private readonly IQuestionAnswerAppService _questionAnswerAppService;

        public QuestionController(IQuestionAppService questionAppService, 
            IQuestionAnswerAppService questionAnswerAppService)
        {
            _questionAppService = questionAppService;
            _questionAnswerAppService = questionAnswerAppService;
        }


        [HttpGet]
        public async Task<IActionResult> Answer(int questionId)
        {
            QuestionDto model =  await _questionAppService.GetQuestionDetail(questionId);
            model.QuestionAnswerInput.QuestionId = model.Id;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Answer(CreateQuestionAnswerDto model)
        {
            await _questionAnswerAppService.Create(model);

            return Redirect(Url.Action("Answer", "Question", new {questionId = model.QuestionId}));
        }


    }
}