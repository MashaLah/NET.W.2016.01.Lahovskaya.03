using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1.Tests
{
    [TestClass]
    public class NewtonSqrTests
    {
        /// <summary>
        /// A test for FindSqr() with valid parameters.
        /// </summary>
        [TestMethod]
        public void FindSqr_Number16Degree4_Returned2()
        {
            //arrange
            double number = 16;
            double n = 4;
            double e = 0;
            double expected = 2;
            //act
            double actual = NewtonSqr.FindSqr(number, n, e);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for FindSqr() with valid parameters<0.
        /// </summary>
        [TestMethod]
        public void FindSqr_NumberMinus125Degree3_ReturnedMinus5()
        {
            //arrange
            double number = -125;
            double n = 3;
            double e = 0;
            double expected = -5;
            //act
            double actual = NewtonSqr.FindSqr(number, n, e);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
