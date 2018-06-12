using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new Simple_Array();
            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[1], "Milk");

        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new Simple_Array();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
          

        }
    }
}
