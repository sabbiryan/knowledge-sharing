using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using KS.Questions.Dto;
using KS.Users.Dto;

namespace KS.Web.Models.Question
{
    public class QuestionViewModel
    {
        public UserDto CurrentUser { get; set; }

        public PagedResultDto<QuestionDto> PagedResultDto { get; set; }
    }
}
