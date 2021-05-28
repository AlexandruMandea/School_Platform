using SchoolPlatform.Models.BusinessLogicLayer;
using SchoolPlatform.Models.Entities;
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
    /// Interaction logic for MakeAveragePage.xaml
    /// </summary>
    public partial class MakeAveragePage : Page
    {
        public MakeAveragePage()
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
    }
}
