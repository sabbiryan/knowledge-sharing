using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Authorization.Users;

namespace KS.Core.Models
{
    public class QuestionViewCount : KsEntityBase<int>
    {
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        public long Count { get; set; } = 1;
    }
}