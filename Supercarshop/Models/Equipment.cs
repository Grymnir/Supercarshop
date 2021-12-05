using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supercarshop.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public int CarId { get; set; }
    }
}
