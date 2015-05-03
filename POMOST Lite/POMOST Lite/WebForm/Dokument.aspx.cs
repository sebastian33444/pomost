using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;


public partial class Dokument : System.Web.UI.Page
{

    PolaczenieDataContext p = new PolaczenieDataContext();
    string[] tab;

    protected void Page_Load(object sender, EventArgs e)
    {
       
    
    }
    

    protected void BZapisz_do_bazy_Click(object sender, EventArgs e)
    {  
        string b;
        b = Request["zmienna"];
        string[] tab = b.Split(new char[] { ' ' });
     

        String a = elm1.InnerText;
        dokumenty d = new dokumenty();
        p.dokumenties.InsertOnSubmit(d);
        d.zawartość_dokumentu = a;
        d.data = DateTime.Now.Date;
        d.typ_dokumentu = RBLista.SelectedItem.Text;
        d.id_petent = Convert.ToInt32(tab[0]);
       
        foreach(pracownik pra in p.pracowniks.Where(pra=>pra.login==tab[1] ))
        {
            d.id_pracownik=pra.id_pracownik;
        }
        p.SubmitChanges();
        
        
    }

   
}