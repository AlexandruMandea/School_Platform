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
using System.Windows.Shapes;

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void Subjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (this.DataContext as StudentVM).SubjectId = (Subjects.SelectedItem as Subject).SubjectId;
            (this.DataContext as StudentVM).MarksForASubject = (this.DataContext as StudentVM).MarkBLL.GetMarksForASubject(Helper.CurrentUserID, (this.DataContext as StudentVM).SubjectId);
            (this.DataContext as StudentVM).AbsencesForASubject = (this.DataContext as StudentVM).AbsenceBLL.GetAbsencesForASubject(Helper.CurrentUserID, (this.DataContext as StudentVM).SubjectId);
        }
    }
}
