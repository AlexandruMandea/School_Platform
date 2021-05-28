using SchoolPlatform.Models.BusinessLogicLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.Services;
using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for AbsencesCatalog.xaml
    /// </summary>
    public partial class AbsencesPage : Page
    {
        public AbsencesPage()
        {
            InitializeComponent();
        }

        private void Classrooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TeacherVM teacherVM = this.DataContext as TeacherVM;
            teacherVM.SelectedClassroomId = (Classrooms.SelectedItem as Classroom).ClassroomId;

            teacherVM.StudentsFromSelectedClassroom =
                teacherVM.UserBLL.GetStudentsFromClassroom(teacherVM.SelectedClassroomId);
            teacherVM.SubjectsForTeacherForSelectedClassroom =
                teacherVM.SubjectBLL.GetSubjectsForTeacherForSelectedClassroom(teacherVM.Teacher.UserId, teacherVM.SelectedClassroomId);
        }

        private void Students_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Students.SelectedItem != null)
            {
                TeacherVM teacherVM = this.DataContext as TeacherVM;
                teacherVM.SelectedStudentId = (Students.SelectedItem as User).UserId;
                AbsenceBLL.GetAbsences(teacherVM, Students, Subjects, Semester);
            }
        }

        private void Subjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Subjects.SelectedItem != null)
            {
                TeacherVM teacherVM = this.DataContext as TeacherVM;
                teacherVM.SelectedSubjectId = (Subjects.SelectedItem as Subject).SubjectId;
                AbsenceBLL.GetAbsences(teacherVM, Students, Subjects, Semester);
            }
        }

        private void Semester_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Semester.SelectedItem != null)
            {
                TeacherVM teacherVM = this.DataContext as TeacherVM;
                teacherVM.SelectedSemester = (int)Semester.SelectedItem;
                AbsenceBLL.GetAbsences(teacherVM, Students, Subjects, Semester);
            }
        }
    }
}
