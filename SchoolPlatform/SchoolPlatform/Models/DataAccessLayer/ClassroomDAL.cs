using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class ClassroomDAL
    {
        public ObservableCollection<Classroom> GetAllClassrooms()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllClassrooms", con);
                ObservableCollection<Classroom> result = new ObservableCollection<Classroom>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Classroom c = new Classroom();
                    c.ClassroomId = (int)(reader[0]);
                    c.SpecializationId = (int)(reader[1]);
                    c.Year = (int)(reader[2]);
                    c.Name = reader.GetString(3);
                    result.Add(c);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public int GetClassroomIdForStudent(int studentId)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetClassroomIdForStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                cmd.Parameters.Add(paramStudentId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                int classroomId = 0;

                if (reader.Read())
                {
                    classroomId = (int)reader[0];
                }

                reader.Close();
                return classroomId;
            }
            finally
            {
                con.Close();
            }
        }

        public ObservableCollection<Classroom> GetTeachersClassrooms(int teacherId)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                ObservableCollection<Classroom> result = new ObservableCollection<Classroom>();
                SqlCommand cmd = new SqlCommand("GetTeachersClassrooms", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramTeacherId = new SqlParameter("@teacherId", teacherId);
                cmd.Parameters.Add(paramTeacherId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Classroom
                    {
                        ClassroomId = (int)reader[0],//reader.GetInt32(0),
                        SpecializationId = (int)reader[1],
                        Year = (int)reader[2],
                        Name = reader[3].ToString()
                    });
                }

                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddClassroom(Classroom classroom)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter specializationId = new SqlParameter("@specializationId", classroom.SpecializationId);
                SqlParameter year = new SqlParameter("@year", classroom.Year);
                SqlParameter name = new SqlParameter("@name", classroom.Name);

                cmd.Parameters.Add(specializationId);
                cmd.Parameters.Add(year);
                cmd.Parameters.Add(name);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyClassroom(Classroom classroom)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyClassroom", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter classroomId = new SqlParameter("@classroomId", classroom.ClassroomId);
                SqlParameter specializationId = new SqlParameter("@specializationId", classroom.SpecializationId);
                SqlParameter year = new SqlParameter("@year", classroom.Year);
                SqlParameter name = new SqlParameter("@name", classroom.Name);
                cmd.Parameters.Add(classroomId);
                cmd.Parameters.Add(specializationId);
                cmd.Parameters.Add(year);
                cmd.Parameters.Add(name);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteClassroom(Classroom classroom)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteClassroom", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter classroomId = new SqlParameter("@classroomId", classroom.ClassroomId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
