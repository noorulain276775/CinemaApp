using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaApp.Models;
using CinemaApp.ViewModels;

namespace CinemaApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: All Movies
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
            var customers = new List<Customer>
            {
                new Customer {Name = "Noor Ibrahim"},
                new Customer {Name = "Bilal Ahmed"},
                new Customer {Name = "Ghazia"},
                new Customer {Name = "Rica"},
                new Customer {Name = "Rose"},
                new Customer {Name = "May"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }


        // GET: Movies By Release Date
        [Route("movies/released/{year}/{month:regex(\\d{1,2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"Year: {year}, Month: {month}");
        }



    }
}