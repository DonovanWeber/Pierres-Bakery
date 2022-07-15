using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres_Bakery;

namespace Pierres_Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newOrder = new Bread(1, 5);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    } 
  }
}