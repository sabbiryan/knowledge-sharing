using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.Core.Models;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(QuestionAnswerComment))]
    public class QuestionAnswerCommentDto : DtoBase<int>
    {
        public int QuestionAnswerId { get; set; }        
        public string Comment { get; set; }

    }
}