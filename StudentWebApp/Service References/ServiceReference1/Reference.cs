﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentWebApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vwStudent", Namespace="http://schemas.datacontract.org/2004/07/WCFStudent")]
    [System.SerializableAttribute()]
    public partial class vwStudent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IndexNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JMBGField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentSurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adress {
            get {
                return this.AdressField;
            }
            set {
                if ((object.ReferenceEquals(this.AdressField, value) != true)) {
                    this.AdressField = value;
                    this.RaisePropertyChanged("Adress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IndexNumber {
            get {
                return this.IndexNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.IndexNumberField, value) != true)) {
                    this.IndexNumberField = value;
                    this.RaisePropertyChanged("IndexNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JMBG {
            get {
                return this.JMBGField;
            }
            set {
                if ((object.ReferenceEquals(this.JMBGField, value) != true)) {
                    this.JMBGField = value;
                    this.RaisePropertyChanged("JMBG");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentSurname {
            get {
                return this.StudentSurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentSurnameField, value) != true)) {
                    this.StudentSurnameField = value;
                    this.RaisePropertyChanged("StudentSurname");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vwSubject", Namespace="http://schemas.datacontract.org/2004/07/WCFStudent")]
    [System.SerializableAttribute()]
    public partial class vwSubject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProfessorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SemestreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubjectIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Professor {
            get {
                return this.ProfessorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfessorField, value) != true)) {
                    this.ProfessorField = value;
                    this.RaisePropertyChanged("Professor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Semestre {
            get {
                return this.SemestreField;
            }
            set {
                if ((object.ReferenceEquals(this.SemestreField, value) != true)) {
                    this.SemestreField = value;
                    this.RaisePropertyChanged("Semestre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubjectID {
            get {
                return this.SubjectIDField;
            }
            set {
                if ((this.SubjectIDField.Equals(value) != true)) {
                    this.SubjectIDField = value;
                    this.RaisePropertyChanged("SubjectID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectName {
            get {
                return this.SubjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectNameField, value) != true)) {
                    this.SubjectNameField = value;
                    this.RaisePropertyChanged("SubjectName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vwResult", Namespace="http://schemas.datacontract.org/2004/07/WCFStudent")]
    [System.SerializableAttribute()]
    public partial class vwResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Expr1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Expr2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResultIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SubjectIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Expr1 {
            get {
                return this.Expr1Field;
            }
            set {
                if ((this.Expr1Field.Equals(value) != true)) {
                    this.Expr1Field = value;
                    this.RaisePropertyChanged("Expr1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Expr2 {
            get {
                return this.Expr2Field;
            }
            set {
                if ((this.Expr2Field.Equals(value) != true)) {
                    this.Expr2Field = value;
                    this.RaisePropertyChanged("Expr2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((object.ReferenceEquals(this.GradeField, value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResultID {
            get {
                return this.ResultIDField;
            }
            set {
                if ((this.ResultIDField.Equals(value) != true)) {
                    this.ResultIDField = value;
                    this.RaisePropertyChanged("ResultID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SubjectID {
            get {
                return this.SubjectIDField;
            }
            set {
                if ((this.SubjectIDField.Equals(value) != true)) {
                    this.SubjectIDField = value;
                    this.RaisePropertyChanged("SubjectID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectName {
            get {
                return this.SubjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectNameField, value) != true)) {
                    this.SubjectNameField = value;
                    this.RaisePropertyChanged("SubjectName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IStudent")]
    public interface IStudent {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetStudentList", ReplyAction="http://tempuri.org/IStudent/GetStudentListResponse")]
        StudentWebApp.ServiceReference1.vwStudent[] GetStudentList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetStudentList", ReplyAction="http://tempuri.org/IStudent/GetStudentListResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwStudent[]> GetStudentListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetStudentID", ReplyAction="http://tempuri.org/IStudent/GetStudentIDResponse")]
        int GetStudentID(string StudentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetStudentID", ReplyAction="http://tempuri.org/IStudent/GetStudentIDResponse")]
        System.Threading.Tasks.Task<int> GetStudentIDAsync(string StudentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddStudent", ReplyAction="http://tempuri.org/IStudent/AddStudentResponse")]
        StudentWebApp.ServiceReference1.vwStudent AddStudent(StudentWebApp.ServiceReference1.vwStudent student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddStudent", ReplyAction="http://tempuri.org/IStudent/AddStudentResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwStudent> AddStudentAsync(StudentWebApp.ServiceReference1.vwStudent student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteStudent", ReplyAction="http://tempuri.org/IStudent/DeleteStudentResponse")]
        void DeleteStudent(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteStudent", ReplyAction="http://tempuri.org/IStudent/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetOneStudent", ReplyAction="http://tempuri.org/IStudent/GetOneStudentResponse")]
        StudentWebApp.ServiceReference1.vwStudent GetOneStudent(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetOneStudent", ReplyAction="http://tempuri.org/IStudent/GetOneStudentResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwStudent> GetOneStudentAsync(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetSubjectList", ReplyAction="http://tempuri.org/IStudent/GetSubjectListResponse")]
        StudentWebApp.ServiceReference1.vwSubject[] GetSubjectList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetSubjectList", ReplyAction="http://tempuri.org/IStudent/GetSubjectListResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwSubject[]> GetSubjectListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetSubjectID", ReplyAction="http://tempuri.org/IStudent/GetSubjectIDResponse")]
        int GetSubjectID(string SubjectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetSubjectID", ReplyAction="http://tempuri.org/IStudent/GetSubjectIDResponse")]
        System.Threading.Tasks.Task<int> GetSubjectIDAsync(string SubjectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddSubject", ReplyAction="http://tempuri.org/IStudent/AddSubjectResponse")]
        StudentWebApp.ServiceReference1.vwSubject AddSubject(StudentWebApp.ServiceReference1.vwSubject subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddSubject", ReplyAction="http://tempuri.org/IStudent/AddSubjectResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwSubject> AddSubjectAsync(StudentWebApp.ServiceReference1.vwSubject subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteSubject", ReplyAction="http://tempuri.org/IStudent/DeleteSubjectResponse")]
        void DeleteSubject(int SubjectID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteSubject", ReplyAction="http://tempuri.org/IStudent/DeleteSubjectResponse")]
        System.Threading.Tasks.Task DeleteSubjectAsync(int SubjectID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetOneSubject", ReplyAction="http://tempuri.org/IStudent/GetOneSubjectResponse")]
        StudentWebApp.ServiceReference1.vwSubject GetOneSubject(int SubjectID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetOneSubject", ReplyAction="http://tempuri.org/IStudent/GetOneSubjectResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwSubject> GetOneSubjectAsync(int SubjectID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetResultList", ReplyAction="http://tempuri.org/IStudent/GetResultListResponse")]
        StudentWebApp.ServiceReference1.vwResult[] GetResultList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetResultList", ReplyAction="http://tempuri.org/IStudent/GetResultListResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwResult[]> GetResultListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetResultID", ReplyAction="http://tempuri.org/IStudent/GetResultIDResponse")]
        int GetResultID(string ResultID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetResultID", ReplyAction="http://tempuri.org/IStudent/GetResultIDResponse")]
        System.Threading.Tasks.Task<int> GetResultIDAsync(string ResultID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddResult", ReplyAction="http://tempuri.org/IStudent/AddResultResponse")]
        StudentWebApp.ServiceReference1.vwResult AddResult(StudentWebApp.ServiceReference1.vwResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddResult", ReplyAction="http://tempuri.org/IStudent/AddResultResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwResult> AddResultAsync(StudentWebApp.ServiceReference1.vwResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteResult", ReplyAction="http://tempuri.org/IStudent/DeleteResultResponse")]
        void DeleteResult(int ResultID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteResult", ReplyAction="http://tempuri.org/IStudent/DeleteResultResponse")]
        System.Threading.Tasks.Task DeleteResultAsync(int ResultID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetOneResult", ReplyAction="http://tempuri.org/IStudent/GetOneResultResponse")]
        StudentWebApp.ServiceReference1.vwResult GetOneResult(int ResultID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetOneResult", ReplyAction="http://tempuri.org/IStudent/GetOneResultResponse")]
        System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwResult> GetOneResultAsync(int ResultID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentChannel : StudentWebApp.ServiceReference1.IStudent, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentClient : System.ServiceModel.ClientBase<StudentWebApp.ServiceReference1.IStudent>, StudentWebApp.ServiceReference1.IStudent {
        
        public StudentClient() {
        }
        
        public StudentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StudentWebApp.ServiceReference1.vwStudent[] GetStudentList() {
            return base.Channel.GetStudentList();
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwStudent[]> GetStudentListAsync() {
            return base.Channel.GetStudentListAsync();
        }
        
        public int GetStudentID(string StudentName) {
            return base.Channel.GetStudentID(StudentName);
        }
        
        public System.Threading.Tasks.Task<int> GetStudentIDAsync(string StudentName) {
            return base.Channel.GetStudentIDAsync(StudentName);
        }
        
        public StudentWebApp.ServiceReference1.vwStudent AddStudent(StudentWebApp.ServiceReference1.vwStudent student) {
            return base.Channel.AddStudent(student);
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwStudent> AddStudentAsync(StudentWebApp.ServiceReference1.vwStudent student) {
            return base.Channel.AddStudentAsync(student);
        }
        
        public void DeleteStudent(int StudentID) {
            base.Channel.DeleteStudent(StudentID);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(int StudentID) {
            return base.Channel.DeleteStudentAsync(StudentID);
        }
        
        public StudentWebApp.ServiceReference1.vwStudent GetOneStudent(int StudentID) {
            return base.Channel.GetOneStudent(StudentID);
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwStudent> GetOneStudentAsync(int StudentID) {
            return base.Channel.GetOneStudentAsync(StudentID);
        }
        
        public StudentWebApp.ServiceReference1.vwSubject[] GetSubjectList() {
            return base.Channel.GetSubjectList();
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwSubject[]> GetSubjectListAsync() {
            return base.Channel.GetSubjectListAsync();
        }
        
        public int GetSubjectID(string SubjectName) {
            return base.Channel.GetSubjectID(SubjectName);
        }
        
        public System.Threading.Tasks.Task<int> GetSubjectIDAsync(string SubjectName) {
            return base.Channel.GetSubjectIDAsync(SubjectName);
        }
        
        public StudentWebApp.ServiceReference1.vwSubject AddSubject(StudentWebApp.ServiceReference1.vwSubject subject) {
            return base.Channel.AddSubject(subject);
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwSubject> AddSubjectAsync(StudentWebApp.ServiceReference1.vwSubject subject) {
            return base.Channel.AddSubjectAsync(subject);
        }
        
        public void DeleteSubject(int SubjectID) {
            base.Channel.DeleteSubject(SubjectID);
        }
        
        public System.Threading.Tasks.Task DeleteSubjectAsync(int SubjectID) {
            return base.Channel.DeleteSubjectAsync(SubjectID);
        }
        
        public StudentWebApp.ServiceReference1.vwSubject GetOneSubject(int SubjectID) {
            return base.Channel.GetOneSubject(SubjectID);
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwSubject> GetOneSubjectAsync(int SubjectID) {
            return base.Channel.GetOneSubjectAsync(SubjectID);
        }
        
        public StudentWebApp.ServiceReference1.vwResult[] GetResultList() {
            return base.Channel.GetResultList();
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwResult[]> GetResultListAsync() {
            return base.Channel.GetResultListAsync();
        }
        
        public int GetResultID(string ResultID) {
            return base.Channel.GetResultID(ResultID);
        }
        
        public System.Threading.Tasks.Task<int> GetResultIDAsync(string ResultID) {
            return base.Channel.GetResultIDAsync(ResultID);
        }
        
        public StudentWebApp.ServiceReference1.vwResult AddResult(StudentWebApp.ServiceReference1.vwResult result) {
            return base.Channel.AddResult(result);
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwResult> AddResultAsync(StudentWebApp.ServiceReference1.vwResult result) {
            return base.Channel.AddResultAsync(result);
        }
        
        public void DeleteResult(int ResultID) {
            base.Channel.DeleteResult(ResultID);
        }
        
        public System.Threading.Tasks.Task DeleteResultAsync(int ResultID) {
            return base.Channel.DeleteResultAsync(ResultID);
        }
        
        public StudentWebApp.ServiceReference1.vwResult GetOneResult(int ResultID) {
            return base.Channel.GetOneResult(ResultID);
        }
        
        public System.Threading.Tasks.Task<StudentWebApp.ServiceReference1.vwResult> GetOneResultAsync(int ResultID) {
            return base.Channel.GetOneResultAsync(ResultID);
        }
    }
}