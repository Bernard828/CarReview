using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Models
{
    public class CarModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public CarModel()
        {

        }

        public CarModel(string name, int id, string description, string image)
        {
            Name = name;
            Id = id;
            Description = description;
            Image = image;
        }
    }
}
