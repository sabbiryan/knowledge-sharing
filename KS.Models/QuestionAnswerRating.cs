using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Core.Models.Emums;

namespace KS.Core.Models
{
    public class QuestionAnswerRating : KsEntityBase<int>
    {
        public int QuestionAnswerId { get; set; }
        [ForeignKey("QuestionAnswerId")]
        public virtual QuestionAnswer QuestionAnswer { get; set; }

        public Rating Rating { get; set; }

        public string Reason { get; set; }
    }
}