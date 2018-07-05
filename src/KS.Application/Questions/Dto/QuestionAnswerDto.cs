using System.Collections.Generic;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(QuestionAnswer))]
    public class QuestionAnswerDto : DtoBase<int>
    {
        public int QuestionId { get; set; }

        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }

        public Rating? Rating { get; set; }

        public List<QuestionAnswerCommentDto> QuestionAnswerComments { get; set; } = new List<QuestionAnswerCommentDto>();
    }
}