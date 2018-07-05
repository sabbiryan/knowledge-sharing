using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Questions.Dto;
using Microsoft.EntityFrameworkCore;

namespace KS.Questions
{
    public class QuestionAnswerAppService : AsyncCrudAppService<QuestionAnswer, QuestionAnswerDto, int, PagedResultRequestDto, CreateQuestionAnswerDto, QuestionAnswerDto>, IQuestionAnswerAppService
    {
        private readonly IRepository<QuestionAnswer> _questionRepository;

        public QuestionAnswerAppService(IRepository<QuestionAnswer> questionRepository) : base(questionRepository)
        {
            _questionRepository = questionRepository;
        }

    }
}
