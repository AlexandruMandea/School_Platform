using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SchoolPlatform.Models.DataAccessLayer
{
    class SpecializationDAL
    {
        public ObservableCollection<Specialization> GetAllSpecializations()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllSpecializations", con);
                ObservableCollection<Specialization> result = new ObservableCollection<Specialization>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Specialization s = new Specialization();
                    s.SpecializationId = (int)(reader[0]);
                    s.Name = reader.GetString(1);
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

        public void AddSpecialization(Specialization specialization)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddSpecialization", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@name", specialization.Name);

                cmd.Parameters.Add(paramName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifySpecialization(Specialization specialization)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifySpecialization", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter specializationId = new SqlParameter("@specializationId", specialization.SpecializationId);
                SqlParameter paramName = new SqlParameter("@name", specialization.Name);
                cmd.Parameters.Add(specializationId);
                cmd.Parameters.Add(paramName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSpecialization(Specialization specialization)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteSpecialization", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramSpecializationId = new SqlParameter("@specializationId", specialization.SpecializationId);
                cmd.Parameters.Add(paramSpecializationId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
