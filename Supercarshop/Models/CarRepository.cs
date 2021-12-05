using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Supercarshop.Models
{
    public class CarRepository: ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> AllCars
        {
            get
            {
                return _appDbContext.Cars.ToList();
            }
        }
       
        public Car GetCarById(int CarId)
        {
            return _appDbContext.Cars.FirstOrDefault(p => p.CarId == CarId);
        }
    }
}
