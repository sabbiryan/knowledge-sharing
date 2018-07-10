using Abp.AutoMapper;
using KS.Core.Models;
using KS.Shared.Dto;

namespace KS.QuestionViewCounts.Dto
{
    [AutoMap(typeof(QuestionViewCount))]
    public class QuestionViewCountDto : DtoBase<int>
    {
        public int QuestionId { get; set; }

        public long Count { get; set; } = 1;
    }
}