using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(Question))]
    public class QuestionDto : EntityDto<int>
    {
        public int? CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public QuestionQuality? Quality { get; set; }

        public Rating? Rating { get; set; }
    }
}