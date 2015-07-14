using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Nod.Task3.Library
{
    
    public static class NodCalc
    {
        /// <summary>
        /// Computes the greatest common divisor (GCD) of two numbers
        /// </summary> 
        public static int Evklidean(int first, int second, out TimeSpan timeElapsed)
        {
            int result;
            int remainder;
            int temp;
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            if (first<second)
            {
                temp = first;
                first = second;
                second = temp;
            }

            do
            {                
                Math.DivRem(first,second,out remainder);
                first = second;
                second = remainder;
            } while (remainder != 0);

            stopWatch.Stop();
            timeElapsed = stopWatch.Elapsed;

            result = first;
            return result;
        }

      
    }
}
