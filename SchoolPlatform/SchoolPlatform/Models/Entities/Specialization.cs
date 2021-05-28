using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class Specialization : PropertyChangedNotification
    {
        private int specializationId;
        private string name;

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
