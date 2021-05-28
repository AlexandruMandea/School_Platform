using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.Services;
using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class UserBLL : PropertyChangedNotification
    {
        private ObservableCollection<User> usersList;
        public ObservableCollection<User> UsersList 
        { 
            get 
            { 
                return usersList; 
            } 
            set
            {
                usersList = value;
                NotifyPropertyChanged("UsersList");
            }
        }
        public ObservableCollection<User> StudentsFromSelectedClassroom { get; set; }
        public string ErrorMessage { get; set; }

        UserDAL userDAL = new UserDAL();

        public User GetUser(string username, string password)
        {
            return userDAL.GetUser(username, password);
        }

        public ObservableCollection<User> GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        public ObservableCollection<User> GetStudentsFromClassroom(int classroomId)
        {
            return userDAL.GetStudentsFromClassroom(classroomId);
        }

        public void AddUser(User user)
        {
            if(user != null)
            {
                UsersList.Add(user);
                userDAL.AddUser(user);
            }
            else
            {
                MessageBox.Show("Fill or correct all the parameters for user!");
                return;
            }
        }

        public void RefreshUsersList()
        {
            UsersList = userDAL.GetAllUsers();
        }

        public void ModifyUser(User user)
        {
            if (user != null)
            {
                userDAL.ModifyUser(user);
            }
            else
            {
                MessageBox.Show("Fill or correct all the parameters for user!");
                return;
            }
        }

        public void DeleteUser(User user)
        {
            if(user!=null)
            {
                UsersList.Remove(user);
                userDAL.DeleteUser(user);
            }
            else
            {
                MessageBox.Show("You must select a user!");
                return;
            }
        }
    }
}
