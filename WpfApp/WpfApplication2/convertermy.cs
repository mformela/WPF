using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace konwertery 
{
    public class convertermy : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch(value.ToString().ToLower())
            {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    return false;
            }

                      
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value == true)
                {
                    return "yes";

                }
                else
                {
                    return "no";

                }
            }
                return "unknown";
            
        }
    }
}
