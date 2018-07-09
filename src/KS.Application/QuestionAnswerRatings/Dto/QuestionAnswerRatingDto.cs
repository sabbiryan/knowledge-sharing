using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Shared.Dto;

namespace KS.QuestionAnswerRatings.Dto
{
    [AutoMap(typeof(QuestionAnswerRating))]
    public class QuestionAnswerRatingDto : DtoBase<int>
    {
        public int QuestionAnswerId { get; set; }

        public Rating Rating { get; set; }

        public string Reason { get; set; }
    }
}
