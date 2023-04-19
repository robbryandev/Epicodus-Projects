using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeApp.Tests
{
    [TestClass]
    public class NumberTests 
    {
        [TestMethod]
        public void Check_isPrime_true() {
            int testInt = 37;
            Assert.AreEqual(true, Number.isPrime(testInt));
        }
    }
}