using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using SPA_AngularJS_MVC_Core.Models;

namespace SPA_AngularJS_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        IMovieRepo _movieRepo;
        public HomeController(IMovieRepo repo)
        {
            _movieRepo = repo;
        }
        public IActionResult Index()
        {
            //var id = _movieRepo.CreateMovie(new Entities.Movie
            //{ Gener = "Drama", ReleaseDate = new DateTime(2017, 11, 27), Title = "Incredibles" });
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
