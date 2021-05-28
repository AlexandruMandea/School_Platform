using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class AbsenceBLL
    {
        private AbsenceDAL absenceDAL = new AbsenceDAL();

        public ObservableCollection<Absence> AbsencesForAStudent { get; set; }
        public ObservableCollection<Absence> AbsencesForASubject { get; set; }
        public ObservableCollection<Absence> AbsencesPerClassroom { get; set; }
        public ObservableCollection<Absence> UnexcusedAbsencesPerClassroom { get; set; }
        public ObservableCollection<Absence> UnexcusedAbsencesForStudent { get; set; }

        public ObservableCollection<Absence> GetAbsencesForASubject(int studentId, int subjectId)
        {
            return absenceDAL.GetAbsencesForASubject(studentId, subjectId);
        }

        public static void GetAbsences(TeacherVM teacherVM, ComboBox Students, ComboBox Subjects, ComboBox Semester)
        {
            if (Students.SelectedItem != null && Subjects.SelectedItem != null && Semester.SelectedItem != null)
            {
                teacherVM.AbsencesForAStudent =
                    teacherVM.AbsenceBLL.GetAbsencesForStudentForSubject(
                        teacherVM.SelectedStudentId,
                        teacherVM.SelectedSubjectId,
                        teacherVM.SelectedSemester);
            }
        }

        public static void GetAbsences(ClassMasterVM teacherVM, ComboBox Students, ComboBox Subjects, ComboBox Semester)
        {
            if (Students.SelectedItem != null && Subjects.SelectedItem != null && Semester.SelectedItem != null)
            {
                teacherVM.AbsencesForAStudent =
                    teacherVM.AbsenceBLL.GetAbsencesForStudentForSubject(
                        teacherVM.SelectedStudentId,
                        teacherVM.SelectedSubjectId,
                        teacherVM.SelectedSemester);
            }
        }

        public ObservableCollection<Absence> GetAbsencesForStudentForSubject(int studentId, int subjectId, int semesterId)
        {
            return absenceDAL.GetAbsencesForStudentForSubject(studentId, subjectId, semesterId);
        }

        public ObservableCollection<Absence> GetAllAbsencesForStudent(int studentId, int semesterId)
        {
            return absenceDAL.GetAllAbsencesForStudent(studentId, semesterId);
        }

        public ObservableCollection<Absence> GetUnexcusedAbsencesForStudent(int studentId, int semesterId)
        {
            return absenceDAL.GetUnexcusedAbsencesForStudent(studentId, semesterId);
        }

        public ObservableCollection<Absence> GetAbsencesPerClassroom(int classroomId)
        {
            return absenceDAL.GetAbsencesPerClassroom(classroomId);
        }

        public ObservableCollection<Absence> GetUnexcusedAbsencesPerClassroom(int classroomId)
        {
            return absenceDAL.GetUnexcusedAbsencesPerClassroom(classroomId);
        }

        public void ExcuseAbsence(Absence absence)
        {
            if(absence!=null)
            {
                if (absence.CanBeExcused == true)
                {
                    if (!absence.Excused)
                    {
                        absence.Excused = true;
                        absenceDAL.ExcuseAbsence(absence);
                    }
                    else
                    {
                        MessageBox.Show("This absence is already excused!");
                    }
                }
                else
                {
                    MessageBox.Show("This absence cannot be excused!");
                }
            }
            else
            {
                MessageBox.Show("You must select an absence!");
            }
        }

        public void AddAbsence(Absence absence)
        {
            if (absence!=null)
            {
                if (absence.Semester < 1 || absence.Semester > 2)
                {
                    MessageBox.Show("Invalid data for semester!");
                    return;
                }
                AbsencesForAStudent.Add(absence);
                absenceDAL.AddAbsence(absence);
            }
            else
            {
                MessageBox.Show("Fill or correct all the parameters for absence!");
                return;
            }
        }
    }
}
