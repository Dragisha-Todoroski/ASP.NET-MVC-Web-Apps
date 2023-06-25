using System;
using PizzaAppRefactored.Domain.Enums;

namespace PizzaAppRefactored.Domain.Models
{
	public class Pizza : BaseEntity
	{
		public string Name { get; set; }
		public bool IsOnPromotion { get; set; }
		// public PizzaSizeEnum PizzaSize { get; set; }
		public double Price { get; set; }

		public List<PizzaOrder> PizzaOrders { get; set; }
	}
}

