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
    public class HomeController : Controller
    {
        private readonly ICarRepository _CarRepository;

        public HomeController(ICarRepository CarRepository)
        {
            _CarRepository = CarRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                
            };

            return View(homeViewModel);
        }
    }
}
