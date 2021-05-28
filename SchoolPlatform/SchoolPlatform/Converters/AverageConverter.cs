using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class AverageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1].ToString() != "" && values[2].ToString() != "")
            {
                int semester;
                int subjectId;
                int studentId;
                if (!int.TryParse(values[0].ToString(), out semester) && !int.TryParse(values[1].ToString(), out subjectId) &&
                    !int.TryParse(values[2].ToString(), out studentId))
                {
                    return null;
                }

                Average average = new Average()
                {
                    Semester = (int)values[0],
                    SubjectId = (int)values[1],
                    StudentId = (int)values[2]
                };

                return average;
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Average a = value as Average;
            object[] result = new object[5] { a.AverageId, a.Value, a.Semester, a.SubjectId, a.StudentId};
            return result;
        }
    }
}
