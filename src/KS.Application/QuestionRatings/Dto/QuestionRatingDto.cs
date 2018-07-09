using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Shared.Dto;

namespace KS.QuestionRatings.Dto
{
    [AutoMap(typeof(QuestionRating))]
    public class QuestionRatingDto : DtoBase<int>
    {
        public int QuestionId { get; set; }

        public Rating Rating { get; set; }

        public string Reason { get; set; }
    }
}
