using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderManager.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Tests
{
	[TestClass]
	public class VendorTests
	{
		[TestMethod]
		public void Vendor_CreateNewInstanceOfClass_NewVendor()
		{
			Vendor newVendor = new Vendor("Test");
			Assert.AreEqual(typeof(Vendor),  newVendor.GetType());
		}

		[TestMethod]
		public void Vendor_CreateNewInstanceOfClassWithOrder_NewVendor()
		{
			Vendor newVendor = new Vendor("Test", new Order());
			Assert.AreEqual(typeof(Vendor),  newVendor.GetType());
		}
	}
}
