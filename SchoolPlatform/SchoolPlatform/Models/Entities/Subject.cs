using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class Subject : PropertyChangedNotification
    {
        private int subjectId;
        private string name;
        private bool thesis;

        public int SubjectId
        {
            get
            {
                return subjectId;
            }
            set
            {
                subjectId = value;
                NotifyPropertyChanged("Id");
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

        public bool Thesis
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
