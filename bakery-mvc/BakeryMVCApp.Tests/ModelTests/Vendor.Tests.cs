using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryMVCApp.Models;

namespace VendorModel.Tests
{
    [TestClass]
    public class VendorTests: IDisposable
    {
        public void Dispose() {
            Vendor.ClearAll();
        }
        [TestMethod]
        public void IdSet_true() {
            Vendor idTestOne = new Vendor("test", "testing");
            Vendor idTestTwo = new Vendor("test", "testing");
            Assert.AreEqual(true, idTestOne.id == 0 && idTestTwo.id == 1);
        }
        [TestMethod]
        public void PropSet_true() {
            Vendor propTest = new Vendor("test", "testing");
            Assert.AreEqual(true,
                propTest.Name == "test" &&
                propTest.Description == "testing" &&
                propTest.id == 0
            );
        }
    }
}