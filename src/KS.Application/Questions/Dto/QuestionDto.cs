using System.Collections.Generic;
using System.Linq;
using Abp.AutoMapper;
using KS.Core.Models;
using KS.Core.Models.Emums;
using KS.Shared.Dto;

namespace KS.Questions.Dto
{
    [AutoMap(typeof(Question))]
    public class QuestionDto : DtoBase<int>
    {
        public int? CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public QuestionQuality? Quality { get; set; }

        public Rating? Rating { get; set; }                      
        public double RatingValue { get; set; }                      

        public string ShortDiscription => Description.ToArray().ToList().Count > 100
            ? string.Join(" ", Description.ToArray().ToList().Take(100))
            : Description;

        public List<QuestionAnswerDto> QuestionAnswers { get; set; } = new List<QuestionAnswerDto>();

        public CreateQuestionAnswerDto QuestionAnswerInput { get; set; } = new CreateQuestionAnswerDto();
    }
}