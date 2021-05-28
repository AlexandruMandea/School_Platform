using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class Mark : PropertyChangedNotification
    {
        private int markId;
        private int subjectId;
        private string subjectName;
        private int value;
        private string date;
        private int semester;
        private int studentId;
        private string studentName;
        private bool? isThesis;
        private string thesis;

        public int MarkId
        {
            get
            {
                return markId;
            }
            set
            {
                markId = value;
                NotifyPropertyChanged("MarkId");
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

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
                NotifyPropertyChanged("Value");
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                NotifyPropertyChanged("Date");
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

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
                NotifyPropertyChanged("StudentName");
            }
        }

        public bool? IsThesis
        {
            get
            {
                return isThesis;
            }
            set
            {
                isThesis = value;
                NotifyPropertyChanged("IsThesis");
            }
        }

        public string Thesis
        {
            get
            {
                return thesis;
            }
            set
            {
                thesis = value;
                NotifyPropertyChanged("Thesis");
            }
        }
    }
}
