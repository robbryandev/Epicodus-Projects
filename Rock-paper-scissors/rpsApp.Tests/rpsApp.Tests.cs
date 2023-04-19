using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rpsApp.TestCase
{
    [TestClass]
    public class rpsLogicTests
    {
        [TestMethod]
        public void check_rpsWinCon_rock()
        {
            Assert.AreEqual("rock", rpsLogic.rpsWinCon("rock", "scissors"));
        }
        [TestMethod]
        public void check_rpsWinCon_paper()
        {
            Assert.AreEqual("paper", rpsLogic.rpsWinCon("rock", "paper"));
        }
    }
}