using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class UserTypeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "")
            {
                return new UserType()
                {
                    Name = values[0].ToString(),
                };
            }
            return null;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            UserType userType = value as UserType;
            object[] result = new object[2] { userType.UserTypeId, userType.Name};//id?
            return result;
        }
    }
}
