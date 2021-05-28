using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class MarkDAL
    {
        public ObservableCollection<Mark> GetAllMarks()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllMarks", con);
                ObservableCollection<Mark> result = new ObservableCollection<Mark>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mark mark = new Mark();

                    mark.MarkId = (int)reader[0];
                    mark.SubjectId = (int)reader[1];
                    mark.Value = (int)reader[2];
                    mark.Date = reader[3].ToString();
                    mark.Semester = (int)reader[4];
                    mark.StudentId = (int)reader[5];
                    mark.Thesis = reader[6].ToString();

                    result.Add(mark);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public ObservableCollection<Mark> GetMarksForASubject(int studentId, int subjectId)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Mark> result = new ObservableCollection<Mark>();
                SqlCommand cmd = new SqlCommand("GetMarksForASubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                SqlParameter paramSubjectId = new SqlParameter("@subjectId", subjectId);
                cmd.Parameters.Add(paramStudentId);
                cmd.Parameters.Add(paramSubjectId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Mark mark = new Mark();

                    mark.MarkId = (int)reader[0];
                    mark.SubjectId = (int)reader[1];
                    mark.Value = (int)reader[2];
                    mark.Date = reader[3].ToString();
                    mark.Semester = (int)reader[4];
                    mark.StudentId = (int)reader[5];
                    mark.SubjectName = reader[6].ToString();
                    mark.Thesis = reader[7].ToString();

                    result.Add(mark);
                }

                return result;
            }
        }

        public ObservableCollection<Mark> GetMarksForStudent(int studentId, int subjectId, int semesterId)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Mark> result = new ObservableCollection<Mark>();
                SqlCommand cmd = new SqlCommand("GetMarksForStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                SqlParameter paramSubjectId = new SqlParameter("@subjectId", subjectId);
                SqlParameter paramSemesterId = new SqlParameter("@semester", semesterId);
                cmd.Parameters.Add(paramStudentId);
                cmd.Parameters.Add(paramSubjectId);
                cmd.Parameters.Add(paramSemesterId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Mark mark = new Mark();

                    mark.MarkId = (int)reader[0];
                    mark.SubjectId = (int)reader[1];
                    mark.Value = (int)reader[2];
                    mark.Date = reader[3].ToString();
                    mark.Semester = (int)reader[4];
                    mark.StudentId = (int)reader[5];
                    mark.SubjectName = reader[6].ToString();
                    mark.Thesis = reader[7].ToString();

                    result.Add(mark);
                }

                return result;
            }
        }

        public void AddMark(Mark mark)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmdMark = new SqlCommand("AddMark", con);
                cmdMark.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSubjectId = new SqlParameter("@subjectId", mark.SubjectId);
                SqlParameter paramValue = new SqlParameter("@value", mark.Value);
                SqlParameter paramDate = new SqlParameter("@date", mark.Date);
                SqlParameter paramSemester = new SqlParameter("@semester", mark.Semester);
                SqlParameter paramStudentId = new SqlParameter("@studentId", mark.StudentId);
                SqlParameter paramIsThesis = new SqlParameter("@boolIsThesis", mark.IsThesis);

                cmdMark.Parameters.Add(paramSubjectId);
                cmdMark.Parameters.Add(paramValue);
                cmdMark.Parameters.Add(paramDate);
                cmdMark.Parameters.Add(paramSemester);
                cmdMark.Parameters.Add(paramStudentId);
                cmdMark.Parameters.Add(paramIsThesis);
                con.Open();
                cmdMark.ExecuteNonQuery();
            }
        }

        public void DeleteMark(Mark mark)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteMark", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter markId = new SqlParameter("@markId", mark.MarkId);
                cmd.Parameters.Add(markId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
