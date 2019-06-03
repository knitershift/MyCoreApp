using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Read(int id, string name, int category)
        {
            return Content(id.ToString() + " "  + name + " " + category);
            var blog = new Blog { Title = "My Title", Content = "The Content", Author = "Jack" };
            return View(blog);
        }

        public IActionResult Time()
        {
            ViewData["Time"] = DateTime.Now.ToLongTimeString();
            ViewData["Name"] = "Bill";

            var list = new List<int>() { 1, 543, 23464 };

            ViewData["List"] = list;

            return View();
        }


        public IActionResult WorkerInfo()
        {

            var worker1 = new Worker("Ivan", 3000, 500);
            var worker2 = new Worker("Taras", 4000, 200);
            var worker3 = new Worker("Max", 15000, 300);

            var blog = new Blog { Title = "My Title", Content = "The Content", Author = "Jack" };

            var listBlogs = new List<Blog> { blog };
            var listWorkers = new List<Worker> { worker1, worker2, worker3 };

            var model = new BlogsAndWorkersViewModel();
            model.Blogs = listBlogs;
            model.Workers = listWorkers;

            return View(model);
        }

    }
}