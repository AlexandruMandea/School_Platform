using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class Classroom : PropertyChangedNotification
    {
        private int classroomId;
        private int specializationId;
        private int year;
        private string name;

        private ObservableCollection<User> teachers;
        private ObservableCollection<Subject> subjects;
        private ObservableCollection<User> students;

        public int ClassroomId
        {
            get
            {
                return classroomId;
            }
            set
            {
                classroomId = value;
                NotifyPropertyChanged("ClassroomId");
            }
        }

        public int SpecializationId
        {
            get
            {
                return specializationId;
            }
            set
            {
                specializationId = value;
                NotifyPropertyChanged("SpecializationId");
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
                NotifyPropertyChanged("YearId");
            }
        }

        public ObservableCollection<User> Teachers
        {
            get
            {
                return teachers;
            }
            set
            {
                teachers = value;
                NotifyPropertyChanged("Teachers");
            }
        }

        public ObservableCollection<Subject> Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
                NotifyPropertyChanged("Subjects");
            }
        }

        public ObservableCollection<User> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
                NotifyPropertyChanged("Students");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
    }
}
