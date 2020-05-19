using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith",
                               Id = 1 },
                new Customer { Name = "Mary Williams",
                               Id = 2 }
            };

            var view = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(view);
        }




        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith",
                               Id = 1 },
                new Customer { Name = "Mary Williams",
                               Id = 2 }
            };

            var index = id - 1;
            var customer = customers[index];


            var view = new CustomerViewModel
            {
                Name = customer.Name,
                Id = customer.Id
            };


            return View(view);

        }


    }
}