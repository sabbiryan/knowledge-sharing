using System;
using Abp.Application.Services.Dto;
using KS.Questions.Dto;

namespace KS
{
    public class DtoBase<T> : EntityDto<T>
    {
        public long CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModificationTime { get; set; }

        public SimpleUserDto CreatorUser { get; set; }
    }
}