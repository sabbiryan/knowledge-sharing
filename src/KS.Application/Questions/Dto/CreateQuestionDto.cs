using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(Question))]
    public class CreateQuestionDto : EntityDto<int>
    {
        public int? CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public QuestionQuality? Quality { get; set; }

        public Rating? Rating { get; set; }
    }
}
