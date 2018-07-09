using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using KS.Authorization.Users;
using KS.Core.Models.Emums;

namespace KS.Core.Models
{
    public class Question : KsEntityBase<int>
    {

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual QuestionCategory QuestionCategory { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public QuestionQuality? Quality { get; set; }

        public Rating? Rating { get; set; }
        public double RatingValue { get; set; }

        public long QuestionViewCount { get; set; }

        //public bool IsArchived { get; set; }

        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<QuestionRating> QuestionRatings { get; set; }
        public virtual ICollection<QuestionViewCount> QuestionViewCounts { get; set; }


        public User CreatorUser { get; set; }
    }
}