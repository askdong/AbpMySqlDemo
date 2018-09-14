using Microsoft.AspNetCore.Antiforgery;
using TreeMis.Controllers;

namespace TreeMis.Web.Host.Controllers
{
    public class AntiForgeryController : TreeMisControllerBase
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
