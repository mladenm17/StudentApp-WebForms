using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentWebApp.ServiceReference1;

namespace StudentWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                using (StudentClient wcf = new StudentClient())
                {
                    List<vwStudent> slt = wcf.GetStudentList().ToList();
                    GridView_StudentList.DataSource = slt;
                    GridView_StudentList.DataBind();
                }
            }
        }

        protected void GridView_StudentList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            using (StudentClient wcf = new StudentClient())
            {
                GridView_StudentList.PageIndex = e.NewPageIndex;
                List<vwStudent> slv = new List<vwStudent>();
                slv = wcf.GetStudentList().ToList();
                GridView_StudentList.DataSource = slv;
                GridView_StudentList.DataBind();
            }
        }

        protected void GridView_StudentList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          
            System.Diagnostics.Debug.WriteLine("Webform2: GridView_Results_RowCommand method:");

            GridView _gridView = (GridView)sender;
            string _commandName = e.CommandName;

            switch (_commandName)
            {
                case ("SingleClick"): GridViewRow row1 = (GridViewRow)((Control)e.CommandSource).NamingContainer;


                    int _selectIndex1 = row1.RowIndex;
                    _gridView.SelectedIndex = _selectIndex1;
                    GridView_StudentList.SelectedIndex = row1.RowIndex;
                    break;
            }            
        }
        private vwStudent student;
        public vwStudent Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }

        protected void AddOnClick(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }

        protected void EditOnClick(object sender, EventArgs e)
        {
            vwStudent slv = new vwStudent();
            slv = null;
            foreach(GridViewRow r in GridView_StudentList.Rows)
            {
                if(r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chb = r.FindControl("chek") as CheckBox;
                    if(chb.Checked)
                    { 
                        string strID = (r.FindControl("GridView_StudentList_lblStudentID") as Label).Text;
                    int i;
                    if(int.TryParse(strID, out i))
                    {
                        using (StudentClient wcf = new StudentClient())
                        {
                            slv = wcf.GetOneStudent(i);
                            if(slv != null)
                            {
                                Session["Student"] = slv;
                                Response.Redirect("AddStudent.aspx");
                            }
                        }
                    }
                    }
                }
            }
        }

        protected void DeleteOnClick(object sender, EventArgs e)
        {
            vwStudent slv = new vwStudent();
            slv = null;
            foreach(GridViewRow r in GridView_StudentList.Rows)
            {
                if(r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chb = r.FindControl("chek") as CheckBox;
                    if(chb.Checked)
                    {
                        string strID = (r.FindControl("GridView_StudentList_lblStudentID") as Label).Text;
                        int i;
                        if (int.TryParse(strID, out i))
                        {
                            using (StudentClient wcf = new StudentClient())
                            {
                                wcf.DeleteStudent(i);
                                Response.Redirect("Default.aspx");
                            }
                        }
                    }
                }
            }
        }

        protected void AddSubjectDefault(object sender, EventArgs e)
        {
            Response.Redirect("AddSubjectDefault.aspx");
        }

        protected void AddResultDefault(object sender, EventArgs e)
        {
            Response.Redirect("AddResultDefault.aspx");
        }


    }
}