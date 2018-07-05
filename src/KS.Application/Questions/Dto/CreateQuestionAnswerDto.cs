using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(QuestionAnswer))]
    public class CreateQuestionAnswerDto : EntityDto<int>
    {
        public int QuestionId { get; set; }

        public string AnswerText { get; set; }
    }
}