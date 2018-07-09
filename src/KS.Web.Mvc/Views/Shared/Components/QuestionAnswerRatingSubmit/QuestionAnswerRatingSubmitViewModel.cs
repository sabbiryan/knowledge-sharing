using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.Web.Views.Shared.Components.QuestionAnswerRatingSubmit
{
    [AutoMapFrom(typeof(QuestionAnswerRating))]
    public class QuestionAnswerRatingSubmitViewModel
    {        
        public int QuestionAnswerId { get; set; }
        
        public Rating Rating { get; set; }

        public double RatingValue { get; set; }
            
        public string Reason { get; set; }


    }
}
