using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpdateDiagnosticCenterBillMangementSoftware
{
    public partial class SideBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void typeButton_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/TypeSetup.aspx");
        }
    }
}