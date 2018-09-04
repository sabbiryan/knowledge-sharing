using System;
using System.Collections.Generic;
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
    public class QuestionAppService : AsyncCrudAppService<Question, QuestionDto, int, PagedResultRequestDto, CreateQuestionDto, QuestionDto>, IQuestionAppService
    {
        private readonly IRepository<Question> _questionRepository;

        public QuestionAppService(IRepository<Question> questionRepository) : base(questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<QuestionDto> UpdateQuestion(CreateQuestionDto input)
        {
            var question = await _questionRepository.GetAsync(input.Id);

            var questionDto = question.MapTo<QuestionDto>();
            questionDto.Name = input.Name;
            questionDto.Description = input.Description;

            return await base.Update(questionDto);
        }

        public async Task AskAQuestionAsync(CreateQuestionDto input)
        {
            try
            {
                var question = input.MapTo<Question>();

                await _questionRepository.InsertAsync(question);
            }
            catch (Exception e)
            {
                // ignored
            }
        }

        public Task RatingAQuestion(int questionId, Rating rating)
        {
            throw new NotImplementedException();
        }

        public async Task<QuestionDto> GetQuestionDetail(int questionId)
        {
            var question = await _questionRepository.GetAll().Where(x => x.Id == questionId)
                .Include(x=> x.CreatorUser)
                .Include(x => x.QuestionAnswers)
                .ThenInclude(y => y.QuestionAnswerComments)
                .Include(x=> x.QuestionAnswers)
                .ThenInclude(x=> x.CreatorUser)
                .FirstOrDefaultAsync();

            var dto = question.MapTo<QuestionDto>();

            return dto;
        }

        public async Task<PagedResultDto<QuestionDto>> GetAllCurrentUserQuestions(PagedResultRequestDto input)
        {
            var questions = await _questionRepository.GetAll().Where(x => x.CreatorUserId == AbpSession.UserId)
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount).ToListAsync();

            var questionDtos = questions.MapTo<List<QuestionDto>>();

            return new PagedResultDto<QuestionDto>(questionDtos.Count, questionDtos);
        }
    }
}
