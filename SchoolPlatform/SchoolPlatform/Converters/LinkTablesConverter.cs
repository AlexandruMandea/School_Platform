using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace SchoolPlatform.Converters
{
    class LinkTablesConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0].ToString() != "" && values[1].ToString() != "")
            {
                int id1;
                int id2;
                if (!int.TryParse(values[0].ToString(), out id1) || !int.TryParse(values[1].ToString(), out id2))
                {
                    return null;
                }
                return new LinkingTable()
                {
                    ID1 = id1,
                    ID2 = id2,
                };
            }
            return null;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            LinkingTable lt = value as LinkingTable;
            object[] result = new object[2] { lt.ID1, lt.ID2};
            return result;
        }
    }
}
