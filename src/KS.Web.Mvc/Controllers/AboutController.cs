using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using KS.Controllers;

namespace KS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : KSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
