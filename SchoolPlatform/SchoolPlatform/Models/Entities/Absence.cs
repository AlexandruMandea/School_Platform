using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class Absence : PropertyChangedNotification
    {
        private int absenceId;
        private int? subjectId;
        private string subjectName;
        private string date;
        private int? semester;
        private int? studentId;
        private string studentName;
        private bool? canBeExcused;
        private bool excused;

        public int AbsenceId
        {
            get
            {
                return absenceId;
            }
            set
            {
                absenceId = value;
                NotifyPropertyChanged("AbsenceId");
            }
        }

        public int? SubjectId
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

        public int? Semester
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

        public int? StudentId
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

        public bool? CanBeExcused
        {
            get
            {
                return canBeExcused;
            }
            set
            {
                canBeExcused = value;
                NotifyPropertyChanged("CanBeExcused");
            }
        }

        public bool Excused
        {
            get
            {
                return excused;
            }
            set
            {
                excused = value;
                NotifyPropertyChanged("Excused");
            }
        }
    }
}
