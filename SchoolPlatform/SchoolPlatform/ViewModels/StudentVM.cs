using SchoolPlatform.Models.BusinessLogicLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SchoolPlatform.ViewModels
{
    class StudentVM : PropertyChangedNotification
    {
        private User student;
        private int subjectId;
        private int classroomId;
        private UserBLL userBLL = new UserBLL();
        private ClassroomBLL calssroomBLL = new ClassroomBLL();
        private MarkBLL markBLL = new MarkBLL();
        private AbsenceBLL absenceBLL = new AbsenceBLL();
        private SubjectBLL subjectBLL = new SubjectBLL();
        private AverageBLL averageBLL = new AverageBLL();

        public StudentVM()
        {
            Student = userBLL.GetUser(Helper.CurrentUsername, Helper.CurrentPassword);
            ClassroomId = calssroomBLL.GetClassroomIdForStudent(student.UserId);
            SubjectsFromClassroom = subjectBLL.GetSubjectsFromClassroom(classroomId);
            MarksForASubject = markBLL.GetMarksForASubject(student.UserId, subjectId);
            AbsencesForASubject = absenceBLL.GetAbsencesForASubject(student.UserId, subjectId);
            Averages = averageBLL.GetAveragesForStudent(student.UserId);
        }

        public StudentVM(string username, string password)
        {

        }

        public User Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
                NotifyPropertyChanged("Student");
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

        public int ClassroomId
        {
            get
            {
                return classroomId;
            }
            set
            {
                classroomId = value;
                NotifyPropertyChanged("ClassroomId");
            }
        }

        public int SubjectId
        {
            get
            {
                return subjectId;
            }
            set
            {
                subjectId = value;
                NotifyPropertyChanged("SubjectId");
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

        public ObservableCollection<Mark> MarksForASubject
        {
            get
            {
                return markBLL.MarksForASubject;
            }
            set
            {
                markBLL.MarksForASubject = value;
                NotifyPropertyChanged("MarksForASubject");
            }
        }

        public ObservableCollection<Absence> AbsencesForASubject
        {
            get
            {
                return absenceBLL.AbsencesForASubject;
            }
            set
            {
                absenceBLL.AbsencesForASubject = value;
                NotifyPropertyChanged("AbsencesForASubject");
            }
        }

        public ObservableCollection<Average> Averages
        {
            get
            {
                return averageBLL.AveragesForStudent;
            }
            set
            {
                averageBLL.AveragesForStudent = value;
                NotifyPropertyChanged("Averages");
            }
        }
    }
}
