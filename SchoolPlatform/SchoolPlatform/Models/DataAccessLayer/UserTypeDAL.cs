using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class UserTypeDAL
    {
        public ObservableCollection<UserType> GetAllUserTypes()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllUserTypes", con);
                ObservableCollection<UserType> result = new ObservableCollection<UserType>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserType ut = new UserType();
                    ut.UserTypeId = (int)(reader[0]);
                    ut.Name = reader.GetString(1);
                    result.Add(ut);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddUserType(UserType userType)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddUserType", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@name", userType.Name);

                cmd.Parameters.Add(paramName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyUserType(UserType userType)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyUserType", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter userTypeId = new SqlParameter("@userTypeId", userType.UserTypeId);
                SqlParameter paramName = new SqlParameter("@name", userType.Name);
                cmd.Parameters.Add(userTypeId);
                cmd.Parameters.Add(paramName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUserType(UserType userType)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteUserType", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter userTypeId = new SqlParameter("@userTypeId", userType.UserTypeId);
                cmd.Parameters.Add(userTypeId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
