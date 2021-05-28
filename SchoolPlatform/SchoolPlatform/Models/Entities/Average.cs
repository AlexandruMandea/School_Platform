using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class Average : PropertyChangedNotification
    {
        private int averageId;
        private double value;
        private int semester;
        private int subjectId;
        private int studentId;
        private string subjectName;

        public int AverageId
        {
            get
            {
                return averageId;
            }
            set
            {
                averageId = value;
                NotifyPropertyChanged("AverageId");
            }
        }

        public double Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                NotifyPropertyChanged("Value");
            }
        }

        public int Semester
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
                NotifyPropertyChanged("Semester");
            }
        }

        public int SubjectId
        {
            get
            {
                return subjectId;
            }
            set
            {
                subjectId = value;
                NotifyPropertyChanged("SubjectId");
            }
        }

        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
                NotifyPropertyChanged("StudentId");
            }
        }

        public string SubjectName
        {
            get
            {
                return subjectName;
            }
            set
            {
                subjectName = value;
                NotifyPropertyChanged("SubjectName");
            }
        }
    }
}
