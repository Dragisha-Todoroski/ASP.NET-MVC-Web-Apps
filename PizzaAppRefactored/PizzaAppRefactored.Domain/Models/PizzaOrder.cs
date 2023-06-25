using System;
using PizzaAppRefactored.Domain.Enums;

namespace PizzaAppRefactored.Domain.Models
{
	public class PizzaOrder : BaseEntity
	{
		public Pizza Pizza { get; set; }
		public int PizzaId { get; set; }
		public Order Order { get; set; }
		public int OrderId { get; set; }
		public PizzaSizeEnum PizzaSize { get; set; }
	}
}

