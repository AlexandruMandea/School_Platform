using SchoolPlatform.Models.DataAccessLayer;
using SchoolPlatform.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace SchoolPlatform.Models.BusinessLogicLayer
{
    class LinkingTablesBLL
    {
        LinkingTablesDAL linkingTablesDAL = new LinkingTablesDAL();
        public ObservableCollection<LinkingTable> StudentClassroomLinks { get; set; }
        public ObservableCollection<LinkingTable> TeacherClassroomLinks { get; set; }
        public ObservableCollection<LinkingTable> SubjectClassroomLinks { get; set; }
        public ObservableCollection<LinkingTable> SubjectTeacherLinks { get; set; }
        public ObservableCollection<LinkingTable> ClassMasterClassroomLinks { get; set; }

        public ObservableCollection<LinkingTable> GetAllStudentClassroomLinks()
        {
            return linkingTablesDAL.GetAllStudentClassroomLinks();
        }

        public void AddStudentClassroomLink(LinkingTable studentClassroomLink)
        {
            if(studentClassroomLink!=null)
            {
                bool found = false;
                foreach(LinkingTable item in StudentClassroomLinks)
                {
                    if(item.ID1 == studentClassroomLink.ID1)
                    {
                        found = true;
                    }
                }
                if(!found)
                {
                    StudentClassroomLinks.Add(studentClassroomLink);
                    linkingTablesDAL.AddStudentClassroomLink(studentClassroomLink);
                }
                else
                {
                    MessageBox.Show("A student can be assigned to a single classroom!");
                }
            }
            else
            {
                MessageBox.Show("Fill all parameters!");
            }
        }

        public void ModifyStudentClassroomLink(LinkingTable studentClassroomLink)
        {
            if (studentClassroomLink != null)
            {
                linkingTablesDAL.ModifyStudentClassroomLink(studentClassroomLink);
            }
            else
            {
                MessageBox.Show("Select a student-classroom link!");
            }
        }

        public void DeleteStudentClassroomLink(LinkingTable studentClassroomLink)
        {
            if (studentClassroomLink != null)
            {
                StudentClassroomLinks.Remove(studentClassroomLink);
                linkingTablesDAL.DeleteStudentClassroomLink(studentClassroomLink);
            }
            else
            {
                MessageBox.Show("Select a student-classroom link!");
            }
        }

        public ObservableCollection<LinkingTable> GetAllTeacherClassroomLinks()
        {
            return linkingTablesDAL.GetAllTeacherClassroomLinks();
        }

        public void AddTeacherClassroomLink(LinkingTable teacherClassroomLink)
        {
            if (teacherClassroomLink != null)
            {
                TeacherClassroomLinks.Add(teacherClassroomLink);
                linkingTablesDAL.AddTeacherClassroomLink(teacherClassroomLink);
            }
            else
            {
                MessageBox.Show("Fill all parameters for teacher-classroom link!");
            }
        }

        public void DeleteTeacherClassroomLink(LinkingTable teacherClassroomLink)
        {
            if (teacherClassroomLink != null)
            {
                TeacherClassroomLinks.Remove(teacherClassroomLink);
                linkingTablesDAL.DeleteTeacherClassroomLink(teacherClassroomLink);
            }
            else
            {
                MessageBox.Show("Select a teacher-classroom link!");
            }
        }

        public ObservableCollection<LinkingTable> GetAllSubjectClassroomLinks()
        {
            return linkingTablesDAL.GetAllSubjectClassroomLinks();
        }

        public void AddSubjectClassroomLink(LinkingTable subjectClassroomLink)
        {
            if (subjectClassroomLink != null)
            {
                SubjectClassroomLinks.Add(subjectClassroomLink);
                linkingTablesDAL.AddSubjectClassroomLink(subjectClassroomLink);
            }
            else
            {
                MessageBox.Show("Fill all parameters for subject-classroom link!");
            }
        }

        public void DeleteSubjectClassroomLink(LinkingTable subjectClassroomLink)
        {
            if (subjectClassroomLink != null)
            {
                SubjectClassroomLinks.Remove(subjectClassroomLink);
                linkingTablesDAL.DeleteSubjectClassroomLink(subjectClassroomLink);
            }
            else
            {
                MessageBox.Show("Select a subject-classroom link!");
            }
        }

        public ObservableCollection<LinkingTable> GetAllSubjectTeacherLinks()
        {
            return linkingTablesDAL.GetAllSubjectTeacherLinks();
        }

        public void AddSubjectTeacherLink(LinkingTable subjectTeacherLink)
        {
            if (subjectTeacherLink != null)
            {
                SubjectTeacherLinks.Add(subjectTeacherLink);
                linkingTablesDAL.AddSubjectTeacherLink(subjectTeacherLink);
            }
            else
            {
                MessageBox.Show("Fill all parameters for subject-teacher link!");
            }
        }

        public void DeleteSubjectTeacherLink(LinkingTable subjectTeacherLink)
        {
            if (subjectTeacherLink != null)
            {
                SubjectTeacherLinks.Remove(subjectTeacherLink);
                linkingTablesDAL.DeleteSubjectTeacherLink(subjectTeacherLink);
            }
            else
            {
                MessageBox.Show("Select a subject-teacher link!");
            }
        }

        public ObservableCollection<LinkingTable> GetAllClassMasterClassroomLinks()
        {
            return linkingTablesDAL.GetAllClassMasterClassroomLinks();
        }

        public void AddClassMasterClassroomLink(LinkingTable classMasterClassroomLink)
        {
            if (classMasterClassroomLink != null)
            {
                bool found = false;
                foreach (LinkingTable item in ClassMasterClassroomLinks)
                {
                    if (item.ID1 == classMasterClassroomLink.ID1)
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    ClassMasterClassroomLinks.Add(classMasterClassroomLink);
                    linkingTablesDAL.AddClassMasterClassroomLink(classMasterClassroomLink);
                }
                else
                {
                    MessageBox.Show("A teacher can be class master to a single classroom!");
                }
            }
            else
            {
                MessageBox.Show("Fill all parameters for class master - classroom link!");
            }
        }

        public void ModifyClassMasterClassroomLink(LinkingTable classMasterClassroomLink)
        {
            if (classMasterClassroomLink != null)
            {
                linkingTablesDAL.ModifyClassMasterClassroomLink(classMasterClassroomLink);
            }
            else
            {
                MessageBox.Show("Select a class master - classroom link!");
            }
        }

        public void DeleteClassMasterClassroomLink(LinkingTable classMasterClassroomLink)
        {
            if (classMasterClassroomLink != null)
            {
                ClassMasterClassroomLinks.Remove(classMasterClassroomLink);
                linkingTablesDAL.DeleteClassMasterClassroomLink(classMasterClassroomLink);
            }
            else
            {
                MessageBox.Show("Select a class master - classroom link!");
            }
        }

        public bool IsClassMaster(int teacherId)
        {
            return linkingTablesDAL.GetClassMasterClassroom(teacherId) != null;
        }

        public Classroom GetClassMasterClassroom(int teacherId)
        {
            return linkingTablesDAL.GetClassMasterClassroom(teacherId);
        }
    }
}
