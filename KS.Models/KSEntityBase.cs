using Abp.Domain.Entities.Auditing;
using KS.Authorization.Users;

namespace KS.Core.Models
{
    public class KsEntityBase<T> : FullAuditedEntity<T>
    {
        public virtual User CreatorUser { get; set; }
    }
}
