using System;
using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels
{
	public class PizzaViewModelHomework
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public PizzaSizeHomework PizzaSizeHomework { get; set; }
		public bool IsOnPromotion { get; set; }
		public bool HasExtras { get; set; }
	}
}

