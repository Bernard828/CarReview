using CarReview.Models;
using CarReview.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Repository
{
    public class CarRepository : IRepository<CarModel>
    {
        private CarContext db;
        public CarRepository(CarContext db)
        {
            this.db = db;
        }

        public IEnumerable<CarModel> GetAll()
        {
            return db.CarList;
        }

        public CarModel GetById(int id)
        {
            return db.CarList.Single(c => c.Id == id);
        }

        public int Count()
        {
            return db.CarList.Count();
        }

        public void Create(CarModel carModel)
        {
            db.CarList.Add(carModel);
            db.SaveChanges();
        }
}    }
