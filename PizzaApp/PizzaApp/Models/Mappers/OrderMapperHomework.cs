using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class OrderMapperHomework
    {
        public static OrderDetailsViewModelHomework ToOrderDetailsViewModelHomework(Order order)
        {
            return new OrderDetailsViewModelHomework
            {
                PaymentMethod = order.PaymentMethod,
                PizzaName = order.Pizza.Name,
                Price = order.Pizza.Price + 50,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                UserAddress = order.User.Address
            };
        }
    }
}
