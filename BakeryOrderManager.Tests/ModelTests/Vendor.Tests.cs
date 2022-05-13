using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderManager.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Tests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void Vendor_CreateNewInstanceOfClass_NewVendor()
		{
			Vendor newVendor = new Vendor();
			Assert.AreEqual(typeof(Vendor),  newVendor.GetType());
		}
	}
}
