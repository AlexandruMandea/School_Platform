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
    /// Interaction logic for TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        public TeacherWindow()
        {
            InitializeComponent();
        }

        private void Absences_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new AbsencesPage();
        }

        private void Marks_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new MarksPage();
        }

        private void MakeAverage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new MakeAveragePage();
        }

        private void ClassMasterBusiness_Click(object sender, RoutedEventArgs e)
        {
            ClassMasterWindow classMasterWindow = new ClassMasterWindow();
            classMasterWindow.Show();
        }
    }
}
