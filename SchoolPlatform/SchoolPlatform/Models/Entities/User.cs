using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class User : PropertyChangedNotification
    {
        private int userId;
        private string name;
        private string username;
        private string password;
        private int userTypeId;

        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                NotifyPropertyChanged("UserId");
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

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

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
    }
}
