using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Authorization.Users;
using KS.Core.Models.Emums;

namespace KS.Core.Models
{
    public class Question : FullAuditedEntity<int>
    {

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual QuestionCategory QuestionCategory { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public QuestionQuality? Quality { get; set; }

        public Rating? Rating { get; set; }
    }
}