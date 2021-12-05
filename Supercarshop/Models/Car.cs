using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supercarshop.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int TopSpeed { get; set; }
        public decimal Acceleration { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public List<Equipment> Equipments { get; set; }
    }
}
