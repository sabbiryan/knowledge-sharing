using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Authorization.Users;

namespace KS.Core.Models
{
    public class QuestionAnswerComment : KsEntityBase<int>
    {
        public int QuestionAnswerId { get; set; }
        [ForeignKey("QuestionAnswerId")]
        public virtual QuestionAnswer QuestionAnswer { get; set; }

        public string Comment { get; set; }
    }
}