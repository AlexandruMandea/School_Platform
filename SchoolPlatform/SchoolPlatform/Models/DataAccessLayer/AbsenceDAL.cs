using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class AbsenceDAL
    {
        public ObservableCollection<Absence> GetAbsencesForASubject(int studentId, int subjectId)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Absence> result = new ObservableCollection<Absence>();
                SqlCommand cmd = new SqlCommand("GetAbsencesForASubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                SqlParameter paramSubjectId = new SqlParameter("@subjectId", subjectId);
                cmd.Parameters.Add(paramStudentId);
                cmd.Parameters.Add(paramSubjectId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence();

                    absence.AbsenceId = (int)reader[0];
                    absence.SubjectId = (int)reader[1];
                    absence.Date = reader[2].ToString();
                    absence.Semester = (int)reader[3];
                    absence.CanBeExcused = (bool)reader[4];
                    absence.Excused = (bool)reader[5];
                    absence.StudentId = (int)reader[6];
                    absence.SubjectName = reader[7].ToString();

                    result.Add(absence);
                }

                return result;
            }
        }

        public ObservableCollection<Absence> GetAbsencesForStudentForSubject(int studentId, int subjectId, int semester)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Absence> result = new ObservableCollection<Absence>();
                SqlCommand cmd = new SqlCommand("GetAbsencesForStudentForSubject", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                SqlParameter paramSubjectId = new SqlParameter("@subjectId", subjectId);
                SqlParameter paramSemester = new SqlParameter("@semester", semester);
                cmd.Parameters.Add(paramStudentId);
                cmd.Parameters.Add(paramSubjectId);
                cmd.Parameters.Add(paramSemester);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence();

                    absence.AbsenceId = (int)reader[0];
                    absence.SubjectId = (int)reader[1];
                    absence.Date = reader[2].ToString();
                    absence.Semester = (int)reader[3];
                    absence.CanBeExcused = (bool)reader[4];
                    absence.Excused = (bool)reader[5];
                    absence.StudentId = (int)reader[6];
                    absence.SubjectName = reader[7].ToString();

                    result.Add(absence);
                }

                return result;
            }
        }

        public ObservableCollection<Absence> GetAllAbsencesForStudent(int studentId, int semester)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Absence> result = new ObservableCollection<Absence>();
                SqlCommand cmd = new SqlCommand("GetAllAbsencesForStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                SqlParameter paramSemester = new SqlParameter("@semester", semester);
                cmd.Parameters.Add(paramStudentId);
                cmd.Parameters.Add(paramSemester);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence();

                    absence.AbsenceId = (int)reader[0];
                    absence.SubjectId = (int)reader[1];
                    absence.Date = reader[2].ToString();
                    absence.Semester = (int)reader[3];
                    absence.CanBeExcused = (bool)reader[4];
                    absence.Excused = (bool)reader[5];
                    absence.StudentId = (int)reader[6];
                    absence.SubjectName = reader[7].ToString();

                    result.Add(absence);
                }

                return result;
            }
        }

        public ObservableCollection<Absence> GetUnexcusedAbsencesForStudent(int studentId, int semester)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Absence> result = new ObservableCollection<Absence>();
                SqlCommand cmd = new SqlCommand("GetUnexcusedAbsencesForStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramStudentId = new SqlParameter("@studentId", studentId);
                SqlParameter paramSemester = new SqlParameter("@semester", semester);
                cmd.Parameters.Add(paramStudentId);
                cmd.Parameters.Add(paramSemester);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence();

                    absence.AbsenceId = (int)reader[0];
                    absence.SubjectId = (int)reader[1];
                    absence.Date = reader[2].ToString();
                    absence.Semester = (int)reader[3];
                    absence.CanBeExcused = (bool)reader[4];
                    absence.Excused = (bool)reader[5];
                    absence.StudentId = (int)reader[6];
                    absence.SubjectName = reader[7].ToString();

                    result.Add(absence);
                }

                return result;
            }
        }

        public ObservableCollection<Absence> GetAbsencesPerClassroom(int classroomId)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Absence> result = new ObservableCollection<Absence>();
                SqlCommand cmd = new SqlCommand("GetAbsencesPerClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramclassroomId = new SqlParameter("@classroomId", classroomId);
                cmd.Parameters.Add(paramclassroomId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence();

                    absence.AbsenceId = (int)reader[0];
                    absence.SubjectId = (int)reader[1];
                    absence.Date = reader[2].ToString();
                    absence.Semester = (int)reader[3];
                    absence.CanBeExcused = (bool)reader[4];
                    absence.Excused = (bool)reader[5];
                    absence.StudentId = (int)reader[6];
                    absence.SubjectName = reader[7].ToString();

                    result.Add(absence);
                }

                return result;
            }
        }

        public ObservableCollection<Absence> GetUnexcusedAbsencesPerClassroom(int classroomId)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                ObservableCollection<Absence> result = new ObservableCollection<Absence>();
                SqlCommand cmd = new SqlCommand("GetUnexcusedAbsencesPerClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramclassroomId = new SqlParameter("@classroomId", classroomId);
                cmd.Parameters.Add(paramclassroomId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Absence absence = new Absence();

                    absence.AbsenceId = (int)reader[0];
                    absence.SubjectId = (int)reader[1];
                    absence.Date = reader[2].ToString();
                    absence.Semester = (int)reader[3];
                    absence.CanBeExcused = (bool)reader[4];
                    absence.Excused = (bool)reader[5];
                    absence.StudentId = (int)reader[6];
                    absence.SubjectName = reader[7].ToString();

                    result.Add(absence);
                }

                return result;
            }
        }

        public void ExcuseAbsence(Absence absence)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ExcuseAbsence", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramAbsenceId = new SqlParameter("@absenceId", absence.AbsenceId);
                cmd.Parameters.Add(paramAbsenceId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddAbsence(Absence absence)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddAbsence", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSubjectId = new SqlParameter("@subjectId", absence.SubjectId);
                SqlParameter paramDate = new SqlParameter("@date", absence.Date);
                SqlParameter paramSemester = new SqlParameter("@semester", absence.Semester);
                SqlParameter paramCanBeExcused = new SqlParameter("@canBeExcused", absence.CanBeExcused);
                SqlParameter paramExcused = new SqlParameter("@excused", absence.Excused);
                SqlParameter paramStudentId = new SqlParameter("@studentId", absence.StudentId);

                cmd.Parameters.Add(paramSubjectId);
                cmd.Parameters.Add(paramDate);
                cmd.Parameters.Add(paramSemester);
                cmd.Parameters.Add(paramCanBeExcused);
                cmd.Parameters.Add(paramExcused);
                cmd.Parameters.Add(paramStudentId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
