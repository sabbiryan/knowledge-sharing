using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Models
{
    public class QuestionAnswerViewCount : KsEntityBase<int>
    {
        public int QuestionAnswerId { get; set; }
        [ForeignKey("QuestionAnswerId")]
        public virtual QuestionAnswer QuestionAnswer { get; set; }

        public long Count { get; set; } = 1;
    }
}