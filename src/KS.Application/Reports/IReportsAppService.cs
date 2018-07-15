using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KS.Reports.Dto;

namespace KS.Reports
{
    public interface IReportsAppService : IApplicationService
    {
        PagedResultDto<FrequencyReportDto> GetFrequencyReportData(PagedResultRequestDto inputDto);
    }
}
