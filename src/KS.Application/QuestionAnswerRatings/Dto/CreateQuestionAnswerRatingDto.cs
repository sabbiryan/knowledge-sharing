using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Questions.Dto;

namespace KS.QuestionAnswerRatings.Dto
{
    [AutoMap(typeof(QuestionAnswerRating), typeof(QuestionAnswerRatingDto))]
    public class CreateQuestionAnswerRatingDto : EntityDto<int>
    {
        [Required]
        public int QuestionAnswerId { get; set; }

        [Required]
        public Rating Rating { get; set; }

        public string Reason { get; set; }
    }
}
