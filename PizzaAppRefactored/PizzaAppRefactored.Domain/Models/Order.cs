using System;
using PizzaAppRefactored.Domain.Enums;

namespace PizzaAppRefactored.Domain.Models
{
	public class Order : BaseEntity
	{
		public PaymentMethodEnum PaymentMethodEnum { get; set; }
		public bool IsDelivered { get; set; }
		public string Location { get; set; }
		public User User { get; set; }

        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}

