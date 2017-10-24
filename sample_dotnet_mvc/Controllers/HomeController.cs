using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_dotnet_mvc.Models;

namespace sample_dotnet_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            ViewData["Title"]="Sai Message";
            ViewData["Message"] = "Site Under Development";
            return View();
        }

        public IActionResult Photo()
        {
            ViewData["Title"] = "Photo Gallery";
            ViewData["Message"] = "Site Under Development";
            return View();
        }

        public IActionResult Donation()
        {
            ViewData["Title"] = "Donation";
            ViewData["Message"] = "Site Under Development";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About-New";
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
