using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFStudent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {

        [OperationContract]
        List<vwStudent> GetStudentList();

        [OperationContract]
        int GetStudentID(string StudentName);       

        [OperationContract]
        vwStudent AddStudent(vwStudent student);

        [OperationContract]
        void DeleteStudent(int StudentID);

        [OperationContract]
        vwStudent GetOneStudent(int StudentID);

        //-----------

        [OperationContract]
        List<vwSubject> GetSubjectList();

        [OperationContract]
        int GetSubjectID(string SubjectName);

        [OperationContract]
        vwSubject AddSubject(vwSubject subject);

        [OperationContract]
        void DeleteSubject(int SubjectID);

        [OperationContract]
        vwSubject GetOneSubject(int SubjectID);

        //-----------

        [OperationContract]
        List<vwResult> GetResultList();

        [OperationContract]
        int GetResultID(string ResultID);

        [OperationContract]
        vwResult AddResult(vwResult result);

        [OperationContract]
        void DeleteResult(int ResultID);

        [OperationContract]
        vwResult GetOneResult(int ResultID);

        // TODO: Add your service operations here
    }


}