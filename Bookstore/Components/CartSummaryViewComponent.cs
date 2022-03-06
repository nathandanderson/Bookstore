﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Components;
using Bookstore.Models;

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent (Basket b)
        {
            basket = b;
        }
   
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    } 
}
