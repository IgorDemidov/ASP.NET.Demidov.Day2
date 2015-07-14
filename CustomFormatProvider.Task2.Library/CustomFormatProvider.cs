using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormatProvider.Task2.Library
{

    public class HexadeсimalFormatter : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            
            throw new NotImplementedException();
        }

        
    }
}
