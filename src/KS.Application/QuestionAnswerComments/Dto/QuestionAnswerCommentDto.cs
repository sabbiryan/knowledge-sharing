using Abp.AutoMapper;
using KS.Core.Models;
using KS.Shared.Dto;

namespace KS.QuestionAnswerComments.Dto
{
    [AutoMap(typeof(QuestionAnswerComment))]
    public class QuestionAnswerCommentDto : DtoBase<int>
    {
        public int QuestionAnswerId { get; set; }    
        
        public string Comment { get; set; }

    }
}