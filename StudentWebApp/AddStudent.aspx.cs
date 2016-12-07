using StudentWebApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApp
{
    public partial class AddStudent : System.Web.UI.Page
    {
        private vwStudent student = new vwStudent();
        public vwStudent Student
        {
            get { return student; }
            set { student = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                calendar1.Visible = false;
                if(Session["Student"] != null)
                {
                    Student = (vwStudent)Session["Student"];
                    
                    txtID.Text = Convert.ToString(student.StudentID);
                    txtStudentName.Text = student.StudentName;
                    txtStudentSurname.Text = student.StudentSurname;
                    txtIndexNumber.Text = student.IndexNumber;
                    txtAdress.Text = student.Adress;
                    txtBirthDate.Text = Convert.ToString(student.BirthDate);
                    txtSex.Text = student.Sex;
                }
            }  
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(calendar1.Visible == false)
            {
                calendar1.Visible = true;
            }
            else
            {
                calendar1.Visible = false;
            }
        }

        

        protected void calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtBirthDate.Text = calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnSaveClick(object sender, EventArgs e)
        {
            using(StudentClient wcf = new StudentClient())
            {
                student.StudentID = Convert.ToInt32(txtID.Text);
                student.StudentName = txtStudentName.Text;
                student.StudentSurname = txtStudentSurname.Text;
                student.IndexNumber = txtIndexNumber.Text;
                student.Adress = txtAdress.Text;
                student.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
                student.Sex = txtSex.Text;
                wcf.AddStudent(student);
            }
            Response.Redirect("Default.aspx");
        }
    }
}