using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AutoMapper;
using KS.Authorization.Users;
using KS.Controllers;
using KS.Questions;
using KS.Users;
using KS.Users.Dto;
using KS.Web.Models.Home;

namespace KS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KSControllerBase
    {
        private readonly IQuestionAppService _questionAppService;
        private readonly UserManager _userManager;

        public HomeController(IQuestionAppService questionAppService, UserManager userManager)
        {
            _questionAppService = questionAppService;
            _userManager = userManager;
        }

        public async Task<ActionResult> Index()
        {
            
            HomeViewModel viewModel = new HomeViewModel
            {                               
                PagedResultDto = await _questionAppService.GetAll(new PagedResultRequestDto(){MaxResultCount = 100}),
            };

            var user = await _userManager.GetUserByIdAsync(AbpSession.UserId.GetValueOrDefault());
            viewModel.CurrentUser = user.MapTo<UserDto>();

            return View(viewModel);
        }
	}
}
