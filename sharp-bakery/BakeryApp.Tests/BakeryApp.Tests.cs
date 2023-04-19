using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeApp.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetPrice_ShouldReturnPriceForOneItem_string()
    {
      Assert.AreEqual(5, BakeryApp.Bread.GetPrice(1));
    }
    [TestMethod]
    public void GetPrice_ShouldReturnPriceForItemsWithSale_string()
    {
      Assert.AreEqual(20, BakeryApp.Bread.GetPrice(5));
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void GetPrice_ShouldReturnPriceForOneItem_string()
    {
      Assert.AreEqual(2, BakeryApp.Pastry.GetPrice(1));
    }
    [TestMethod]
    public void GetPrice_ShouldReturnPriceForItemsWithSale_string()
    {
      Assert.AreEqual(9, BakeryApp.Pastry.GetPrice(5));
    }
  }
}