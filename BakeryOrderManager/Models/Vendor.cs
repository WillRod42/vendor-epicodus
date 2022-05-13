using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Models
{
	public class Vendor
	{
		public List<Order> Orders { get; set; }
		public string Description { get; }
		public string Name { get; }

		public Vendor(string name, string description)
		{
			Orders = new List<Order>();
			Name = name;
			Description = description;
		}

		public Vendor(string name, Order order, string description) : this(name, description)
		{
			Orders.Add(order);
		}
	}
}
