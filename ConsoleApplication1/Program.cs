using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomFormatProvider.Task2.Library;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HexadeсimalFormatter cfp = new HexadeсimalFormatter();

            int customInt = 1561;

            string output = String.Format(cfp, "H", customInt);

            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
