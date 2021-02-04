using HiltonFilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Index/default view
        public IActionResult Index()
        {
            return View();
        }

        //Podcast view
        public IActionResult Podcasts()
        {
            return View();
        }

        //Submission view that retrieves the default view
        [HttpGet]
        public IActionResult Submissions()
        {
            return View();
        }

        //Submission view after someone submits a movie
        [HttpPost]
        public IActionResult Submissions(Submissions submissions)
        {
            TempStorage.AddMovie(submissions);
            return View();
        }

        //Movie view
        public IActionResult Movies()
        {
            return View(TempStorage.Submissions);
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
