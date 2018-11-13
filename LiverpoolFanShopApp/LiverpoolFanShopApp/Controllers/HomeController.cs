using System.Diagnostics;
using System.Linq;
using LiverpoolFanShopApp.Data;
using LiverpoolFanShopApp.Models;
using LiverpoolFanShopApp.ViewModel.Error;
using Microsoft.AspNetCore.Mvc;

namespace LiverpoolFanShopApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
           this._context = context;
        }
        public IActionResult Index()
        {
           // _context.Users.All(u => u.FirstName == "");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
