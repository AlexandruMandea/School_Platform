using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class LinkingTablesDAL
    {
        public ObservableCollection<LinkingTable> GetAllStudentClassroomLinks()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllStudentClassroomLinks", con);
                ObservableCollection<LinkingTable> result = new ObservableCollection<LinkingTable>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LinkingTable sc = new LinkingTable();
                    sc.ID1 = (int)(reader[0]);
                    sc.ID2 = (int)(reader[1]);
                    result.Add(sc);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddStudentClassroomLink(LinkingTable studentClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddStudentClassroomLink", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter studentId = new SqlParameter("@studentId", studentClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", studentClassroomLink.ID2);

                cmd.Parameters.Add(studentId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyStudentClassroomLink(LinkingTable studentClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyStudentClassroomLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter studentId = new SqlParameter("@studentId", studentClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", studentClassroomLink.ID2);
                cmd.Parameters.Add(studentId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudentClassroomLink(LinkingTable studentClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteStudentClassroomLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter studentId = new SqlParameter("@studentId", studentClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", studentClassroomLink.ID2);
                cmd.Parameters.Add(studentId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ObservableCollection<LinkingTable> GetAllTeacherClassroomLinks()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllTeacherClassroomLinks", con);
                ObservableCollection<LinkingTable> result = new ObservableCollection<LinkingTable>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LinkingTable tc = new LinkingTable();
                    tc.ID1 = (int)(reader[0]);
                    tc.ID2 = (int)(reader[1]);
                    result.Add(tc);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddTeacherClassroomLink(LinkingTable teacherClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddTeacherClassroomLink", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter teacherId = new SqlParameter("@teacherId", teacherClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", teacherClassroomLink.ID2);

                cmd.Parameters.Add(teacherId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTeacherClassroomLink(LinkingTable teacherClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteTeacherClassroomLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter teacherId = new SqlParameter("@teacherId", teacherClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", teacherClassroomLink.ID2);

                cmd.Parameters.Add(teacherId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ObservableCollection<LinkingTable> GetAllSubjectClassroomLinks()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllSubjectClassroomLinks", con);
                ObservableCollection<LinkingTable> result = new ObservableCollection<LinkingTable>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LinkingTable sc = new LinkingTable();
                    sc.ID1 = (int)(reader[0]);
                    sc.ID2 = (int)(reader[1]);
                    result.Add(sc);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddSubjectClassroomLink(LinkingTable subjectClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddSubjectClassroomLink", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter subjectId = new SqlParameter("@subjectId", subjectClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", subjectClassroomLink.ID2);

                cmd.Parameters.Add(subjectId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubjectClassroomLink(LinkingTable subjectClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteSubjectClassroomLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter subjectId = new SqlParameter("@subjectId", subjectClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", subjectClassroomLink.ID2);

                cmd.Parameters.Add(subjectId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ObservableCollection<LinkingTable> GetAllSubjectTeacherLinks()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllSubjectTeacherLinks", con);
                ObservableCollection<LinkingTable> result = new ObservableCollection<LinkingTable>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LinkingTable st = new LinkingTable();
                    st.ID1 = (int)(reader[0]);
                    st.ID2 = (int)(reader[1]);
                    result.Add(st);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddSubjectTeacherLink(LinkingTable subjectTeacherLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddSubjectTeacherLink", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter subjectId = new SqlParameter("@subjectId", subjectTeacherLink.ID1);
                SqlParameter teacherId = new SqlParameter("@teacherId", subjectTeacherLink.ID2);

                cmd.Parameters.Add(subjectId);
                cmd.Parameters.Add(teacherId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubjectTeacherLink(LinkingTable subjectTeacherLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteSubjectTeacherLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter subjectId = new SqlParameter("@subjectId", subjectTeacherLink.ID1);
                SqlParameter teacherId = new SqlParameter("@teacherId", subjectTeacherLink.ID2);

                cmd.Parameters.Add(subjectId);
                cmd.Parameters.Add(teacherId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ObservableCollection<LinkingTable> GetAllClassMasterClassroomLinks()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllClassMasterClassroomLinks", con);
                ObservableCollection<LinkingTable> result = new ObservableCollection<LinkingTable>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LinkingTable cmc = new LinkingTable();
                    cmc.ID1 = (int)(reader[0]);
                    cmc.ID2 = (int)(reader[1]);
                    result.Add(cmc);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddClassMasterClassroomLink(LinkingTable classMasterClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddClassMasterClassroomLink", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter classMasterId = new SqlParameter("@classMasterId", classMasterClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", classMasterClassroomLink.ID2);

                cmd.Parameters.Add(classMasterId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyClassMasterClassroomLink(LinkingTable classMasterClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyClassMasterClassroomLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter classMasterId = new SqlParameter("@classMasterId", classMasterClassroomLink.ID1);
                SqlParameter classroomId = new SqlParameter("@classroomId", classMasterClassroomLink.ID2);

                cmd.Parameters.Add(classMasterId);
                cmd.Parameters.Add(classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteClassMasterClassroomLink(LinkingTable classMasterClassroomLink)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteClassMasterClassroomLink", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter classMasterId = new SqlParameter("@classMasterId", classMasterClassroomLink.ID1);

                cmd.Parameters.Add(classMasterId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Classroom GetClassMasterClassroom(int teacherId)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetClassMasterClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramTeacherId = new SqlParameter("@teacherId", teacherId);
                cmd.Parameters.Add(paramTeacherId);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                Classroom classMasterClassroom = null;

                if (reader.Read())
                {
                    classMasterClassroom = new Classroom()
                    {
                        ClassroomId = (int)reader[0],
                        SpecializationId = (int)reader[1],
                        Year = (int)reader[2],
                        Name = reader[3].ToString()
                    };
                }

                reader.Close();
                return classMasterClassroom;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
