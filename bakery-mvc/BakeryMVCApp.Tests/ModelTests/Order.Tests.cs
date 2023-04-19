using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryMVCApp.Models;

namespace OrderModel.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void PropSet_true() {
            Order propTest = new Order("test", "testing", 9.99, new List<int>{1,2,3});
            Assert.AreEqual(true,
                propTest.Title == "test" &&
                propTest.Description == "testing" &&
                propTest.Price == 9.99 &&
                Enumerable.SequenceEqual(propTest.Date, new List<int>{1,2,3})
            );
        }
    }
}