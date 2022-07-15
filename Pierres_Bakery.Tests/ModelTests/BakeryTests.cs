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
      int costOfThreeBreadWithDiscount = 10;
      Assert.AreEqual(costOfThreeBreadWithDiscount, newOrder.CalculatePriceOfBread());
    }
    [TestMethod]
    public void CalculatePriceOfBread_GetPriceOfFourWithDiscount_Int()
    {
      Bread newOrder = new Bread (4);
      int costOfFourBreadWithDiscount = 15;
      Assert.AreEqual(costOfFourBreadWithDiscount, newOrder.CalculatePriceOfBread());
    }
    [TestMethod]
    public void CalculatePriceOfBread_GetPriceOfFiveWithDiscount_Int()
    {
      Bread newOrder = new Bread (5);
      int costOfFourBreadWithDiscount = 20;
      Assert.AreEqual(costOfFourBreadWithDiscount, newOrder.CalculatePriceOfBread());
    }
    [TestMethod]
    public void PastyConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
    [TestMethod]
    public void CalculatePriceOfPastry_GetsPriceOfPastry_Int()
    {
      Pastry newOrder = new Pastry(1);
      int costOfOnePastry= 2;
      Assert.AreEqual(costOfOnePastry, newOrder.CalculatePriceOfPastry());
    }
    [TestMethod]
    public void CalculatePriceOfPastry_GetsPriceOfPastryWithDiscount_Int()
    {
      Pastry newOrder = new Pastry(3);
      int costOfOnePastry= 5;
      Assert.AreEqual(costOfOnePastry, newOrder.CalculatePriceOfPastry());
    }
    [TestMethod]
    public void CalculatePriceOfPastry_GetsPriceOfPastryWithDiscountAndExtraPastry_Int()
    {
      Pastry newOrder = new Pastry(4);
      int costOfOnePastry= 7;
      Assert.AreEqual(costOfOnePastry, newOrder.CalculatePriceOfPastry());
    }
  }
}