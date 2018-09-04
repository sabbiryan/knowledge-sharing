using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Timing;
using KS.Core.Models;
using KS.QuestionAnswers.Dto;
using KS.QuestionViewCounts.Dto;
using Microsoft.EntityFrameworkCore;

namespace KS.QuestionViewCounts
{
    public class QuestionViewCountAppService : AsyncCrudAppService<QuestionViewCount, QuestionViewCountDto, int, PagedResultRequestDto, CreateQuestionViewCountDto, QuestionViewCountDto>, IQuestionViewCountAppService
    {
        private readonly IRepository<QuestionViewCount> _questionViewCountRepository;

        public QuestionViewCountAppService(IRepository<QuestionViewCount> questionViewCountRepository) : base(questionViewCountRepository)
        {
            _questionViewCountRepository = questionViewCountRepository;
        }


        public override async Task<QuestionViewCountDto> Create(CreateQuestionViewCountDto input)
        {
            var questionViewCount = await _questionViewCountRepository.GetAll().Where(x=> x.QuestionId == input.QuestionId)
                .AsNoTracking().OrderByDescending(x => x.CreationTime)
                .FirstOrDefaultAsync();

            if (questionViewCount == null || (questionViewCount.CreationTime < Clock.Now.AddHours(-1)))
            {                
               return await base.Create(input);
            }

            return null;

        }

        public async Task CreateViewCount(CreateQuestionViewCountDto createQuestionViewCountDto)
        {
            var questionViewCountDto = await Create(createQuestionViewCountDto);
        }
    }
}
