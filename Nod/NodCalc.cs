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
        public static int Evklidean(ref TimeSpan timeElapsed, int first, int second)
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
            timeElapsed += stopWatch.Elapsed;

            result = first;
            return result;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of numbers set
        /// </summary> 
        public static int Evklidean(ref TimeSpan timeElapsed, params int[] args)
        {
            
            if (args.Length<2)
            {
                throw new ArgumentNullException("args", "Unacceptable number of arguments");
            }

            int result = args[0];

            for (int i = 0; i < args.Length-1; i++)
            {
                result = Evklidean(ref timeElapsed, result, args[i + 1]);
            }
   
            return result;
        }
      
    }
}
