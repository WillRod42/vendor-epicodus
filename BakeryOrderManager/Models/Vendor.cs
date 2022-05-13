using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Models
{
	public class Vendor
	{
		public string Description { get; }
		public string Name { get; }

		private List<Order> _orders;
		private static List<Vendor> _vendors = new List<Vendor>();

		public Vendor(string name, string description)
		{
			_orders = new List<Order>();
			Name = name;
			Description = description;
			_vendors.Add(this);
		}

		public Order GetOrder(string id)
		{
			return _orders.Find(order => order.Id == id);
		}

		public List<Order> GetOrders()
		{
			return _orders;
		}

		public void AddOrder(string name, string description, float price)
		{
			_orders.Add(new Order(name, description, price, $"{name}{_orders.Count}"));
		}

		public void RemoveOrder(string name)
		{
			Order order = GetOrder(name);
			_orders.Remove(order);
		}

		public static List<Vendor> GetVendors()
		{
			return _vendors;
		}

		public static Vendor FindVendor(string name)
		{
			return _vendors.Find(vendor => vendor.Name == name);
		}

		public static void RemoveVendor(string name)
		{
			Vendor vendor = FindVendor(name);
			_vendors.Remove(vendor);
		}

		public static void ClearAll()
		{
			_vendors.Clear();
		}
	}
}
