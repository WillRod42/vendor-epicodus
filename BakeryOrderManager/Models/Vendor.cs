using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Models
{
	public class Vendor
	{
		public List<Order> Orders { get; set; }
		public string Description { get; }
		public string Name { get; }

		private static List<Vendor> _vendors = new List<Vendor>();

		public Vendor(string name, string description)
		{
			Orders = new List<Order>();
			Name = name;
			Description = description;
			_vendors.Add(this);
		}

		public Vendor(string name, Order order, string description) : this(name, description)
		{
			Orders.Add(order);
		}

		public static List<Vendor> GetVendors()
		{
			return _vendors;
		}

		public static Vendor FindVendor(string name)
		{
			return _vendors.Find(vendor => vendor.Name == name);
		}

		public static void ClearAll()
		{
			_vendors.Clear();
		}
	}
}
