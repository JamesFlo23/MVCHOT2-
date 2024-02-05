using Microsoft.AspNetCore.Mvc;
using MVCHOT2.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
namespace MVCHOT2.Controllers
{
    public class HomeController : Controller
    {
        private TestProductContext Context { get; set; }

        public HomeController(TestProductContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
