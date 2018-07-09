using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using KS.Core.Models.Emums;

namespace KS.Web.Views.Shared.Components.QuestionAnswerRatingSubmit
{
    public class QuestionAnswerRatingSubmitModalViewModel : EntityDto<int>
    {
        [Required]
        public int QuestionAnswerId { get; set; }

        [Required]
        public Rating Rating { get; set; }

        public string Reason { get; set; }

    }
}
