using CarReview.Models;
using CarReview.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category>categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = categoryRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryRepo.Create(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Category model = categoryRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryRepo.Update(category);

                return RedirectToAction("Details", "Category", new { id = category.CategoryId });

            }
            return View();
        }
    }   
}
