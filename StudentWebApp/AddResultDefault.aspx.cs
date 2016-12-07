using StudentWebApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApp
{
    public partial class AddResultDefault : System.Web.UI.Page
    {
        private vwResult result;
        public vwResult Result
        {
            get { return result; }
            set { result = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                using (StudentClient wcf = new StudentClient())
                {
                    List<vwResult> slt = wcf.GetResultList().ToList();
                    GridView_ResultList.DataSource = slt;
                    GridView_ResultList.DataBind();
                }
            }
        }

        protected void GridView_ResultList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            using (StudentClient wcf = new StudentClient())
            {
                GridView_ResultList.PageIndex = e.NewPageIndex;
                List<vwResult> slv = new List<vwResult>();
                slv = wcf.GetResultList().ToList();
                GridView_ResultList.DataSource = slv;
                GridView_ResultList.DataBind();
            }
        }

        protected void GridView_ResultList_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("Webform2: GridView_Results_RowCommand method:");

            GridView _gridView = (GridView)sender;
            string _commandName = e.CommandName;

            switch (_commandName)
            {
                case ("SingleClick"): GridViewRow row1 = (GridViewRow)((Control)e.CommandSource).NamingContainer;


                    int _selectIndex1 = row1.RowIndex;
                    _gridView.SelectedIndex = _selectIndex1;
                    GridView_ResultList.SelectedIndex = row1.RowIndex;
                    break;
            }
        }

        protected void AddOnClick(object sender, EventArgs e)
        {
            Session["Result"] = null;
            Response.Redirect("AddResult.aspx");
        }

        protected void EditOnClick(object sender, EventArgs e)
        {
            vwResult slv = new vwResult();
            slv = null;
            foreach (GridViewRow r in GridView_ResultList.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chb = r.FindControl("check") as CheckBox;
                    if (chb.Checked)
                    {
                        string strID = (r.FindControl("GridView_ResultList_lblResultID") as Label).Text;
                        int i;
                        if (int.TryParse(strID, out i))
                        {
                            using (StudentClient wcf = new StudentClient())
                            {
                                slv = wcf.GetOneResult(i);
                                if (slv != null)
                                {
                                    Session["Result"] = slv;
                                    Response.Redirect("AddResult.aspx");
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void DeleteOnClick(object sender, EventArgs e)
        {
            vwResult slv = new vwResult();
            slv = null;
            foreach (GridViewRow r in GridView_ResultList.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chb = r.FindControl("check") as CheckBox;
                    if (chb.Checked)
                    {
                        string strID = (r.FindControl("GridView_ResultList_lblResultID") as Label).Text;
                        int i;
                        if (int.TryParse(strID, out i))
                        {
                            using (StudentClient wcf = new StudentClient())
                            {
                                wcf.DeleteResult(i);
                                Response.Redirect("AddResultDefault.aspx");
                            }
                        }
                    }
                }
            }
        }
    }
}