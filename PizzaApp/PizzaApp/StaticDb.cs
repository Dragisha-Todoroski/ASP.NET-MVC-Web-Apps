using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;

namespace PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas { get; set; } = new List<Pizza>
        {
            new Pizza(1, "Capricciosa", 300, true),
            new Pizza(2, "Pepperoni", 350, false)
        };

        public static List<User> Users { get; set; } = new List<User>
        {
            new User(1, "Tijana", "Stojanovska", "070123456"),
            new User(2, "Aleksandar", "Ivanovski", "070456789")
        };

        public static List<Order> Orders { get; set; } = new List<Order>
        {
            new Order(1, 1, Pizzas.FirstOrDefault(), 1, Users.FirstOrDefault(), PaymentMethodEnum.Cash),
            new Order(2, 2, Pizzas.FirstOrDefault(x => x.Id == 2), 1, Users.FirstOrDefault(x => x.Id == 2), PaymentMethodEnum.Card)
        };
    }
}
