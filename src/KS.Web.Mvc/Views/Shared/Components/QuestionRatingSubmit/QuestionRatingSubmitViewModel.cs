using System;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.Web.Views.Shared.Components.QuestionRatingSubmit
{
    [AutoMapFrom(typeof(QuestionRating))]
    public class QuestionRatingSubmitViewModel
    {        
        public int QuestionId { get; set; }
        
        public Rating Rating { get; set; }

        public double RatingValue { get; set; }
            
        public string Reason { get; set; }

        public bool IsEnableRatingSubmit { get; set; }
    }
}
