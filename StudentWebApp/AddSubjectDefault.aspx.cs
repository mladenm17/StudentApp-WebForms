using StudentWebApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApp
{
    public partial class AddSubjectDefault : System.Web.UI.Page
    {
        private vwSubject subject;
        public vwSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (StudentClient wcf = new StudentClient())
                {
                    List<vwSubject> slt = wcf.GetSubjectList().ToList();
                    GridView_SubjectList.DataSource = slt;
                    GridView_SubjectList.DataBind();
                }
            }
        }

        protected void GridView_SubjectList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            using (StudentClient wcf = new StudentClient())
            {
                GridView_SubjectList.PageIndex = e.NewPageIndex;
                List<vwSubject> slv = new List<vwSubject>();
                slv = wcf.GetSubjectList().ToList();
                GridView_SubjectList.DataSource = slv;
                GridView_SubjectList.DataBind();
            }
        }

        protected void GridView_SubjectList_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("Webform2: GridView_Results_RowCommand method:");

            GridView _gridView = (GridView)sender;
            string _commandName = e.CommandName;

            switch (_commandName)
            {
                case ("SingleClick"): GridViewRow row1 = (GridViewRow)((Control)e.CommandSource).NamingContainer;


                    int _selectIndex1 = row1.RowIndex;
                    _gridView.SelectedIndex = _selectIndex1;
                    GridView_SubjectList.SelectedIndex = row1.RowIndex;
                    break;
            }
        }

        protected void AddOnClick(object sender, EventArgs e)
        {
            Session["Subject"] = null;
            Response.Redirect("AddSubject.aspx");
        }

        protected void EditOnClick(object sender, EventArgs e)
        {
            vwSubject slv = new vwSubject();
            slv = null;
            foreach (GridViewRow r in GridView_SubjectList.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chb = r.FindControl("check") as CheckBox;
                    if (chb.Checked)
                    {
                        string strID = (r.FindControl("GridView_SubjectList_lblSubjectID") as Label).Text;
                        int i;
                        if (int.TryParse(strID, out i))
                        {
                            using (StudentClient wcf = new StudentClient())
                            {
                                slv = wcf.GetOneSubject(i);
                                if (slv != null)
                                {
                                    Session["Subject"] = slv;
                                    Response.Redirect("AddSubject.aspx");
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void DeleteOnClick(object sender, EventArgs e)
        {
            vwSubject slv = new vwSubject();
            slv = null;
            foreach (GridViewRow r in GridView_SubjectList.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chb = r.FindControl("check") as CheckBox;
                    if (chb.Checked)
                    {
                        string strID = (r.FindControl("GridView_SubjectList_lblSubjectID") as Label).Text;
                        int i;
                        if (int.TryParse(strID, out i))
                        {
                            using (StudentClient wcf = new StudentClient())
                            {
                                wcf.DeleteSubject(i);
                                Response.Redirect("AddSubjectDefault.aspx");
                            }
                        }
                    }
                }
            }
        }
    }
}