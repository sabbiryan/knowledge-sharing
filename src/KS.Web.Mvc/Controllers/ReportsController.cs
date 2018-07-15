using Abp.Application.Services.Dto;
using KS.Controllers;
using KS.Reports;
using KS.Web.Models.Reports;
using Microsoft.AspNetCore.Mvc;

namespace KS.Web.Controllers
{
    public class ReportsController : KSControllerBase
    {
        private readonly IReportsAppService _reportsAppService;


        public ReportsController(IReportsAppService reportsAppService)
        {
            _reportsAppService = reportsAppService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            FrequencyReportViewModel viewModel = new FrequencyReportViewModel
            {
                PagedResultDto =
                    _reportsAppService.GetFrequencyReportData(new PagedResultRequestDto() {MaxResultCount = 500})
            };


            return View(viewModel);
        }
    }
}