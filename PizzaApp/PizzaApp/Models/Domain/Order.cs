using PizzaApp.Models.Enums;

namespace PizzaApp.Models.Domain
{
    public class Order
    {
        public Order(int id, int pizzaId, Pizza pizza, int userId, User user, PaymentMethodEnum paymentMethod)
        {
            Id = id;
            PizzaId = pizzaId;
            Pizza = pizza;
            UserId = userId;
            User = user;
            PaymentMethod = paymentMethod;
        }

        public int Id { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; } // we use it to create joins
        public int UserId { get; set; }
        public User User { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
    }
}
