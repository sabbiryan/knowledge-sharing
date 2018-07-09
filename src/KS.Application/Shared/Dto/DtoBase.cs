using System;
using Abp.Application.Services.Dto;

namespace KS.Shared.Dto
{
    public class DtoBase<T> : EntityDto<T>
    {
        public long CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }

        public SimpleUserDto CreatorUser { get; set; }
    }
}