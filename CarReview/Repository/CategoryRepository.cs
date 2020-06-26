using CarReview.Models;
using CarReview.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private CarBlogContext db;
        public CategoryRepository(CarBlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Category;
        }

        public Category GetById(int id)
        {
            return db.Category.Single(c => c.CategoryId == id);
        }

        public int Count()
        {
            return db.Category.Count();
        }
}   }
