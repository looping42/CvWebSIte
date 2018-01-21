using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CvSite.Models;

namespace CvSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["date"] = DateTime.Now.ToLongDateString();
            ApiWeather apiWeather = new ApiWeather();
            OpenWeatherResponse weatherResponse = apiWeather.GetCity(2992890).Result;
            return View(weatherResponse);
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

        public IActionResult CVIndex()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}