using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class DoubleBinaryView
    {
        /// <summary>
        /// Extension method for Double, represents binary view.
        /// </summary>
        public static string ShowBinaryView(this double number)
        {
            byte[] byteArray = BitConverter.GetBytes(number);
            BitArray bitArray = new BitArray(byteArray);
            char[] resultArray = new char[sizeof(double)*8];
            for (int i = 0; i <resultArray.Length; i++)
            {
                resultArray[i] = bitArray[i] ? '1' : '0';
            }
            Array.Reverse(resultArray);
            return new String(resultArray);
        }
    }
}
