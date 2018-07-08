using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.QuestionRatings.Dto
{
    [AutoMap(typeof(QuestionRating))]
    public class CreateQuestionRatingDto : EntityDto<int>
    {
        [Required]
        public int QuestionId { get; set; }

        [Required]
        public Rating Rating { get; set; }

        public string Reason { get; set; }
    }
}
