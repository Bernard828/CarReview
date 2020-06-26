﻿using System;
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
        public string Category { get; set; }
        public DateTime PublishDate { get; set; }

        public Content()
        {

        }

        public Content(string title, int id, string body, string author, string category, DateTime publishDate)
        {
            Title = title;
            Id = id;
            Body = body;
            Author = author;
            Category = category;
            PublishDate = DateTime.Now;
        }
    }
}