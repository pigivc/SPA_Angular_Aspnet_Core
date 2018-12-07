using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace SPA_AngularJS_MVC_Core.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllMovies()
        {
            return PartialView("AllMovies");
        }

        public IActionResult AddMovie()
        {
            return PartialView("AddMovie");
        }

        public IActionResult EditMovie()
        {
            return PartialView("EditMovie");
        }

        public IActionResult DeleteMovie()
        {
            return PartialView("DeleteMovie");
        }
    }
}