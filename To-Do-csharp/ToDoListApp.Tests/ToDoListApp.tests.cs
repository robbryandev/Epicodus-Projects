using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDo.TestCase
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void Add_CheckIfItemGetsAddedToList_Bool() {
            string testString = "Test";
            List.Add(testString);
            Assert.AreEqual(true, List.ToDo.Contains(testString));
        }
    }
}