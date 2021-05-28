using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class SubjectBLL
    {
        SubjectDAL subjectDAL = new SubjectDAL();

        public ObservableCollection<Subject> SubjectsList { get; set; }
        public ObservableCollection<Subject> SubjectsFromClassroom { get; set; }
        public ObservableCollection<Subject> SubjectsForTeacherForSelectedClassroom { get; set; }

        public ObservableCollection<Subject> GetAllSubjects()
        {
            return subjectDAL.GetAllSubjects();
        }

        public ObservableCollection<Subject> GetSubjectsFromClassroom(int classroomId)
        {
            return subjectDAL.GetSubjectsFromClassroom(classroomId);
        }

        public ObservableCollection<Subject> GetSubjectsForTeacherForSelectedClassroom(int teacherId, int classroomId)
        {
            return subjectDAL.GetSubjectsForTeacherForSelectedClassroom(teacherId, classroomId);
        }

        public void AddSubject(Subject subject)
        {
            if(subject != null)
            {
                SubjectsList.Add(subject);
                subjectDAL.AddSubject(subject);
            }
            else
            {
                MessageBox.Show("Fill or correct all the parameters for subject!");
                return;
            }
        }

        public void ModyfySubject(Subject subject)
        {
            if (subject != null)
            {
                subjectDAL.ModifySubject(subject);
            }
            else
            {
                MessageBox.Show("Select a subject and fill all the parameters!");
                return;
            }
        }

        public void DeleteSubject(Subject subject)
        {
            if (subject != null)
            {
                SubjectsList.Remove(subject);
                subjectDAL.DeleteSubject(subject);
            }
            else
            {
                MessageBox.Show("Select a subject!");
                return;
            }
        }
    }
}
