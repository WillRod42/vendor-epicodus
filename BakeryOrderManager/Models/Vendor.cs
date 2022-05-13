using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Models
{
	public class Vendor
	{
		public List<Order> orders { get; set; }
		public string Description { get; }
		public string Name { get; }

		public Vendor(string name, string description)
		{
			orders = new List<Order>();
			Name = name;
			Description = description;
		}

		public Vendor(string name, Order order, string description) : this(name, description)
		{
			orders.Add(order);
		}
	}
}
