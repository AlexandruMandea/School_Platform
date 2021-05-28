using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class ClassroomConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "" && values[1].ToString() != "" && values[2].ToString() != "")
            {
                int specializationId;
                int year;
                if (!int.TryParse(values[0].ToString(), out specializationId) || !int.TryParse(values[1].ToString(), out year))
                {
                    return null;
                }
                return new Classroom()
                {
                    SpecializationId = specializationId,
                    Year = year,
                    Name = values[2].ToString(),
                };
            }
            return null;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Classroom c = value as Classroom;
            object[] result = new object[4] { c.ClassroomId, c.SpecializationId, c.Year, c.Name};//id?
            return result;
        }
    }
}
