using CarReview.Models;
using CarReview.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Repository
{
    public class CarRepository : IRepository<Content>
    {
        private CarBlogContext db;
        public CarRepository(CarBlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Content> GetAll()
        {
            return db.CarList;
        }

        public Content GetById(int id)
        {
            return db.CarList.Single(c => c.Id == id);
        }

        public int Count()
        {
            return db.CarList.Count();
        }

        public void Create(Content content)
        {
            db.CarList.Add(content);
            db.SaveChanges();
        }
}    }
