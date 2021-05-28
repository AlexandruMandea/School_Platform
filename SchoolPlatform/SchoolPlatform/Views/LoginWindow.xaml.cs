using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SchoolPlatform.Services;

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            UserVM userVM = new UserVM(Username.Text.ToString(), Password.Password.ToString());
            if(userVM.User != null)
            {
                Helper.CurrentUser = userVM.User;
                Helper.CurrentUserID = userVM.User.UserId;
                Helper.CurrentUsername = Username.Text.ToString();
                Helper.CurrentPassword = Password.Password.ToString();

                switch (userVM.User.UserTypeId)
                {
                    case 1:
                        AdministratorWindow administratorWindow = new AdministratorWindow();
                        administratorWindow.Show();
                        break;
                    case 2:
                        TeacherWindow teacherWindow = new TeacherWindow();
                        teacherWindow.Show();
                        break;
                    case 3:
                        StudentWindow studentWindow = new StudentWindow();
                        studentWindow.Show();
                        break;
                }
                
            }
            else
            {
                Password.Clear();
                MessageBox.Show("Wrong credentials!");
            }
        }
    }
}
