using CarReview.Models;
using CarReview.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarContent.Controllers
{
    public class ContentController : Controller
    {
        readonly IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }
        
        public ViewResult Index()
        {
            //CarRepository carRepo = new CarRepository();
            var model = contentRepo.GetAll();
            return View(model);
        }

        //public ActionResult Index()
        //{
        //    List<Category> ListCategories = new List<Category>()
        //    {
        //        new Category() { CategoryId =1, CategoryName=""},
        //        new Category() { CategoryId =2, CategoryName=""},
        //        new Category() { CategoryId =3, CategoryName=""},
        //        new Category() { CategoryId =4, CategoryName=""},
        //        new Category() { CategoryId =5, CategoryName=""},
        //        new Category() { CategoryId =6, CategoryName=""},
        //        new Category() { CategoryId =7, CategoryName=""},
        //        new Category() { CategoryId =8, CategoryName=""},
        //        new Category() { CategoryId =9, CategoryName=""}
        //    };
        //    ViewBag.Category = new SelectList(ListCategories, "CategpryId", "CategoryName");
        //        return View();
        //}

        public ViewResult Details(int id)
        {
            var model = contentRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Content content)
        {
            if (ModelState.IsValid)
            {
                content.PublishDate = DateTime.Now;
                contentRepo.Create(content);
                return RedirectToAction("Details", "Category", new { id = content.CategoryId });
            }
            return View(content);
        }
        [HttpGet]
        public ViewResult CreateByCategoryId(int id)
        {
            ViewBag.CategoryId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Update(Content content)
        {

            content.PublishDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                contentRepo.Update(content);
                return RedirectToAction("Details", "Category", new { id = content.CategoryId });
            }

            return View(content);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Content content = contentRepo.GetById(id);
            return View(content);
        }

        public ActionResult Delete(Content content)
        {

            if (ModelState.IsValid)
            {
                int categoryId = content.CategoryId;

                contentRepo.Delete(content);

                return RedirectToAction("Details", "Category", new { id = categoryId });
            }
            return View(content);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Content content = contentRepo.GetById(id);
            return View(content);
        }
    }
}
