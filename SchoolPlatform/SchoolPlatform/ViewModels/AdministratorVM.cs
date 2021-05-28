using SchoolPlatform.Models.BusinessLogicLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.Services;
using SchoolPlatform.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace SchoolPlatform.ViewModels
{
    class AdministratorVM : PropertyChangedNotification
    {
        private User administrator;

        private UserBLL userBLL = new UserBLL();
        private UserTypeBLL userTypeBLL = new UserTypeBLL();
        private SpecializationBLL specializationBLL = new SpecializationBLL();
        private SubjectBLL subjectBLL = new SubjectBLL();
        private ClassroomBLL classroomBLL = new ClassroomBLL();
        private LinkingTablesBLL linkingTablesBLL = new LinkingTablesBLL();

        public AdministratorVM()
        {
            Administrator = userBLL.GetUser(Helper.CurrentUsername, Helper.CurrentPassword);
            UsersList = userBLL.GetAllUsers();
            UserTypesList = userTypeBLL.GetAllUserTypes();
            SpecializationsList = specializationBLL.GetAllSpecializations();
            SubjectsList = subjectBLL.GetAllSubjects();
            ClassrommsList = classroomBLL.GetAllClassrooms();

            StudentClassroomLinks = linkingTablesBLL.GetAllStudentClassroomLinks();
            TeacherClassroomLinks = linkingTablesBLL.GetAllTeacherClassroomLinks();
            SubjectClassroomLinks = linkingTablesBLL.GetAllSubjectClassroomLinks();
            SubjectTeacherLinks = linkingTablesBLL.GetAllSubjectTeacherLinks();
            ClassMasterClassroomLinks = linkingTablesBLL.GetAllClassMasterClassroomLinks();
        }

        public User Administrator
        {
            get
            {
                return administrator;
            }
            set
            {
                administrator = value;
                NotifyPropertyChanged("Administrator");
            }
        }

        public ObservableCollection<User> UsersList
        {
            get
            {
                return userBLL.UsersList;
            }
            set
            {
                userBLL.UsersList = value;
                NotifyPropertyChanged("UsersList");
            }
        }

        public ObservableCollection<UserType> UserTypesList
        {
            get
            {
                return userTypeBLL.UserTypesList;
            }
            set
            {
                userTypeBLL.UserTypesList = value;
                NotifyPropertyChanged("UserTypesList");
            }
        }

        public ObservableCollection<Specialization> SpecializationsList
        {
            get
            {
                return specializationBLL.SpecializationsList;
            }
            set
            {
                specializationBLL.SpecializationsList = value;
                NotifyPropertyChanged("SpecializationsList");
            }
        }

        public ObservableCollection<Subject> SubjectsList
        {
            get
            {
                return subjectBLL.SubjectsList;
            }
            set
            {
                subjectBLL.SubjectsList = value;
                NotifyPropertyChanged("SubjectsList");
            }
        }

        public ObservableCollection<Classroom> ClassrommsList
        {
            get
            {
                return classroomBLL.ClassroomsList;
            }
            set
            {
                classroomBLL.ClassroomsList = value;
                NotifyPropertyChanged("ClasroomsList");
            }
        }

        public ObservableCollection<LinkingTable> StudentClassroomLinks
        {
            get
            {
                return linkingTablesBLL.StudentClassroomLinks;
            }
            set
            {
                linkingTablesBLL.StudentClassroomLinks = value;
                NotifyPropertyChanged("StudentClassroomLinks");
            }
        }

        public ObservableCollection<LinkingTable> TeacherClassroomLinks
        {
            get
            {
                return linkingTablesBLL.TeacherClassroomLinks;
            }
            set
            {
                linkingTablesBLL.TeacherClassroomLinks = value;
                NotifyPropertyChanged("StudentClassroomLinks");
            }
        }

        public ObservableCollection<LinkingTable> SubjectClassroomLinks
        {
            get
            {
                return linkingTablesBLL.SubjectClassroomLinks;
            }
            set
            {
                linkingTablesBLL.SubjectClassroomLinks = value;
                NotifyPropertyChanged("StudentClassroomLinks");
            }
        }

        public ObservableCollection<LinkingTable> SubjectTeacherLinks
        {
            get
            {
                return linkingTablesBLL.SubjectTeacherLinks;
            }
            set
            {
                linkingTablesBLL.SubjectTeacherLinks = value;
                NotifyPropertyChanged("StudentClassroomLinks");
            }
        }

        public ObservableCollection<LinkingTable> ClassMasterClassroomLinks
        {
            get
            {
                return linkingTablesBLL.ClassMasterClassroomLinks;
            }
            set
            {
                linkingTablesBLL.ClassMasterClassroomLinks = value;
                NotifyPropertyChanged("StudentClassroomLinks");
            }
        }

        private ICommand addUserCommand;
        public ICommand AddUserCommand
        {
            get
            {
                if (addUserCommand == null)
                {
                    addUserCommand = new RelayCommand<User>(userBLL.AddUser);
                }
                return addUserCommand;
            }
        }

        private ICommand modifyUserCommand;
        public ICommand ModifyUserCommand
        {
            get
            {
                if (modifyUserCommand == null)
                {
                    modifyUserCommand = new RelayCommand<User>(userBLL.ModifyUser);
                }
                return modifyUserCommand;
            }
        }

        private ICommand deleteUserCommand;
        public ICommand DeleteUserCommand
        {
            get
            {
                if (deleteUserCommand == null)
                {
                    deleteUserCommand = new RelayCommand<User>(userBLL.DeleteUser);
                }
                return deleteUserCommand;
            }
        }

        /*private ICommand refreshUsersListCommand;
        public ICommand RefreshUsersListCommand
        {
            get
            {
                if(refreshUsersListCommand == null)
                {
                    refreshUsersListCommand = new RelayCommand<User>(userBLL.RefreshUsersList)
                }
                return refreshUsersListCommand;
            }
        }*/

        private ICommand addUserTypeCommand;
        public ICommand AddUserTypeCommand
        {
            get
            {
                if (addUserTypeCommand == null)
                {
                    addUserTypeCommand = new RelayCommand<UserType>(userTypeBLL.AddUserType);
                }
                return addUserTypeCommand;
            }
        }

        private ICommand modifyUserTypeCommand;
        public ICommand ModifyUserTypeCommand
        {
            get
            {
                if (modifyUserTypeCommand == null)
                {
                    modifyUserTypeCommand = new RelayCommand<UserType>(userTypeBLL.ModifyUserType);
                }
                return modifyUserTypeCommand;
            }
        }

        private ICommand deleteUserTypeCommand;
        public ICommand DeleteUserTypeCommand
        {
            get
            {
                if (deleteUserTypeCommand == null)
                {
                    deleteUserTypeCommand = new RelayCommand<UserType>(userTypeBLL.DeleteUserType);
                }
                return deleteUserTypeCommand;
            }
        }

        private ICommand addSpecializationCommand;
        public ICommand AddSpecializationCommand
        {
            get
            {
                if (addSpecializationCommand == null)
                {
                    addSpecializationCommand = new RelayCommand<Specialization>(specializationBLL.AddSpecialization);
                }
                return addSpecializationCommand;
            }
        }

        private ICommand modifySpecializationCommand;
        public ICommand ModifiSpecializationCommand
        {
            get
            {
                if (modifySpecializationCommand == null)
                {
                    modifySpecializationCommand = new RelayCommand<Specialization>(specializationBLL.ModifySpecialization);
                }
                return modifySpecializationCommand;
            }
        }

        private ICommand deleteSpecializationCommand;
        public ICommand DeleteSpecializationCommand
        {
            get
            {
                if (deleteSpecializationCommand == null)
                {
                    deleteSpecializationCommand = new RelayCommand<Specialization>(specializationBLL.DeleteSpecialization);
                }
                return deleteSpecializationCommand;
            }
        }

        private ICommand addSubjectCommand;
        public ICommand AddSubjectCommand
        {
            get
            {
                if (addSubjectCommand == null)
                {
                    addSubjectCommand = new RelayCommand<Subject>(subjectBLL.AddSubject);
                }
                return addSubjectCommand;
            }
        }

        private ICommand modifySubjectCommand;
        public ICommand ModifySubjectCommand
        {
            get
            {
                if (modifySubjectCommand == null)
                {
                    modifySubjectCommand = new RelayCommand<Subject>(subjectBLL.ModyfySubject);
                }
                return modifySubjectCommand;
            }
        }

        private ICommand deleteSubjectCommand;
        public ICommand DeleteSubjectCommand
        {
            get
            {
                if (deleteSubjectCommand == null)
                {
                    deleteSubjectCommand = new RelayCommand<Subject>(subjectBLL.DeleteSubject);
                }
                return deleteSubjectCommand;
            }
        }

        private ICommand addClassroomCommand;
        public ICommand AddClassroomCommand
        {
            get
            {
                if (addClassroomCommand == null)
                {
                    addClassroomCommand = new RelayCommand<Classroom>(classroomBLL.AddClassroom);
                }
                return addClassroomCommand;
            }
        }

        private ICommand modifyClassroomCommand;
        public ICommand ModifyClassroomCommand
        {
            get
            {
                if (modifyClassroomCommand == null)
                {
                    modifyClassroomCommand = new RelayCommand<Classroom>(classroomBLL.ModifyClassroom);
                }
                return modifyClassroomCommand;
            }
        }

        private ICommand deleteClassroomCommand;
        public ICommand DeleteClassroomCommand
        {
            get
            {
                if (deleteClassroomCommand == null)
                {
                    deleteClassroomCommand = new RelayCommand<Classroom>(classroomBLL.DeleteClassroom);
                }
                return deleteClassroomCommand;
            }
        }

        private ICommand addStudentClassroomLinkCommand;
        public ICommand AddStudentClassroomLinkCommand
        {
            get
            {
                if (addStudentClassroomLinkCommand == null)
                {
                    addStudentClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.AddStudentClassroomLink);
                }
                return addStudentClassroomLinkCommand;
            }
        }

        private ICommand modifyStudentClassroomLinkCommand;
        public ICommand ModifyStudentClassroomLinkCommand
        {
            get
            {
                if (modifyStudentClassroomLinkCommand == null)
                {
                    modifyStudentClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.ModifyStudentClassroomLink);
                }
                return modifyStudentClassroomLinkCommand;
            }
        }

        private ICommand deleteStudentClassroomLinkCommand;
        public ICommand DeleteStudentClassroomLinkCommand
        {
            get
            {
                if (deleteStudentClassroomLinkCommand == null)
                {
                    deleteStudentClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.DeleteStudentClassroomLink);
                }
                return deleteStudentClassroomLinkCommand;
            }
        }

        private ICommand addTeacherClassroomLinkCommand;
        public ICommand AddTeacherClassroomLinkCommand
        {
            get
            {
                if (addTeacherClassroomLinkCommand == null)
                {
                    addTeacherClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.AddTeacherClassroomLink);
                }
                return addTeacherClassroomLinkCommand;
            }
        }

        private ICommand deleteTeacherClassroomLinkCommand;
        public ICommand DeleteTeacherClassroomLinkCommand
        {
            get
            {
                if (deleteTeacherClassroomLinkCommand == null)
                {
                    deleteTeacherClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.DeleteTeacherClassroomLink);
                }
                return deleteTeacherClassroomLinkCommand;
            }
        }

        private ICommand addSubjectClassroomLinkCommand;
        public ICommand AddSubjectClassroomLinkCommand
        {
            get
            {
                if (addSubjectClassroomLinkCommand == null)
                {
                    addSubjectClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.AddSubjectClassroomLink);
                }
                return addSubjectClassroomLinkCommand;
            }
        }

        private ICommand deleteSubjectClassroomLinkCommand;
        public ICommand DeleteSubjectClassroomLinkCommand
        {
            get
            {
                if (deleteSubjectClassroomLinkCommand == null)
                {
                    deleteSubjectClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.DeleteSubjectClassroomLink);
                }
                return deleteSubjectClassroomLinkCommand;
            }
        }

        private ICommand addSubjectTeacherLinkCommand;
        public ICommand AddSubjectTeacherLinkCommand
        {
            get
            {
                if (addSubjectTeacherLinkCommand == null)
                {
                    addSubjectTeacherLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.AddSubjectTeacherLink);
                }
                return addSubjectTeacherLinkCommand;
            }
        }

        private ICommand deleteSubjectTeacherLinkCommand;
        public ICommand DeleteSubjectTeacherLinkCommand
        {
            get
            {
                if (deleteSubjectTeacherLinkCommand == null)
                {
                    deleteSubjectTeacherLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.DeleteSubjectTeacherLink);
                }
                return deleteSubjectTeacherLinkCommand;
            }
        }

        private ICommand addClassMasterClassroomLinkCommand;
        public ICommand AddClassMasterClassroomLinkCommand
        {
            get
            {
                if (addClassMasterClassroomLinkCommand == null)
                {
                    addClassMasterClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.AddClassMasterClassroomLink);
                }
                return addClassMasterClassroomLinkCommand;
            }
        }

        private ICommand modifyClassMasterClassroomLinkCommand;
        public ICommand ModifyClassMasterClassroomLinkCommand
        {
            get
            {
                if (modifyClassMasterClassroomLinkCommand == null)
                {
                    modifyClassMasterClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.ModifyClassMasterClassroomLink);
                }
                return modifyClassMasterClassroomLinkCommand;
            }
        }

        private ICommand deleteClassMasterClassroomLinkCommand;
        public ICommand DeleteClassMasterClassroomLinkCommand
        {
            get
            {
                if (deleteClassMasterClassroomLinkCommand == null)
                {
                    deleteClassMasterClassroomLinkCommand = new RelayCommand<LinkingTable>(linkingTablesBLL.DeleteClassMasterClassroomLink);
                }
                return deleteClassMasterClassroomLinkCommand;
            }
        }
    }
}
