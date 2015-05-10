using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dokumenty_Edycja : System.Web.UI.Page
{
    PolaczenieDataContext p = new PolaczenieDataContext();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        string b;
        b = Request["zmienna"];
       // Response.Write(Request["zmienna"]); // id_dok, id_pet, log_prac
        string[] tab = b.Split(new char[] { ' ' });
       
        foreach(dokumenty d in p.dokumenties.Where(d=>d.id_dokumentu==Convert.ToInt32(tab[0])))
         {
        elm1.InnerText = d.zawartość_dokumentu;
        RBLista.Items.FindByText(d.typ_dokumentu).Selected=true;     
              
        }

    }


    protected void BZapisz_do_bazy_Click(object sender, EventArgs e)
    {
        string b;
        b = Request["zmienna"];
        string[] tab = b.Split(new char[] { ' ' });
       

        string a = elm1.InnerText;
        foreach (dokumenty d in p.dokumenties.Where(d => d.id_dokumentu == Convert.ToInt32(tab[0])))
        {            
            d.zawartość_dokumentu = a;
            d.data = DateTime.Now.Date;
            d.typ_dokumentu = RBLista.SelectedItem.Text;
                        
        }

        p.SubmitChanges();
    }
}