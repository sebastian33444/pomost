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
        String a = elm1.InnerText;
        dokumenty d = new dokumenty();
        p.dokumenties.InsertOnSubmit(d);
        d.zawartość_dokumentu = a;
        d.data = DateTime.Now.Date;
        d.typ_dokumentu = RBLista.SelectedItem.Text; 
     
     
        foreach(petent pet in p.petents.Where(pet=>pet.pesel==LBPesel_petenta.SelectedItem.Text))
           {
            d.id_petent=pet.id_petent;
           }
        
        foreach(pracownik pra in p.pracowniks.Where(pra=>pra.login==LBLogin_pracownika.SelectedItem.Text))
        {
            d.id_pracownik=pra.id_pracownik;
        }
        p.SubmitChanges();
        
    }

   
}