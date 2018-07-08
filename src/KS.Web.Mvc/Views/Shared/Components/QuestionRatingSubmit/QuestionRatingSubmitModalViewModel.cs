using System.ComponentModel.DataAnnotations;
using KS.Core.Models.Emums;

namespace KS.Web.Views.Shared.Components.RatingSubmit
{
    public class QuestionRatingSubmitModalViewModel
    {
        [Required]
        public Rating Rating { get; set; }

        public string Reason { get; set; }

    }
}
