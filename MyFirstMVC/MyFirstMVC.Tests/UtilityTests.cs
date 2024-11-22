using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstMVC.Tests
{

    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expectedResult = 15;

            // Act
            int result = Utility.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
