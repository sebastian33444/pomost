using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;

public partial class Dokumenty_Edycja : System.Web.UI.Page
{
    PolaczenieDataContext p = new PolaczenieDataContext();
    string x, y;

    protected void Page_Load(object sender, EventArgs e)
    {

        string b;
        b = Request["zmienna"];
        x = elm2.InnerText;
        y = RBLista.SelectedItem.Text;

        foreach (dokumenty d in p.dokumenties.Where(d => d.id_dokumentu == Convert.ToInt32(b)))
        {
            elm2.InnerText = d.zawartość_dokumentu;
            RBLista.Items.FindByText(d.typ_dokumentu).Selected = true;
        }
    }


    protected void BZapisz_do_bazy_Click(object sender, EventArgs e)
    {

        string b;
        b = Request["zmienna"];


        string a = elm2.InnerText;
        foreach (dokumenty d in p.dokumenties.Where(d => d.id_dokumentu == Convert.ToInt32(b)))
        {
            d.zawartość_dokumentu = x;
            d.data = DateTime.Now.Date;
            d.typ_dokumentu = y;

        }

        p.SubmitChanges();


    }
}