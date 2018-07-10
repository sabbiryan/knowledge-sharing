using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;

namespace KS.QuestionViewCounts.Dto
{
    [AutoMap(typeof(QuestionViewCount))]
    public class CreateQuestionViewCountDto : EntityDto<int>
    {
        [Required]
        public int QuestionId { get; set; }

        public long Count { get; set; } = 1;
    }
}