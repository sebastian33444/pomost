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
  
    protected void Page_Load(object sender, EventArgs e)
    {
       
    
    }
    

    protected void BZapisz_do_bazy_Click(object sender, EventArgs e)
    {
        string b, c;
        c = Request["zmienna"];
        b = Request["zmienna2"];
        string a = elm1.InnerText;
        dokumenty d = new dokumenty();
        p.dokumenties.InsertOnSubmit(d);
        d.zawartość_dokumentu = a;
        d.data = DateTime.Now.Date;
        d.typ_dokumentu = RBLista.SelectedItem.Text;
        d.id_petent = Convert.ToInt32(c);

        foreach (pracownik pra in p.pracowniks.Where(pra => pra.login == b))
        {
            d.id_pracownik = pra.id_pracownik;
        }
        p.SubmitChanges();
        
        
        
    }

   
}