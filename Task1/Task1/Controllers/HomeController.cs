using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task1.Entities;
namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id = 1,
                    Name = "Cola",
                    Category="Cold Drink",
                    Price=2
                },
                new Drink
                {
                    Id = 2,
                    Name = "Fanta",
                    Category="Cold Drink",
                    Price=1
                },
                new Drink
                {
                    Id = 3,
                    Name = "Coffee",
                    Category="Hot Drink",
                    Price=6
                },
            };
            return View(drinks);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id = 1,
                    Name = "Dolma",
                    Category="Milli Metbex",
                    Price=8
                },
                new HotMeal
                {
                    Id = 2,
                    Name = "Xas",
                    Category="Milli Metbex",
                    Price=3
                },
                new HotMeal
                {
                    Id = 3,
                    Name = "Spagetti",
                    Category="Italian Food",
                    Price=18
                },
            };
            return View(hotMeals);
        }

        public IActionResult FastFoods()
        {
            List<Fastfood> fastfoods = new List<Fastfood>
            {
                new Fastfood
                {
                    Id = 1,
                    Name = "Toyuq Corekde",
                    Category="Doner",
                    Price=2
                },
                new Fastfood
                {
                    Id = 2,
                    Name = "Margaritta",
                    Category="Pizza",
                    Price=15
                },
                new Fastfood
                {
                    Id = 3,
                    Name = "Hamburger",
                    Category="Burger",
                    Price=7
                },
            };
            return View(fastfoods);
        }
    }
}
