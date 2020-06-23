using CarReview.Models;
using CarReview.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Controllers
{
    public class CarController : Controller
    {
        IRepository<CarModel> carRepo;

        public CarController(IRepository<CarModel> carRepo)
        {
            this.carRepo = carRepo;
        }

        public ViewResult Index()
        {
            //CarRepository carRepo = new CarRepository();
            var model = carRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = carRepo.GetById(id);
            return View(model);
        }
    }
}
