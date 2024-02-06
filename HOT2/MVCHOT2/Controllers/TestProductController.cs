using Microsoft.AspNetCore.Mvc;
using MVCHOT2.Models;
using Microsoft.EntityFrameworkCore;
namespace MVCHOT2.Controllers
{
    public class TestProductController : Controller
    {
        private TestProductContext Context { get; set; }
        public TestProductController(TestProductContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = Context.TestProducts.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(TestProduct product)
        {
            Context.TestProducts.Remove(product);
            Context.SaveChanges();
            return RedirectToAction("Index","TestProducts");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit TestProduct";
            ViewBag.Categories = Context.Categories.OrderBy(g => g.CategoryName).ToList();
            var product = Context.TestProducts.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(TestProduct product)
        {
            if (ModelState.IsValid)
            {
                if (product.TestProductId == 0)
                {
                    Context.TestProducts.Add(product);
                }
                else
                {
                    Context.TestProducts.Update(product);
                }
                Context.SaveChanges();
                return RedirectToAction("Index", "TestProduct");
            }
            else
            {
                ViewBag.Action = (product.TestProductId == 0) ? "Add" : "Edit";
                ViewBag.Categories = Context.Categories.OrderBy(g => g.CategoryName).ToList();
                return View(product);
            }
        }

        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add New Product";
            ViewBag.Categories = Context.Categories.OrderBy(g => g.CategoryName).ToList();
            return View("Edit", new TestProduct());
        }

        public IActionResult Index()
        {
            var products = Context.TestProducts.Include(c => c.Category).OrderBy(c => c.ProductName).ToList();
            return View(products);
        }
    }
}
