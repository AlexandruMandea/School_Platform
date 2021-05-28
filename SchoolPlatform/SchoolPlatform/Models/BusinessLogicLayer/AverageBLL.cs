using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class AverageBLL
    {
        AverageDAL averageDAL = new AverageDAL();
        public ObservableCollection<Average> AveragesForStudent { get; set; }

        public ObservableCollection<Average> GetAveragesForStudent(int studentId)
        {
            return averageDAL.GetAveragesForStudent(studentId);
        }

        public void MakeAverage(Average average)
        {
            averageDAL.MakeAverage(average);
        }
    }
}
