using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supercarshop.Models;
using Supercarshop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Supercarshop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _CarRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CarController(ICarRepository CarRepository, ICategoryRepository categoryRepository)
        {
            _CarRepository = CarRepository;
            _categoryRepository = categoryRepository;
        }    

        public ViewResult List(string category)
        {
            IEnumerable<Car> cars;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cars = _CarRepository.AllCars.OrderBy(p => p.CarId);
                currentCategory = "All Cars";
            }
            else
            {
                cars = _CarRepository.AllCars.Where(p => p.CategoryId.ToString() == category).OrderBy(p => p.CarId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CarListViewModel
            {
                Cars = cars,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var Car = _CarRepository.GetCarById(id);
            if (Car == null)
                return NotFound();

            return View(Car);
        }
    }
}
