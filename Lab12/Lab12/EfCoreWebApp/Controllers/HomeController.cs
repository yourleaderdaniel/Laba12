using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Linq;

namespace EfCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var companies = _context.Companies.ToList();
            return View(companies);
        }
    }
}
