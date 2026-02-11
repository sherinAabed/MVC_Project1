using Azure.Core;
using kASHOP.Data;
using kASHOP.Models;
using Microsoft.AspNetCore.Mvc;

namespace kASHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var categorise = context.Categories.ToList();
            //var categorise = context.Categories;

            return View(categorise);
            
        }

        public IActionResult Create() {
            return View();
        }
        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid) {
                var category = context.Categories.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("create", request);
        }

        public IActionResult Remove(int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);

            return View(category);
        }

        public IActionResult Update(Category request,int id)
        {
            if (ModelState.IsValid)
            {

                context.Categories.Update(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View("Edit",request);
        }
    }

}

