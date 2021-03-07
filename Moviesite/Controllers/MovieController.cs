namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Adventure", Value="1"},
                new SelectListItem() { Text="Action", Value="2"},
                new SelectListItem() { Text="Sci-Fi", Value="3"},
                new SelectListItem() { Text="Comedy", Value="4"},
            };


            ViewBag.CategoryList = Categories;
            return View();
        }

        public IActionResult Edit()
        {
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Adventure", Value="1"},
                new SelectListItem() { Text="Action", Value="2"},
                new SelectListItem() { Text="Sci-Fi", Value="3"},
                new SelectListItem() { Text="Comedy", Value="4"},
            };


            ViewBag.CategoryList = Categories;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
