using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Social_Media_Links_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialMediaLinksOptions _SocialMediaLinksOptions;

        public HomeController(IOptions<SocialMediaLinksOptions> socialMediaLinksOptions)
        {
            _SocialMediaLinksOptions = socialMediaLinksOptions.Value;
        }

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.SocialMediaLinks = _SocialMediaLinksOptions;
            return View();
        }
    }
}
