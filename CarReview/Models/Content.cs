using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Models
{
    public class Content
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        //public string Category { get; set; }
        public DateTime PublishDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Content()
        {

        }

        public Content(string title, int id, string body, string author, int categoryId)
        {
            Title = title;
            Id = id;
            Body = body;
            Author = author;
            CategoryId = categoryId;
            PublishDate = DateTime.Now;
        }
    }
}
