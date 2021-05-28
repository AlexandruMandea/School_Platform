using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class SubjectDAL
    {
        public ObservableCollection<Subject> GetAllSubjects()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllSubjects", con);
                ObservableCollection<Subject> result = new ObservableCollection<Subject>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Subject s = new Subject();
                    s.SubjectId = (int)(reader[0]);
                    s.Name = reader.GetString(1);
                    s.Thesis = (bool)reader[2];
                    result.Add(s);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public ObservableCollection<Subject> GetSubjectsFromClassroom(int classroomId)
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                ObservableCollection<Subject> result = new ObservableCollection<Subject>();
                SqlCommand cmd = new SqlCommand("GetSubjectsFromClassroom", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramClassroomId = new SqlParameter("@classroomId", classroomId);
                cmd.Parameters.Add(paramClassroomId);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Subject()
                    {
                        SubjectId = (int)reader[0],
                        Name = reader[1].ToString(),
                        Thesis = (bool)reader[2]
                    });
                }
                return result;
            }
        }

        public ObservableCollection<Subject> GetSubjectsForTeacherForSelectedClassroom(int teacherId, int classroomId)
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                ObservableCollection<Subject> result = new ObservableCollection<Subject>();
                SqlCommand cmd = new SqlCommand("GetSubjectsForTeacherForSelectedClassroom", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramTeacherId = new SqlParameter("@teacherId", teacherId);
                SqlParameter paramClassroomId = new SqlParameter("@classroomId", classroomId);
                cmd.Parameters.Add(paramTeacherId);
                cmd.Parameters.Add(paramClassroomId);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Subject()
                    {
                        SubjectId = (int)reader[0],
                        Name = reader[1].ToString(),
                        Thesis = (bool)reader[2]
                    });
                }
                return result;
            }
        }

        public void AddSubject(Subject subject)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@name", subject.Name);
                SqlParameter paramThesis = new SqlParameter("@thesis", subject.Thesis);

                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramThesis);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifySubject(Subject subject)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifySubject", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter subjectId = new SqlParameter("@subjectId", subject.SubjectId);
                SqlParameter paramName = new SqlParameter("@name", subject.Name);
                SqlParameter thesis = new SqlParameter("@thesis", subject.Thesis);
                cmd.Parameters.Add(subjectId);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(thesis);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(Subject subject)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteSubject", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter subjectId = new SqlParameter("@subjectId", subject.SubjectId);
                cmd.Parameters.Add(subjectId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
