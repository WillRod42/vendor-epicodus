using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderManager.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Tests
{
	[TestClass]
	public class OrderTests
	{
		[TestMethod]
		public void Order_CreateNewInstanceOfClass_NewOrder()
		{
			Order newOrder = new Order();
			Assert.AreEqual(typeof(Order),  newOrder.GetType());
		}
	}
}
