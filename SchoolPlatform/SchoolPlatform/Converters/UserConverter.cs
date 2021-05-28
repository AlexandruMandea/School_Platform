using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class UserConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "" && values[1].ToString() != "" && values[2].ToString() != "" && values[3].ToString() != "")
            {
                int userTypeId;
                if (!int.TryParse(values[3].ToString(), out userTypeId))
                {
                    return null;
                }
                return new User()
                {
                    Name = values[0].ToString(),
                    Username = values[1].ToString(),
                    Password = values[2].ToString(),
                    UserTypeId = userTypeId
                };
            }
            return null;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            User user = value as User;
            object[] result = new object[5] { user.UserId, user.Name, user.Username, user.Password, user.UserTypeId };//id?
            return result;
        }
    }
}
