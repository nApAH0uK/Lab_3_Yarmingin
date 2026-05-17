using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Lab3_Yarmingin.Models;

namespace Lab3_Yarmingin.Controllers
{
    public class VegetablesController : Controller
    {
        private List<Vegetable> GetVegetables()
        {
            return new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" },
            };
        }

        public IActionResult FirstViewMethod()
        {
            var veggies = GetVegetables();
            return View(veggies);
        }

        public IActionResult SecondViewMethod()
        {
            var veggies = GetVegetables();
            var sorted = veggies.OrderBy(v => v.Name).ToList();
            return View(sorted);
        }

        public IActionResult ThirdViewMethod()
        {
            var veggies = GetVegetables();
            var grouped = veggies.GroupBy(v => v.Name[0]).OrderBy(g => g.Key);
            return View(grouped);
        }
    }
}