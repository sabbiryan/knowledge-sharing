using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Core.Models.Emums;

namespace KS.Core.Models
{
    public class QuestionRating : KsEntityBase<int>
    {
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        public Rating Rating { get; set; }
    }
}