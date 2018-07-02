using Microsoft.AspNetCore.Antiforgery;
using KS.Controllers;

namespace KS.Web.Host.Controllers
{
    public class AntiForgeryController : KSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
