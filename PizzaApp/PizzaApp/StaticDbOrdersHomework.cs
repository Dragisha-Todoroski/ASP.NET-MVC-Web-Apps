using PizzaApp.Models.Domain;

namespace PizzaApp
{
    public static class StaticDbOrdersHomework
    {
        public static List<OrderHomework> Orders { get; set; } = new List<OrderHomework>()
        {
            new OrderHomework(1, "Tasty Order"),
            new OrderHomework(2, "Spicy Order"),
            new OrderHomework(3, "Delicious Order")
        };
    }
}
