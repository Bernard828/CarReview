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

        public string CategoryContent { get; set; }

        public Category()
        {

        }

        public Category(string categoryName, int categoryId, string categoryContent)
        {
            CategoryName = categoryName;
            CategoryId = categoryId;
            CategoryContent = categoryContent;
        }
    }
}
