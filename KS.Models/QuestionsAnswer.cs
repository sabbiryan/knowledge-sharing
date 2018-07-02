using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Notifications;
using KS.Authorization.Users;
using KS.Core.Models.Emums;

namespace KS.Core.Models
{
    public class QuestionsAnswer : FullAuditedEntity<int>
    {
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }

        public Rating? Rating { get; set; }
    }
}
