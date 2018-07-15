using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KS.QuestionAnswerRatings.Dto;
using KS.Reports.Dto;

namespace KS.Web.Models.Reports
{
    
    public class FrequencyReportViewModel
    {
        public PagedResultDto<FrequencyReportDto> PagedResultDto { get; set; }
    }
}
