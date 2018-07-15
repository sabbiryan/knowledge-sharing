using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KS.QuestionAnswerRatings.Dto;

namespace KS.Reports.Dto
{
    public class FrequencyReportDto
    {
        public string UserFullName { get; set; }

        public int QuestionSubmitCount { get; set; }

        public int QuestionAnswerSubmitCount { get; set; }

        public int QuestionAnswerViewedToOthersCount { get; set; }


        //public List<QuestionAnswerRatingDto> QuestionAnswerRatingDtos { get; set; } = new List<QuestionAnswerRatingDto>();

        public double AverageRatingOfQuestionAnswer { get; set; }
        public double AverageQuestionAnswerRating => Math.Round(AverageRatingOfQuestionAnswer, 2);
    }
}
