using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpdateDiagnosticCenterBillMangementSoftware.BLL;
using UpdateDiagnosticCenterBillMangementSoftware.Model;

namespace UpdateDiagnosticCenterBillMangementSoftware.UI
{
    public partial class TypeSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TypeManager aTypeManager = new TypeManager();
            if (!IsPostBack)
            {
                List<TypeClass> aList = new List<TypeClass>();
                aList = aTypeManager.GetAllType();
                showGridView.DataSource = aList;
                showGridView.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            TypeManager aTypeManager = new TypeManager();
            

            if (aTypeManager.GetInfoByTypeName(typeNameTb.Text) != null)
            {
                messageLabel.Text = "Sorry! This Type Name Already Exist";
                messageLabel.ForeColor = Color.DarkRed;
                ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + messageLabel.ClientID + "').style.display='none'\",3000)</script>");


            }
            else
            {
                TypeClass aTypeClass = new TypeClass();
                aTypeClass.Name = typeNameTb.Text;
                aTypeClass.Date = DateTime.Now.ToString();
                int rowAffected = aTypeManager.SaveType(aTypeClass);
                if (rowAffected > 0)
                {
                    messageLabel.Text = "Save Successfully";
                    messageLabel.ForeColor = Color.Green;
                    typeNameTb.Text = string.Empty;
                    ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + messageLabel.ClientID + "').style.display='none'\",3000)</script>");

                    showGridView.DataSource = aTypeManager.GetAllType();
                    showGridView.DataBind();
                }
                else
                {
                    messageLabel.Text = "Opps! Save Failed";
                    messageLabel.ForeColor = Color.Red;
                    ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", "<script type=\"text/javascript\">setTimeout(\"document.getElementById('" + messageLabel.ClientID + "').style.display='none'\",3000)</script>");
                }
            }
        }

        //protected void UpdateTimer_Tick(object sender, EventArgs e)
        //{
        //    DateStampLabel.Text = DateTime.Now.ToString();
        //}
    }
}