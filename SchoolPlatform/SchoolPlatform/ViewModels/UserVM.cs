using SchoolPlatform.Models.BusinessLogicLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace SchoolPlatform.ViewModels
{
    class UserVM : PropertyChangedNotification
    {
        User user;
        UserBLL userBLL = new UserBLL();

        public UserVM()
        {
            UsersList = userBLL.GetAllUsers();
        }

        public UserVM(string username, string password)
        {
            User = userBLL.GetUser(username, password);
        }

        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
                NotifyPropertyChanged("User");
            }
        }

        public ObservableCollection<User> UsersList
        {
            get
            {
                return userBLL.UsersList;
            }
            set
            {
                userBLL.UsersList = value;  
            }
        }
    }
}
