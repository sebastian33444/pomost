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
        foreach (dokumenty d in p.dokumenties.Where(d => d.id_dokumentu == 1))
        {
            d.data = DateTime.Now.Date;

        }

    }
    

    protected void BZapisz_do_bazy_Click(object sender, EventArgs e)
    {
       String a = elm1.InnerText;
       TextBox1.Text = a;
  foreach(dokumenty d in p.dokumenties.Where(d=>d.id_dokumentu==1)) 
  {
      d.zawartość_dokumentu = a;      
  }
  p.SubmitChanges();

    }
}