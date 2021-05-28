using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class ClassroomBLL
    {
        ClassroomDAL classroomDAL = new ClassroomDAL();

        public ObservableCollection<Classroom> ClassroomsList { get; set; }
        public ObservableCollection<Classroom> TeachersClassrooms { get; set; }

        public ObservableCollection<Classroom> GetAllClassrooms()
        {
            return classroomDAL.GetAllClassrooms();
        }

        public int GetClassroomIdForStudent(int studentId)
        {
            return classroomDAL.GetClassroomIdForStudent(studentId);
        }

        public ObservableCollection<Classroom> GetTeachersClassrooms(int teacherId)
        {
            return classroomDAL.GetTeachersClassrooms(teacherId);
        }

        public void AddClassroom(Classroom classroom)
        {
            if (classroom != null)
            {
                ClassroomsList.Add(classroom);
                classroomDAL.AddClassroom(classroom);
            }
            else
            {
                MessageBox.Show("Fill or correct all parameters!");
            }
        }

        public void ModifyClassroom(Classroom classroom)
        {
            if(classroom != null)
            {
                classroomDAL.ModifyClassroom(classroom);
            }
            else
            {
                MessageBox.Show("Select a classroom!");
            }
        }

        public void DeleteClassroom(Classroom classroom)
        {
            if (classroom != null)
            {
                ClassroomsList.Remove(classroom);
                classroomDAL.DeleteClassroom(classroom);
            }
            else
            {
                MessageBox.Show("Select a classroom!");
            }
        }
    }
}
