using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class UserTypeBLL
    {
        public ObservableCollection<UserType> UserTypesList { get; set; }
        UserTypeDAL userTypeDAL = new UserTypeDAL();
        public string ErrorMessage { get; set; }

        public ObservableCollection<UserType> GetAllUserTypes()
        {
            return userTypeDAL.GetAllUserTypes();
        }

        public void AddUserType(UserType userType)
        {
            if (userType != null)
            {
                UserTypesList.Add(userType);
                userTypeDAL.AddUserType(userType);
            }
            else
            {
                MessageBox.Show("Fill or correct all the parameters for user type!");
                return;
            }
        }

        public void ModifyUserType(UserType userType)
        {
            if (userType != null)
            {
                userTypeDAL.ModifyUserType(userType);
            }
            else
            {
                MessageBox.Show("Select a user type!");
                return;
            }
        }

        public void DeleteUserType(UserType userType)
        {
            if (userType != null)
            {
                UserTypesList.Remove(userType);
                userTypeDAL.DeleteUserType(userType);
            }
            else
            {
                MessageBox.Show("You must select a user type!");
                return;
            }
        }
    }
}
