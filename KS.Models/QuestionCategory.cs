using Abp.Domain.Entities.Auditing;

namespace KS.Core.Models
{
    public class QuestionCategory : KsEntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}