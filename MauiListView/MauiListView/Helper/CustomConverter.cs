using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiListView
{
    public class CustomConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object eventArgs = null;
            Syncfusion.Maui.ListView.ItemTappedEventArgs eventArg = null;
            if (value is Syncfusion.Maui.ListView.ItemTappedEventArgs)
            {
                eventArg = value as Syncfusion.Maui.ListView.ItemTappedEventArgs;
                eventArgs = eventArg.DataItem;
            }
           
            return eventArgs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
