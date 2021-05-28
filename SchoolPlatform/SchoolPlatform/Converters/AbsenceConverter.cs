using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class AbsenceConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if(values[0]!=null && values[1].ToString()!="" && values[2].ToString() != "" && values[3] != null && values[4] != null && values[5].ToString() != "")
            {
                int subjectId;
                int semester;
                int studentId;
                if (!int.TryParse(values[0].ToString(), out subjectId) || !int.TryParse(values[2].ToString(), out semester) || !int.TryParse(values[4].ToString(), out studentId))
                {
                    return null;
                }

                Absence absence = new Absence()
                {
                    SubjectId = subjectId,
                    Date = values[1].ToString(),
                    Semester = semester,
                    CanBeExcused = (bool)values[3],
                    StudentId = studentId,
                    SubjectName = values[5].ToString()
                };

                return absence;
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Absence absence = value as Absence;
            object[] result = new object[8] { absence.AbsenceId, absence.SubjectId, absence.Date, absence.Semester, absence.CanBeExcused, absence.Excused, absence.StudentId, absence.SubjectName };
            return result;
        }
    }
}
