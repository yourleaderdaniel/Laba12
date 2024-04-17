using Microsoft.AspNetCore.Mvc;

namespace EfCoreWebApp.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
