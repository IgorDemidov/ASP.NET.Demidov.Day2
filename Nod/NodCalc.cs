using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nod.Task3.Library
{
    public static class NodCalc
    {
        public static int Evklidean(int first,int second)
        {
            int result;
            int rest;
            int temp;

            if (first<second)
            {
                temp = first;
                first = second;
                second = temp;
            }

            do
            {                
                Math.DivRem(first,second,out rest);
                first = second;
                second = rest;
            } while (rest!=0);

            result = first;

            return result;
        }

      
    }
}
