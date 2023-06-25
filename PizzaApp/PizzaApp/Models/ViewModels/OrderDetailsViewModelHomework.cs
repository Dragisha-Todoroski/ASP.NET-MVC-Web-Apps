using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels
{
    public class OrderDetailsViewModelHomework
    {
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public decimal Price { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string UserAddress { get; set; }
    }
}
