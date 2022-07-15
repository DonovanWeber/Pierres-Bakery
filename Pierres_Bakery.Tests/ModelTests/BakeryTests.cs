using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    } 
    [TestMethod]
    public void CalculatePriceOfBread_GetsPriceOfBread_Int()
    {
      Bread newOrder = new Bread(1);
      int costOfOneBread = 5;
      Assert.AreEqual(costOfOneBread, newOrder.CalculatePriceOfBread());
    }
    [TestMethod]
    public void CalculatePriceOfBread_GetPriceOfTwoOrders_Int()
    {
      Bread newOrder = new Bread(2);
      int costOfTwoBread = 10;
      Assert.AreEqual(costOfTwoBread, newOrder.CalculatePriceOfBread());
    }
    [TestMethod]
    public void CalculatePriceOfBread_GetPriceOfThreeWithDiscount_Int()
    {
      Bread newOrder = new Bread(3);
      int costOfThreeBread = 10;
      Assert.AreEqual(costOfThreeBread, 4);
    }
  }
}