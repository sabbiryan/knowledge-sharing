using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.QuestionAnswers.Dto
{
    [AutoMap(typeof(QuestionAnswer))]
    public class CreateQuestionAnswerDto : EntityDto<int>
    {
        public int QuestionId { get; set; }

        [Required]
        public string AnswerText { get; set; }

        public Rating? Rating { get; set; }
        public double RatingValue { get; set; }
    }
}