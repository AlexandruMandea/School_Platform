using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class AverageDAL
    {
        public ObservableCollection<Average> GetAveragesForStudent(int studentId)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Average> result = new ObservableCollection<Average>();
                SqlCommand cmd = new SqlCommand("GetAveragesForStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                cmd.Parameters.Add(paramStudentId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Average average = new Average();

                    average.AverageId = (int)reader[0];
                    average.Value = (double)reader[1];
                    average.Semester = (int)reader[2];
                    average.SubjectId = (int)reader[3];
                    average.StudentId = (int)reader[4];
                    average.SubjectName = reader[5].ToString();

                    result.Add(average);
                }

                return result;
            }
        }

        public void MakeAverage(Average average)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmdMark = new SqlCommand("MakeAverage", con);
                cmdMark.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSemester = new SqlParameter("@semester", average.Semester);
                SqlParameter paramSubjectId = new SqlParameter("@subjectId", average.SubjectId);
                SqlParameter paramStudentId = new SqlParameter("@studentId", average.StudentId);

                cmdMark.Parameters.Add(paramSemester);
                cmdMark.Parameters.Add(paramSubjectId);
                cmdMark.Parameters.Add(paramStudentId);
                con.Open();
                cmdMark.ExecuteNonQuery();
            }
        }
    }
}
