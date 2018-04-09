using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        [Route("Movies")]
        public ActionResult Movies()
        {
            var movie = new List<Movie> {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Billy Madison"}
            };

            var viewModel = new MovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }

        [Route("Movies/MovieDetails/{Id}/{Name}")]
        public ActionResult Details(int Id, string Name)
        {
            return Content(Name);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        ////Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}