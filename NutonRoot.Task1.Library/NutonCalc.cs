using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutonRoot.Task1.Library
{
    public static class NutonCalc
    {
        /// <summary>
        ///  This method calculates the value of the n-th root of the  argument arg to within e by Newton method.
        /// </summary>
        public static double RootOf(double arg, int n, double accuracy)
        {
            try
            {
                double x = arg;
                double next = x;
                do
                {
                    x = next;
                    next = (((n - 1) * x) + (arg / Math.Pow(x, (n - 1)))) / n;
                } while (Math.Abs(x - next) > accuracy);

                return x;
            }
            catch (Exception ex)
            {
                if ((arg < 0) && (n % 2 != 0))
                {
                    throw new ArgumentOutOfRangeException("arg", "The calculation result is not a real value. (Complex value)");
                }

                if (n == 0)
                {
                    throw new ArgumentOutOfRangeException("n", "The calculation of the infinite power of argument");
                }

                throw ex;
            } 
       
        }
    }
}
