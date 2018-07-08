using System.ComponentModel.DataAnnotations.Schema;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Sessions.Dto;

namespace KS.Web.Views.Shared.Components.RatingSubmit
{
    [AutoMapFrom(typeof(QuestionRating))]
    public class QuestionRatingSubmitViewModel
    {
        public int QuestionId { get; set; }
        
        public Rating Rating { get; set; }

        public string Reason { get; set; }
    }
}
