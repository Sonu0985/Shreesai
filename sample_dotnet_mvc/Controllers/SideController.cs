using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample_dotnet_mvc.Models;

namespace sample_dotnet_mvc.Controllers
{
    public class SideController : Controller
    {

		public IActionResult Saiblog()
		{
			ViewData["Title"] = "SaiBlog";
			ViewData["Message"] = "Site Under Development";
			return View();
		}


		public IActionResult Information()
		{
			ViewData["Title"] = "Information";
			ViewData["Message"] = "Site Under Development";
			return View();
		}

        public IActionResult Current()
        {
            ViewData["Title"] = "Current Project";
            ViewData["Message"] = "Site Under Development";
            return View();
        }

		public IActionResult FuturePlan()
		{
			ViewData["Title"] = "Future Plan Project";
			ViewData["Message"] = "Site Under Development";
			return View();
		}

		public IActionResult Suggestion()
		{
			ViewData["Title"] = "Suggestion";
			ViewData["Message"] = "Site Under Development";
			return View();
		}

		public IActionResult News()
		{
			ViewData["Title"] = "Future Plan Project";
			ViewData["Message"] = "Site Under Development";
			return View();
		}
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page is from Side Controller.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
