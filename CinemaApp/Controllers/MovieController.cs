using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaApp.Models;

namespace CinemaApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "The Shawshank Redemption",
                Genre = "Drama",
                Director = "Frank Darabont",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ReleaseDate = new DateTime(1994, 10, 14),
                Duration = 142,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg",
                TrailerUrl = "https://www.youtube.com/watch?v=6hB3S9bIaco"
            };

            return View(movie);
        }
    }
}