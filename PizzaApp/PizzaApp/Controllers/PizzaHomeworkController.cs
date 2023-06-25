using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Mappers;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaHomeworkController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;

            List<PizzaViewModelHomework> pizzaViewModelHomeworkList = pizzas.Select(x => PizzaMapperHomework.ToPizzaViewModelHomework(x)).ToList();

            return View(pizzaViewModelHomeworkList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza == null)
            {
                return new EmptyResult();
            }

            PizzaViewModelHomework pizzaViewModelHomework = PizzaMapperHomework.ToPizzaViewModelHomework(pizza);

            return View(pizzaViewModelHomework);
        }
    }
}

