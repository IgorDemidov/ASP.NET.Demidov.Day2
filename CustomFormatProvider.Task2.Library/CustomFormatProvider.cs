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
                return this;
            else
                return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (!this.Equals(formatProvider))
                return null;

            if (string.IsNullOrEmpty(format))
                format = "H";

            string numericString = arg.ToString();

            if (format == "H")
            {
                if (arg is int)
                    return numericString;
                else
                    throw new FormatException(
                              string.Format("'{0}' cannot be used to format {1}.",
                                            format, arg.ToString()));
            }
            else 
            {
                throw new FormatException(string.Format("The {0} format specifier is invalid.", format));
            }
            
            return numericString;
        }



    }
}
