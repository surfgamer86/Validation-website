using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef_sessies_en_validaties
{
    public partial class stap1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Stap1"] = "no";
        }

        protected void continueButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["email"] = emailTextbox.Text;
                Session["provider"] = DropDownList1.SelectedValue;
                Session["Stap1"] = "ja";
                Response.Redirect("stap2.aspx");
            }
        }
    }
}