using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class UserDAL
    {
        public ObservableCollection<User> GetAllUsers()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllUsers", con);
                ObservableCollection<User> result = new ObservableCollection<User>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User u = new User();
                    u.UserId = (int)(reader[0]);
                    u.Name = reader.GetString(1);
                    u.Username = reader[2].ToString();
                    u.Password = reader[3].ToString();
                    u.UserTypeId = (int)(reader[4]);
                    result.Add(u);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public User GetUser(string username, string password)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassword = new SqlParameter("@password", password);
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                User u = new User();

                if(reader.Read())
                {
                    u.UserId = (int)(reader[0]);
                    u.Name = reader[1].ToString();
                    u.Username = reader[2].ToString();
                    u.Password = reader[3].ToString();
                    u.UserTypeId = (int)(reader[4]);
                }

                reader.Close();

                if(u.Username==username && u.Password==password)
                {
                    return u;
                }

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public ObservableCollection<User> GetStudentsFromClassroom(int classroomId)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetStudentsFromClassroom", con);
                ObservableCollection<User> result = new ObservableCollection<User>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramClassroomId = new SqlParameter("@classroomId", classroomId);
                cmd.Parameters.Add(paramClassroomId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User u = new User();
                    u.UserId = (int)(reader[0]);
                    u.Name = reader.GetString(1);
                    u.Username = reader[2].ToString();
                    u.Password = reader[3].ToString();
                    u.UserTypeId = (int)(reader[4]);
                    result.Add(u);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@name", user.Name);
                SqlParameter paramUsername = new SqlParameter("@username", user.Username);
                SqlParameter paramPassword = new SqlParameter("@password", user.Password);
                SqlParameter paramTypeId = new SqlParameter("@typeId", user.UserTypeId);

                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramTypeId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter userId = new SqlParameter("@userId", user.UserId);
                SqlParameter paramName = new SqlParameter("@name", user.Name);
                SqlParameter paramUserame = new SqlParameter("@username", user.Username);
                SqlParameter paramPassword = new SqlParameter("@password", user.Password);
                cmd.Parameters.Add(userId);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramUserame);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramUserId = new SqlParameter("@userId", user.UserId);
                cmd.Parameters.Add(paramUserId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /*public string GetUserType(User user)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassword = new SqlParameter("@password", password);
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                User u = new User();

                if (reader.Read())
                {
                    u.UserId = (int)(reader[0]);
                    u.Name = reader[1].ToString();
                    u.Username = reader[2].ToString();
                    u.Password = reader[3].ToString();
                    u.UserTypeId = (int)(reader[4]);
                }

                reader.Close();

                if (u.Username == username && u.Password == password)
                {
                    return u;
                }

                return null;
            }
            finally
            {
                con.Close();
            }
            return null;
        }*/
    }
}
