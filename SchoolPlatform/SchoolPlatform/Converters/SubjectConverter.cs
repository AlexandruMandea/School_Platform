using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class SubjectConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "" && values[1] != null)
            {
                return new Subject()
                {
                    Name = values[0].ToString(),
                    Thesis = (bool)values[1]
                };
            }
            return null;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Subject subject = value as Subject;
            object[] result = new object[3] { subject.SubjectId, subject.Name, subject.Thesis };//id?
            return result;
        }
    }
}
