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
            return db.Contents;
        }

        public Content GetById(int id)
        {
            return db.Contents.Single(c => c.Id == id);
        }

        public int Count()
        {
            return db.Contents.Count();
        }

        public void Create(Content content)
        {
            db.Contents.Add(content);
            db.SaveChanges();
        }

        public void Delete(Content content)
        {
            db.Contents.Remove(content);
            db.SaveChanges();
        }

        public void Update(Content content)
        {
            db.Contents.Update(content);
            db.SaveChanges();
        }
    }    }
