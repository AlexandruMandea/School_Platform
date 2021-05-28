using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class SpecializationConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "")
            {
                return new Specialization()
                {
                    Name = values[0].ToString(),
                };
            }
            return null;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Specialization specialization = value as Specialization;
            object[] result = new object[2] { specialization.SpecializationId, specialization.Name };//id?
            return result;
        }
    }
}
