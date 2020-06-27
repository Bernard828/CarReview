using CarReview.Models;
using CarReview.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

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
            if (ModelState.IsValid)            {
                contentRepo.Create(content);
                return RedirectToAction("Index");
            }
            return View(content);
        }
    }
}
