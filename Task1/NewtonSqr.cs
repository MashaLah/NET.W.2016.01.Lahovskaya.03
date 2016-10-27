using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class NewtonSqr
    {
        /// <summary>
        /// Finds root of a number with Newton's method.
        /// </summary>
        public static double FindSqr(double number, double n, double e)
        {
            double x0 = number / n;
            double x = ((n - 1) * x0 + number / Math.Pow(x0, n - 1))/n;
            while (Math.Abs(x - x0) > e)
            {
                x0 = x;
                x = ((n - 1) * x0 + number / Math.Pow(x0, n - 1))/n;
            }
            return x;
        }
    }
}
