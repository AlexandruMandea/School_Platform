using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class UserType : PropertyChangedNotification
    {
        private int userTypeId;
        private string name;

        public int UserTypeId
        {
            get
            {
                return userTypeId;
            }
            set
            {
                userTypeId = value;
                NotifyPropertyChanged("UserTypeId");
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
