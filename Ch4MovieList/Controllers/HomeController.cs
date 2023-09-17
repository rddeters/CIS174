﻿using Ch4MovieList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ch4MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }
        public HomeController(MovieContext ctx) => context = ctx;
        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList(); 
            return View(movies);
        }
    }
}

