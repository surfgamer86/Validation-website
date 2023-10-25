using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Gebruiker
/// </summary>
public class Gebruiker
{
    //velden
    String _naam;
    String _provider;
    String _wachtwoord;
    bool _nieuwsbrief;
	public Gebruiker(string naam, string wachtwoord, string provider, bool nieuwsbrief)
	{
		// Add constructor logic here
        _naam = naam;
        _wachtwoord = wachtwoord;
        _provider = provider;
        _nieuwsbrief = nieuwsbrief;
	}
   
    public String Naam 
       { 
        get{return _naam;}
        set { _naam = value; } 
        }
    public String Provider
    {
        get { return _provider; }
        set { _provider = value; }
    }
    public String Wachtwoord
    {
        get { return _wachtwoord; }
        set { _wachtwoord = value; }
    }
    public bool Nieuwsbrief
    {
        get { return _nieuwsbrief; }
        set { _nieuwsbrief = value; }
    }
    private String VolledigeNaam()
    {
        List<String> delen = new List<String>();
        String deel="";
        String geheel = "";
        for(int i=0;i<_naam.Length;i++)
        {
            String letter;
           
            letter = _naam.Substring(i, 1);
            if (!letter.Equals(" "))
            {
                deel += letter;
            }
            else
            {
                delen.Add(deel);
                deel = "";
            }
        }
        if (!deel.Equals(""))
        {
            delen.Add(deel);
        }
        foreach (String d in delen)
        {
            geheel += d+'.';
        }
        geheel = geheel.Substring(0, geheel.Length - 1);
        return geheel;
    }
    public String VormMailadres()
    {
        //mailadres
        return VolledigeNaam() + "@" + _provider;
    }
    public String KeuzeNieuwsbrief()
    {
        if(_nieuwsbrief==true)
        {
            return "ja";
        }
        else
        {
            return "nee";
        }
    }
    public string getWachtwoord()
    {
        return Wachtwoord;
    }
}