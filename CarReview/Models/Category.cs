using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Models
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Content> Contents { get; set; }

        public Category()
        {

        }

        public Category(string categoryName, int categoryId, string image)
        {
            CategoryName = categoryName;
            CategoryId = categoryId;
            Image = image;
        }
    }
}
