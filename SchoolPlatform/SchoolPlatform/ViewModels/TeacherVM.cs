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
    class TeacherVM : PropertyChangedNotification
    {
        private User teacher;
        private int selectedClassroomId;
        private int selectedStudentId;
        private int selectedSubjectId;
        private int selectedSemester;
        private bool isClassMaster;
        private int[] semesters;
        private UserBLL userBLL = new UserBLL();
        private ClassroomBLL classroomBLL = new ClassroomBLL();
        private SubjectBLL subjectBLL = new SubjectBLL();
        private AbsenceBLL absenceBLL = new AbsenceBLL();
        private MarkBLL markBLL = new MarkBLL();
        private AverageBLL averageBLL = new AverageBLL();
        private LinkingTablesBLL linkingTablesBLL = new LinkingTablesBLL();
        //private LinkingTable classMasterClassroomLink = new LinkingTable();

        public TeacherVM()
        {
            Teacher = userBLL.GetUser(Helper.CurrentUsername, Helper.CurrentPassword);
            TeachersClassrooms = classroomBLL.GetTeachersClassrooms(teacher.UserId);
            StudentsFromSelectedClassroom = userBLL.GetStudentsFromClassroom(SelectedClassroomId);
            SubjectsForTeacherForSelectedClassroom = subjectBLL.GetSubjectsForTeacherForSelectedClassroom(Teacher.UserId, SelectedClassroomId);
            MarksForAStudent = markBLL.GetMarksForStudent(selectedStudentId, selectedSubjectId, selectedSemester);
            Semesters = new int[] { 1, 2 };
            IsClassMaster = linkingTablesBLL.IsClassMaster(Teacher.UserId);
        }

        public User Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = value;
                NotifyPropertyChanged("Teacher");
            }
        }

        public int SelectedClassroomId
        {
            get
            {
                return selectedClassroomId;
            }
            set
            {
                selectedClassroomId = value;
                NotifyPropertyChanged("SelectedClassroomId");
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

        public MarkBLL MarkBLL
        {
            get
            {
                return markBLL;
            }
            set
            {
                markBLL = value;
                NotifyPropertyChanged("MarkBLL");
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

        public bool IsClassMaster
        {
            get
            {
                return isClassMaster;
            }
            set
            {
                isClassMaster = value;
                NotifyPropertyChanged("IsClassMaster");
            }
        }

        /*public LinkingTable ClassMasterClassroomLink
        {
            get
            {
                return classMasterClassroomLink;
            }
            set
            {
                classMasterClassroomLink = value;
                NotifyPropertyChanged("ClassMasterClassroomLink");
            }
        }*/

        public ObservableCollection<Classroom> TeachersClassrooms
        {
            get
            {
                return classroomBLL.TeachersClassrooms;
            }
            set
            {
                classroomBLL.TeachersClassrooms = value;
                NotifyPropertyChanged("TeachersClassrooms");
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

        public ObservableCollection<Mark> MarksForAStudent
        {
            get
            {
                return markBLL.MarksForAStudent;
            }
            set
            {
                markBLL.MarksForAStudent = value;
                NotifyPropertyChanged("MarksForAStudent");
            }
        }

        public ObservableCollection<User> StudentsFromSelectedClassroom
        {
            get
            {
                return userBLL.StudentsFromSelectedClassroom;
            }
            set
            {
                userBLL.StudentsFromSelectedClassroom = value;
                NotifyPropertyChanged("StudentsFromSelectedClassroom");
            }
        }

        public ObservableCollection<Subject> SubjectsForTeacherForSelectedClassroom
        {
            get
            {
                return subjectBLL.SubjectsForTeacherForSelectedClassroom;
            }
            set
            {
                subjectBLL.SubjectsForTeacherForSelectedClassroom = value;
                NotifyPropertyChanged("SubjectsForTeacherForSelectedClassroom");
            }
        }

        private ICommand excuseAbsence;
        public ICommand ExcuseAbsence
        {
            get
            {
                if(excuseAbsence == null)
                {
                    excuseAbsence = new RelayCommand<Absence>(absenceBLL.ExcuseAbsence);
                }

                return excuseAbsence;
            }
        }

        private ICommand addAbsence;
        public ICommand AddAbsence
        {
            get
            {
                if(addAbsence == null)
                {
                    addAbsence = new RelayCommand<Absence>(absenceBLL.AddAbsence);
                }
                return addAbsence;
            }
        }

        private ICommand addMark;
        public ICommand AddMark
        {
            get
            {
                if (addMark == null)
                {
                    addMark = new RelayCommand<Mark>(markBLL.AddMark);
                }
                return addMark;
            }
        }

        private ICommand deleteMark;
        public ICommand DeleteMark
        {
            get
            {
                if (deleteMark == null)
                {
                    deleteMark = new RelayCommand<Mark>(markBLL.DeleteMark);
                }
                return deleteMark;
            }
        }

        private ICommand makeAverage;
        public ICommand MakeAverage
        {
            get
            {
                if(makeAverage==null)
                {
                    makeAverage = new RelayCommand<Average>(averageBLL.MakeAverage);
                }
                return makeAverage;
            }
        }
    }
}
