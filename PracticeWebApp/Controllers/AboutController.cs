using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeWebApp.Models;


namespace PracticeWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AboutMe()
        {
            return View();
        }
    }
}