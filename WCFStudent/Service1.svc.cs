using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFStudent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IStudent
    {
        List<vwStudent> IStudent.GetStudentList()
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    List<vwStudent> list = new List<vwStudent>();
                    list = (from x in context.vwStudents select x).ToList();
                    return list;
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
        
        vwStudent IStudent.AddStudent(vwStudent student)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    if(student.StudentID == 0)
                    {
                        tblStudent newStudent = new tblStudent();
                        newStudent.IndexNumber = student.IndexNumber;
                        newStudent.StudentName = student.StudentName;
                        newStudent.StudentSurname = student.StudentSurname;
                        newStudent.Adress = student.Adress;
                        newStudent.BirthDate = student.BirthDate;
                        newStudent.Sex = student.Sex;
                        context.tblStudents.Add(newStudent);
                        context.SaveChanges();
                        student.StudentID = newStudent.StudentID;
                        return student;
                    }
                    else
                    {
                        tblStudent studenttoEdit = (from s in context.tblStudents where s.StudentID == student.StudentID select s).First();
                        studenttoEdit.IndexNumber = student.IndexNumber;
                        studenttoEdit.StudentName = student.StudentName;
                        studenttoEdit.StudentSurname = student.StudentSurname;
                        studenttoEdit.Adress = student.Adress;
                        studenttoEdit.BirthDate = student.BirthDate;
                        studenttoEdit.Sex = student.Sex;
                        studenttoEdit.StudentID = student.StudentID;
                        context.SaveChanges();
                        return student;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        void IStudent.DeleteStudent(int StudentID)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    tblStudent studentToDelete = (from s in context.tblStudents where s.StudentID == StudentID select s).First();
                    context.tblStudents.Remove(studentToDelete);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return;
            }
        }

        vwStudent IStudent.GetOneStudent(int StudentID)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    vwStudent s1 = new vwStudent();
                    s1 = (from s in context.vwStudents where s.StudentID == StudentID select s).FirstOrDefault();
                    return s1;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }

        }

        int IStudent.GetStudentID(string StudentName)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    vwStudent s1 = new vwStudent();
                    s1 = (from s in context.vwStudents where s.StudentName == StudentName select s).FirstOrDefault();
                    return s1.StudentID;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return 0;
            }
        }

        

        //-------------------------------------------------------------------------------

        List<vwSubject> IStudent.GetSubjectList()
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    List<vwSubject> list = new List<vwSubject>();
                    list = (from x in context.vwSubjects select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        vwSubject IStudent.AddSubject(vwSubject subject)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    if (subject.SubjectID == 0)
                    {
                        tblSubject newSubject = new tblSubject();
                        newSubject.SubjectName = subject.SubjectName;
                        newSubject.Professor = subject.Professor;
                        newSubject.Semestre = subject.Semestre;
                        context.tblSubjects.Add(newSubject);
                        context.SaveChanges();
                        subject.SubjectID = newSubject.SubjectID;
                        return subject;
                    }
                    else
                    {
                        tblSubject subjecttoEdit = (from s in context.tblSubjects where s.SubjectID == subject.SubjectID select s).First();
                        subjecttoEdit.SubjectName = subject.SubjectName;
                        subjecttoEdit.Professor = subject.Professor;
                        subjecttoEdit.Semestre = subject.Semestre;
                        subjecttoEdit.SubjectID = subject.SubjectID;
                        context.SaveChanges();
                        return subject;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        void IStudent.DeleteSubject(int SubjectID)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    tblSubject subjectToDelete = (from s in context.tblSubjects where s.SubjectID == SubjectID select s).First();
                    context.tblSubjects.Remove(subjectToDelete);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return;
            }
        }

        vwSubject IStudent.GetOneSubject(int SubjectID)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    vwSubject s1 = new vwSubject();
                    s1 = (from s in context.vwSubjects where s.SubjectID == SubjectID select s).FirstOrDefault();
                    return s1;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        int IStudent.GetSubjectID(string SubjectName)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    vwSubject s1 = new vwSubject();
                    s1 = (from s in context.vwSubjects where s.SubjectName == SubjectName select s).FirstOrDefault();
                    return s1.SubjectID;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return 0;
            }
        }

        //-------------------------------------------------------------------------------

        int IStudent.GetResultID(string StudentName)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    vwResult s1 = new vwResult();
                    s1 = (from s in context.vwResults where s.StudentName == StudentName select s).FirstOrDefault();
                    return s1.ResultID;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return 0;
            }
        }

        List<vwResult> IStudent. GetResultList()
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    List<vwResult> list = new List<vwResult>();
                    list = (from x in context.vwResults select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        vwResult IStudent.AddResult(vwResult result)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {

                    if (result.ResultID == 0)
                    {
                        tblResult newResult = new tblResult();                       
                        newResult.Grade = result.Grade;
                        newResult.Date = result.Date;
                        newResult.StudentID = result.StudentID;
                        newResult.SubjectID = result.SubjectID;
                        newResult.SubjectName = result.SubjectName;
                        newResult.StudentName = result.StudentName;
                        context.tblResults.Add(newResult);
                        context.SaveChanges();
                        result.ResultID = newResult.ResultID;
                        return result;
                    }
                    else
                    {
                        tblResult resulttoEdit = (from s in context.tblResults where s.ResultID == result.ResultID select s).First();
                        resulttoEdit.ResultID = result.ResultID;
                        resulttoEdit.Grade = result.Grade;
                        resulttoEdit.Date = result.Date;
                        resulttoEdit.StudentID = result.StudentID;
                        resulttoEdit.SubjectID = result.SubjectID;
                        resulttoEdit.SubjectName = result.SubjectName;
                        resulttoEdit.StudentName = result.StudentName;
                        context.SaveChanges();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        void IStudent.DeleteResult(int ResultID)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    tblResult resultToDelete = (from s in context.tblResults where s.ResultID == ResultID select s).First();
                    context.tblResults.Remove(resultToDelete);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return;
            }
        }

        vwResult IStudent.GetOneResult(int ResultID)
        {
            try
            {
                using (StudentEntities context = new StudentEntities())
                {
                    vwResult s1 = new vwResult();
                    s1 = (from s in context.vwResults where s.ResultID == ResultID select s).FirstOrDefault();
                    return s1;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }




    }

    


}
