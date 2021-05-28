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
    class ClassMasterVM : PropertyChangedNotification
    {
        private User classMaster;
        private int selectedStudentId;
        private int selectedSubjectId;
        private int selectedSemester;
        private int[] semesters;
        private Classroom classroom;
        private LinkingTablesBLL linkingTablesBLL = new LinkingTablesBLL();
        private UserBLL userBLL = new UserBLL();
        private ClassroomBLL classroomBLL = new ClassroomBLL();
        private SubjectBLL subjectBLL = new SubjectBLL();
        private AbsenceBLL absenceBLL = new AbsenceBLL();
        private AverageBLL averageBLL = new AverageBLL();

        public ClassMasterVM()
        {
            ClassMaster = Helper.CurrentUser;
            Classroom = linkingTablesBLL.GetClassMasterClassroom(ClassMaster.UserId);
            StudentsFromClassroom = userBLL.GetStudentsFromClassroom(Classroom.ClassroomId);
            //SubjectsFromClassroom = subjectBLL.GetSubjectsFromClassroom(Classroom.ClassroomId);
            AbsencesForAStudent = absenceBLL.GetAllAbsencesForStudent(selectedStudentId, selectedSemester);
            AbsencesPerClassroom = absenceBLL.GetAbsencesPerClassroom(Classroom.ClassroomId);
            UnexcusedAbsencesPerClassroom = absenceBLL.GetUnexcusedAbsencesPerClassroom(classroom.ClassroomId);
            UnexcusedAbsencesForStudent = absenceBLL.GetUnexcusedAbsencesForStudent(selectedStudentId, selectedSemester);
            Semesters = new int[] { 1, 2 };
        }

        public User ClassMaster
        {
            get
            {
                return classMaster;
            }
            set
            {
                classMaster = value;
                NotifyPropertyChanged("ClassMaster");
            }
        }

        public Classroom Classroom
        {
            get
            {
                return classroom;
            }
            set
            {
                classroom = value;
                NotifyPropertyChanged("ClassMasterClassroomId");
            }
        }

        public int SelectedStudentId
        {
            get
            {
                return selectedStudentId;
            }
            set
            {
                selectedStudentId = value;
                NotifyPropertyChanged("SelectedStudentId");
            }
        }

        public int SelectedSubjectId
        {
            get
            {
                return selectedSubjectId;
            }
            set
            {
                selectedSubjectId = value;
                NotifyPropertyChanged("SelectedSubjectId");
            }
        }

        public int SelectedSemester
        {
            get
            {
                return selectedSemester;
            }
            set
            {
                selectedSemester = value;
                NotifyPropertyChanged("SelectedSemester");
            }
        }

        public int[] Semesters
        {
            get
            {
                return semesters;
            }
            set
            {
                semesters = value;
                NotifyPropertyChanged("Semesters");
            }
        }

        public UserBLL UserBLL
        {
            get
            {
                return userBLL;
            }
            set
            {
                userBLL = value;
                NotifyPropertyChanged("UserBLL");
            }
        }

        public ClassroomBLL ClassroomBLL
        {
            get
            {
                return classroomBLL;
            }
            set
            {
                classroomBLL = value;
            }
        }

        public SubjectBLL SubjectBLL
        {
            get
            {
                return subjectBLL;
            }
            set
            {
                subjectBLL = value;
                NotifyPropertyChanged("SubjectBLL");
            }
        }

        public AbsenceBLL AbsenceBLL
        {
            get
            {
                return absenceBLL;
            }
            set
            {
                absenceBLL = value;
                NotifyPropertyChanged("AbsenceBLL");
            }
        }

        public AverageBLL AverageBLL
        {
            get
            {
                return averageBLL;
            }
            set
            {
                averageBLL = value;
                NotifyPropertyChanged("AverageBLL");
            }
        }

        public LinkingTablesBLL LinkingTablesBLL
        {
            get
            {
                return linkingTablesBLL;
            }
            set
            {
                linkingTablesBLL = value;
                NotifyPropertyChanged("LinkingTablesBLL");
            }
        }

        public ObservableCollection<User> StudentsFromClassroom
        {
            get
            {
                return userBLL.StudentsFromSelectedClassroom;
            }
            set
            {
                userBLL.StudentsFromSelectedClassroom = value;
                NotifyPropertyChanged("StudentsFromClassroom");
            }
        }

        public ObservableCollection<Subject> SubjectsFromClassroom
        {
            get
            {
                return subjectBLL.SubjectsFromClassroom;
            }
            set
            {
                subjectBLL.SubjectsFromClassroom = value;
                NotifyPropertyChanged("SubjectsFromClassroom");
            }
        }

        public ObservableCollection<Absence> AbsencesForAStudent
        {
            get
            {
                return absenceBLL.AbsencesForAStudent;
            }
            set
            {
                absenceBLL.AbsencesForAStudent = value;
                NotifyPropertyChanged("AbsencesForAStudent");
            }
        }

        public ObservableCollection<Absence> AbsencesPerClassroom
        {
            get
            {
                return absenceBLL.AbsencesPerClassroom;
            }
            set
            {
                absenceBLL.AbsencesPerClassroom = value;
                NotifyPropertyChanged("AbsencesPerClassroom");
            }
        }

        public ObservableCollection<Absence> UnexcusedAbsencesPerClassroom
        {
            get
            {
                return absenceBLL.UnexcusedAbsencesPerClassroom;
            }
            set
            {
                absenceBLL.UnexcusedAbsencesPerClassroom = value;
                NotifyPropertyChanged("UnexcusedAbsencesPerClassroom");
            }
        }

        public ObservableCollection<Absence> UnexcusedAbsencesForStudent
        {
            get
            {
                return absenceBLL.UnexcusedAbsencesForStudent;
            }
            set
            {
                absenceBLL.UnexcusedAbsencesForStudent = value;
                NotifyPropertyChanged("UnexcusedAbsencesForStudent");
            }
        }

        private ICommand excuseAbsence;
        public ICommand ExcuseAbsence
        {
            get
            {
                if (excuseAbsence == null)
                {
                    excuseAbsence = new RelayCommand<Absence>(absenceBLL.ExcuseAbsence);
                }

                return excuseAbsence;
            }
        }
    }
}
