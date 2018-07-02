using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Authorization.Users;

namespace KS.Core.Models
{
    public class QuestionsAnswerComment : FullAuditedEntity<int>
    {
        public int QuestionAnswerId { get; set; }
        [ForeignKey("QuestionAnswerId")]
        public virtual QuestionsAnswer QuestionsAnswer { get; set; }

        public string Comment { get; set; }
    }
}