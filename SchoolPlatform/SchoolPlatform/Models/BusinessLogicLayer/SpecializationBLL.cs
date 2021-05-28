using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class SpecializationBLL
    {
        public ObservableCollection<Specialization> SpecializationsList { get; set; }
        SpecializationDAL specializationDAL = new SpecializationDAL();

        public ObservableCollection<Specialization> GetAllSpecializations()
        {
            return specializationDAL.GetAllSpecializations();
        }

        public void AddSpecialization(Specialization specialization)
        {
            if (specialization != null)
            {
                SpecializationsList.Add(specialization);
                specializationDAL.AddSpecialization(specialization);
            }
            else
            {
                MessageBox.Show("Fill or correct all the parameters for specialization!");
                return;
            }
        }

        public void ModifySpecialization(Specialization specialization)
        {
            if (specialization != null)
            {
                specializationDAL.ModifySpecialization(specialization);
            }
            else
            {
                MessageBox.Show("Fill all the parameters or select a specialization!");
                return;
            }
        }

        public void DeleteSpecialization(Specialization specialization)
        {
            if (specialization != null)
            {
                SpecializationsList.Remove(specialization);
                specializationDAL.DeleteSpecialization(specialization);
            }
            else
            {
                MessageBox.Show("Select a specialization!");
                return;
            }
        }
    }
}
