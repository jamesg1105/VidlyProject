using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Billy Willy" },
                new Customer { Id = 2, Name = "Willy Nilly" }
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
        [Route("Customers/CustomerDetails/{Id}/{Name}")]
        public ActionResult Details(int Id, string Name)
        {
            return Content(Name);
        }
    }
}