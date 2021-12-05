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
    public class ShoppingCartController : Controller
    {
        private readonly ICarRepository _CarRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICarRepository CarRepository, ShoppingCart shoppingCart)
        {
            _CarRepository = CarRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int CarId)
        {
            var selectedCar = _CarRepository.AllCars.FirstOrDefault(p => p.CarId == CarId);

            if (selectedCar != null)
            {
                _shoppingCart.AddToCart(selectedCar, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int CarId)
        {
            var selectedCar = _CarRepository.AllCars.FirstOrDefault(p => p.CarId == CarId);

            if (selectedCar != null)
            {
                _shoppingCart.RemoveFromCart(selectedCar);
            }
            return RedirectToAction("Index");
        }
    }
}
