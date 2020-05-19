using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movies = new List<Movie>
            { 
                new Movie { Name = "Shrek!" } 
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var view = new RandomMovieViewModel
            {
                Movies = movies,
                Customers = customers
            };

            return View(view);
        }



        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek!" }
            };

            var view = new RandomMovieViewModel
            {
                Movies = movies
            };
            return View(view);
        }


    }
}