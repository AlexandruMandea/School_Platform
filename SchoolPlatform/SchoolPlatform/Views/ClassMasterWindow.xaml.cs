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
using System.Windows.Shapes;

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for ClassMasterWindow.xaml
    /// </summary>
    public partial class ClassMasterWindow : Window
    {
        public ClassMasterWindow()
        {
            InitializeComponent();
        }

        private void Students1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Students1.SelectedItem != null)
            {
                ClassMasterVM teacherVM = this.DataContext as ClassMasterVM;
                teacherVM.SelectedStudentId = (Students1.SelectedItem as User).UserId;
                teacherVM.AbsencesForAStudent = teacherVM.AbsenceBLL.GetAllAbsencesForStudent(teacherVM.SelectedStudentId, teacherVM.SelectedSemester);
            }
        }
/*
        private void Subjects1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Subjects1.SelectedItem != null)
            {
                ClassMasterVM teacherVM = this.DataContext as ClassMasterVM;
                teacherVM.SelectedSubjectId = (Subjects1.SelectedItem as Subject).SubjectId;
                AbsenceBLL.GetAbsences(teacherVM, Students1, Subjects1, Semester1);
            }
        }
*/
        private void Semester1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Semester1.SelectedItem != null)
            {
                ClassMasterVM teacherVM = this.DataContext as ClassMasterVM;
                teacherVM.SelectedSemester = (int)Semester1.SelectedItem;
                teacherVM.AbsencesForAStudent = teacherVM.AbsenceBLL.GetAllAbsencesForStudent(teacherVM.SelectedStudentId, teacherVM.SelectedSemester);
            }
        }

        private void Students2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Students2.SelectedItem != null)
            {
                ClassMasterVM teacherVM = this.DataContext as ClassMasterVM;
                teacherVM.SelectedStudentId = (Students2.SelectedItem as User).UserId;
                teacherVM.UnexcusedAbsencesForStudent = teacherVM.AbsenceBLL.GetUnexcusedAbsencesForStudent(teacherVM.SelectedStudentId, teacherVM.SelectedSemester);
            }
        }

        private void Semester2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Semester2.SelectedItem != null)
            {
                ClassMasterVM teacherVM = this.DataContext as ClassMasterVM;
                teacherVM.SelectedSemester = (int)Semester2.SelectedItem;
                teacherVM.UnexcusedAbsencesForStudent = teacherVM.AbsenceBLL.GetUnexcusedAbsencesForStudent(teacherVM.SelectedStudentId, teacherVM.SelectedSemester);
            }
        }
    }
}
