﻿using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
