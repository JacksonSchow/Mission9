using System;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

//Setting up the data for the cart view component

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent (Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
