using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef_sessies_en_validaties
{
    public partial class stap2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Stap2"] = "no";
            if (Session["Stap1"].ToString() != "ja" || Session["Stap2"].ToString() == "ja")
            {
                Response.Redirect("stap1.aspx");
            }

        }

        protected void continueButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["password"] = passwordTextBox.Text;
                Response.Redirect("stap3.aspx");
                Session["Stap2"] = "ja"; 

            }
        }
    }
}