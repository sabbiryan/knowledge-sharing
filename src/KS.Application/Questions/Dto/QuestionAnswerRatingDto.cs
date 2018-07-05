using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(QuestionAnswerRating))]
    public class QuestionAnswerRatingDto : DtoBase<int>
    {
        public int QuestionAnswerId { get; set; }        
        public Rating Rating { get; set; }
    }
}