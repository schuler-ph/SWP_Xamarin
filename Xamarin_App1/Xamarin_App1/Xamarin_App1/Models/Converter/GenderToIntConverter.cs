using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_App1.Models.Converter
{
    public class GenderToIntConverter : IValueConverter
    {

        // Convert konvertiert den Wert in der Klasse in den Wert der Komponente (PersonViewModel.Gender -> int (PersonDataView))
        // ConvertBack konvertiert den Wert in der Komponente in den Wert in der Klasse (int (PersonDataView) -> PersonViewModel.Gender)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Value beinhaltet den vorhandenen Wert im Feld Gender
            return System.Convert.ToInt32(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Value beinhaltet den Wert in der Komponente
            return (Gender)System.Convert.ToInt32(value);
        }
    }
}
