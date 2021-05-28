using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class MarkBLL
    {
        MarkDAL markDAL = new MarkDAL();

        public ObservableCollection<Mark> MarksForAStudent { get; set; }
        public ObservableCollection<Mark> MarksForASubject { get; set; }

        public static void GetMarks(TeacherVM teacherVMDataContext, ComboBox Students, ComboBox Subjects, ComboBox Semester)
        {
            if (Students.SelectedItem != null && Subjects.SelectedItem != null && Semester.SelectedItem != null)
            {
                teacherVMDataContext.MarksForAStudent =
                    teacherVMDataContext.MarkBLL.GetMarksForStudent(
                        teacherVMDataContext.SelectedStudentId,
                        teacherVMDataContext.SelectedSubjectId,
                        teacherVMDataContext.SelectedSemester);
            }
        }

        public ObservableCollection<Mark> GetMarksForASubject(int studentId, int subjectId)
        {
            return markDAL.GetMarksForASubject(studentId, subjectId);
        }

        public ObservableCollection<Mark> GetMarksForStudent(int studentId, int subjectId, int semesterId)
        {
            return markDAL.GetMarksForStudent(studentId, subjectId, semesterId);
        }

        public void AddMark(Mark mark)
        {
            if(mark != null)
            {
                if(mark.Value > 0 && mark.Value <= 10)
                {
                    ObservableCollection<Mark> allMarks = markDAL.GetAllMarks();
                    bool found = false;
                    foreach(Mark item in allMarks)
                    {
                        if(item.StudentId == mark.StudentId && item.SubjectId == mark.SubjectId &&
                            item.Semester == mark.Semester && item.IsThesis==mark.IsThesis && mark.IsThesis==true)
                        {
                            found = true;
                        }
                    }
                    if(!found)
                    {
                        MarksForAStudent.Add(mark);
                        markDAL.AddMark(mark);
                    }
                    else
                    {
                        MessageBox.Show("The thesis for this subject already exists!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value for mark!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fill all the parameters for mark!");
                return;
            }
        }

        public void DeleteMark(Mark mark)
        {
            if(mark!=null)
            {
                MarksForAStudent.Remove(mark);
                markDAL.DeleteMark(mark);
            }
            else
            {
                MessageBox.Show("Select a mark to delete!");
            }
        }
    }
}
