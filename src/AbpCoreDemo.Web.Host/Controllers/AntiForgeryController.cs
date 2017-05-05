using AbpCoreDemo.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace AbpCoreDemo.Web.Host.Controllers
{
    public class AntiForgeryController : AbpCoreDemoControllerBase
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