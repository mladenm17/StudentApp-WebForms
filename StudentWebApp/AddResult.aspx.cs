using StudentWebApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApp
{
    public partial class AddResult : System.Web.UI.Page
    {
        private vwResult result = new vwResult();
        public vwResult Result
        {
            get { return result; }
            set { result = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                calendar2.Visible = false;
                using (StudentClient wcf = new StudentClient())
                {
                    
                    dropStudentName.DataSource = wcf.GetStudentList();
                    dropStudentName.DataBind();
                   
                    dropSubjectName.DataSource = wcf.GetSubjectList();
                    dropSubjectName.DataBind();
                   
                }

                if(Session["Result"] != null)
                {
                    vwResult result = (vwResult)Session["Result"];
                    txtResultID.Text = Convert.ToString(result.ResultID);
                    txtGrade.Text = result.Grade.ToString();                   
                    dropStudentName.Items.FindByText(result.StudentName).Selected = true;
                    dropSubjectName.Items.FindByText(result.SubjectName).Selected = true;
                    txtDate.Text = Convert.ToString(result.Date);
                }
            }  
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (calendar2.Visible == false)
            {
                calendar2.Visible = true;
            }
            else
            {
                calendar2.Visible = false;
            }
        }



        protected void calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = calendar2.SelectedDate.ToShortDateString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (StudentClient wcf = new StudentClient())
            {
                vwResult result = new vwResult();
                result.ResultID = Convert.ToInt32(txtResultID.Text);
                result.StudentName = dropStudentName.SelectedItem.ToString();
                result.StudentID = wcf.GetStudentID(result.StudentName);
                result.SubjectName = dropSubjectName.SelectedItem.ToString();
                result.SubjectID = wcf.GetSubjectID(result.SubjectName);
                result.Grade = txtGrade.Text;
                result.Date = Convert.ToDateTime(txtDate.Text);
                wcf.AddResult(result);
            }
            Session.Clear();
            Response.Redirect("AddResultDefault.aspx");
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