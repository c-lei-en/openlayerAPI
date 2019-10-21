using Microsoft.AspNetCore.Antiforgery;
using openlayerAPI.Controllers;

namespace openlayerAPI.Web.Host.Controllers
{
    public class AntiForgeryController : openlayerAPIControllerBase
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
