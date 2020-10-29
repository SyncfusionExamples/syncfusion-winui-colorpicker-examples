using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSolidColors
{
    public class StringToEnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch (value)
            {
                case "RGB":
                    return ColorChannelOptions.RGB;
                case "RGB & CMYK":
                    return ColorChannelOptions.RGB | ColorChannelOptions.CMYK;
                case "HSV & HSL":
                    return ColorChannelOptions.HSV | ColorChannelOptions.HSL;
                case "All":
                    return ColorChannelOptions.All;
                default:
                    return ColorChannelOptions.All;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
