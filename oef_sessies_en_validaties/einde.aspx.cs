using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef_sessies_en_validaties
{

    public partial class einde : System.Web.UI.Page
    {
        /* Gebruiker Session = new Gebruiker();*/
        String Nieuws;
        protected void Page_Load(object sender, EventArgs e)
        {
            emailLabel.Text = Convert.ToString(Session["email"]) + "@" + Convert.ToString(Session["provider"]);
            wachtwoordLabel.Text = Convert.ToString(Session["password"]);
            if (Convert.ToBoolean(Session["nieuws"] = true))
            {
                 Nieuws = "ja";
            }
            else {  Nieuws = "nee"; }
            nieuwsbriefLabel.Text = Nieuws;
        }
    }
}