﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASP.NET_Core_MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ////return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
