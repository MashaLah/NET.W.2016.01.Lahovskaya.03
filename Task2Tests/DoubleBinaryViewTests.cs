using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Tests
{
    public class DoubleBinaryViewTests
    {
        /// <summary>
        /// A test for ShowBinaryView().
        /// </summary>
        [TestCase(123.123, ExpectedResult = "0100000001011110110001111101111100111011011001000101101000011101")]
        [TestCase(-123.123, ExpectedResult = "1100000001011110110001111101111100111011011001000101101000011101")]
        [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
        public string ShowBinaryView_ValidData_ValidResult(double number) => number.ShowBinaryView();
    }
}
