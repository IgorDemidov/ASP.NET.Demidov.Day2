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
        /// Computes the greatest common divisor (GCD) of two numbers by Euclidean Algorithm
        /// </summary> 
        public static int Euclidean(ref TimeSpan timeElapsed, int first, int second)
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
            
            result = first;

            stopWatch.Stop();
            timeElapsed += stopWatch.Elapsed;

            return result;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of numbers set by Euclidean Algorithm
        /// </summary> 
        public static int Euclidean(ref TimeSpan timeElapsed, params int[] args)
        {
            
            if (args.Length<2)
            {
                throw new ArgumentNullException("args", "Unacceptable number of arguments");
            }

            int result = args[0];

            for (int i = 0; i < args.Length-1; i++)
            {
                result = Euclidean(ref timeElapsed, result, args[i + 1]);
            }
   
            return result;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of two numbers by Binary Euclidean Algorithm
        /// </summary> 
        public static int EuclideanBinary(ref TimeSpan timeElapsed, int first, int second)
        {
            int result;
            int temp;

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            int shift;
            if (first == 0) return second;
            if (second == 0) return first;

            for (shift = 0; ((first | second) & 1) == 0; ++shift) 
            {
                first >>= 1;
                second >>= 1;
            }
            while ((first & 1) == 0)
                first >>= 1;
 
            do 
            {
                while ((second & 1) == 0)
                    second >>= 1;

                if (first > second)
                {
                    temp = second;
                    second = first; 
                    first = temp;
                }
                second = second - first;
            } while (second != 0);

            result = first << shift;

            stopWatch.Stop();
            timeElapsed += stopWatch.Elapsed;

            return result;
        }

        /// <summary>
        /// Computes the greatest common divisor (GCD) of numbers set by Binary Euclidean Algorithm
        /// </summary> 
        public static int EuclideanBinary(ref TimeSpan timeElapsed, params int[] args)
        {

            if (args.Length < 2)
            {
                throw new ArgumentNullException("args", "Unacceptable number of arguments");
            }

            int result = args[0];

            for (int i = 0; i < args.Length - 1; i++)
            {
                result = EuclideanBinary(ref timeElapsed, result, args[i + 1]);
            }

            return result;
        }
      
    }
}
