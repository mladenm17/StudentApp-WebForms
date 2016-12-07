using StudentWebApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApp
{
    public partial class AddSubject : System.Web.UI.Page
    {
        private vwSubject subject = new vwSubject();
         public vwSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Session["Subject"] != null)
                {
                    subject = (vwSubject)Session["Subject"];
                    txtSubjectID.Text = Convert.ToString(subject.SubjectID);
                    txtSubjectName.Text = subject.SubjectName;
                    txtProfessor.Text = subject.Professor;
                    txtSemestre.Text = subject.Semestre;
                }
            }  
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (StudentClient wcf = new StudentClient())
            {
                subject.SubjectID = Convert.ToInt32(txtSubjectID.Text);
                subject.SubjectName = txtSubjectName.Text;
                subject.Professor = txtProfessor.Text;
                subject.Semestre = txtSemestre.Text;

                wcf.AddSubject(subject);
            }
            Response.Redirect("AddSubjectDefault.aspx");
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }

        protected void btnAddSubject_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSubject.aspx");
        }
    }
}