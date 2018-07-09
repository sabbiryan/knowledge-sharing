using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using KS.Core.Models.Emums;

namespace KS.Web.Views.Shared.Components.QuestionRatingSubmit
{
    public class QuestionRatingSubmitModalViewModel : EntityDto<int>
    {
        [Required]
        public int QuestionId { get; set; }

        [Required]
        public Rating Rating { get; set; }

        public string Reason { get; set; }

    }
}
