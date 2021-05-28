using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class MarkConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1].ToString() != "" && values[2].ToString() != "" && values[3] != null &&
                values[4].ToString() != "" && values[5].ToString() != "")
            {
                int value;
                if (!int.TryParse(values[1].ToString(), out value))
                {
                    return null;
                }

                Mark mark = new Mark()
                {
                    SubjectId = (int)values[0],
                    Value = value,
                    Date = values[2].ToString(),
                    Semester = (int)values[3],
                    StudentId = (int)values[4],
                    SubjectName = values[5].ToString(),
                    IsThesis = (bool)values[6]
                };

                return mark;
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Mark mark = value as Mark;
            object[] result = new object[8] { mark.MarkId, mark.SubjectId, mark.Value, mark.Date, mark.Semester, mark.StudentId, mark.SubjectName, mark.Thesis };
            return result;
        }
    }
}
