using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supercarshop.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get; }
        
        Car GetCarById(int CarId);
    }
}
