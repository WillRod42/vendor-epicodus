using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Models
{
	public class Order
	{
		public string Name { get; }
		public string Description { get; }
		public float Price { get; }
		public DateTime Date { get; }

		public Order(string name, string description, float price)
		{
			Name = name;
			Description = description;
			Price = price;
			Date = DateTime.Now;
		}
	}
}
