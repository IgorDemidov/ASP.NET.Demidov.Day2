using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormatProvider.Task2.Library
{
    public static class CustomConvert
    {
        public static string ToHex(int value)
        {
            return String.Format("0x{0:X}", value);
        }
    }
}
