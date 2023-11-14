using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef_sessies_en_validaties
{
    public partial class stap3 : System.Web.UI.Page
    {
        /*   G*/
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void continueButton_Click(object sender, EventArgs e)
        {
            Session["nieuws"] = nieuwsbriefCheckBox.Checked;
            Response.Redirect("einde.aspx");
        }
    }
}