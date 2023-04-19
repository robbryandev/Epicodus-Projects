using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeApp.Tests
{
    [TestClass]
    public class ScrabbleAppTests
    {
        [TestMethod]
        public void GetScore_GetsScoreFromString_int() {
            string letterStr = "AEIOULNRST\nDG\nBCMP\nFHVWY\nK\nJX\nQZ";
            string[] letters = letterStr.Split("\n");
            Assert.AreEqual(12, ScrabbleApp.Scrabble.GetScore("zoo", letters));
        }
    }
}