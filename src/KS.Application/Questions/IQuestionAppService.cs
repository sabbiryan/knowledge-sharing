﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.Core.Models.Emums;
using KS.Questions.Dto;

namespace KS.Questions
{
    public interface IQuestionAppService : IAsyncCrudAppService<QuestionDto, int, PagedResultRequestDto, CreateQuestionDto, QuestionDto>
    {
        Task AskAQuestionAsync(CreateQuestionDto input);
        Task RatingAQuestion(int questionId, Rating rating);
        Task<QuestionDto> GetQuestionDetail(int questionId);
        Task<PagedResultDto<QuestionDto>> GetAllCurrentUserQuestions(PagedResultRequestDto input);
    }
}