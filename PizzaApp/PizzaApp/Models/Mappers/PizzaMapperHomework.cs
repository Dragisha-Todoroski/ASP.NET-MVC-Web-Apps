using System;
using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class PizzaMapperHomework
    {
        public static PizzaViewModelHomework ToPizzaViewModelHomework(Pizza pizza)
        {
            return new PizzaViewModelHomework
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSizeHomework = pizza.PizzaSizeHomework,
                IsOnPromotion = pizza.IsOnPromotion,
                HasExtras = pizza.HasExtras
            };
        }
    }
}
