using System;

namespace oef_sessies_en_validaties
{

    public partial class einde : System.Web.UI.Page
    {
        
         
        String Nieuws;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            _Nieuwegebruiker = new Gebruiker(Session["email"].ToString(), Session["passwoord"].ToString(), Session["provider"].ToString(),Convert.ToBoolean(Session["nieuws"]));
            emailLabel.Text = Convert.ToString(Session["email"]) + "@" + Convert.ToString(Session["provider"]);
            wachtwoordLabel.Text = Convert.ToString(Session["password"]);
            if (Convert.ToBoolean(Session["nieuws"] = true))
            {
                Nieuws = "ja";
            }
            else { Nieuws = "nee"; }
            nieuwsbriefLabel.Text = Nieuws;
        }
    }
}