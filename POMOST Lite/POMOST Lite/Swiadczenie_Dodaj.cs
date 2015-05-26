using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POMOST_Lite
{
    public partial class Swiadczenie_Dodaj : Form
    {
        private bool czydodac;
        private bool petentOrDok;
        private string zaznaczone_swiad;
        private string zaznaczony_dok;
        private string zaznacz;
        DataClassesDataContext baza = new DataClassesDataContext();


        public Swiadczenie_Dodaj(string zaznaczone_swiad, string zaznaczony_dok, bool czydodac, bool swiadOrDok, string zazancz)
        {
            InitializeComponent();
            this.zaznaczone_swiad = zaznaczone_swiad;
            this.zaznaczony_dok = zaznaczony_dok;
            this.czydodac = czydodac;
            this.petentOrDok = swiadOrDok;
            this.zaznacz = zazancz;
            cbSwiadczenie.Items.Add("zwrot");
            cbSwiadczenie.Items.Add("wydanie");
            if(czydodac == false)
            { 
            foreach (świadczenie s in baza.świadczenies.Where(s => s.id_świadczenia == Convert.ToInt32(zaznaczone_swiad)))
            {
                tbKwota.Text = s.kwota.ToString();
                cbSwiadczenie.Text = s.operacja;
                monthCalendar1.SelectionStart = s.data;
            }
            }
            if(petentOrDok == true)
            {
                cbDokument.Items.Add(zaznaczony_dok);
            }
            else if(petentOrDok == false)
            {
               foreach(dokumenty dok in  baza.dokumenties.Where(dok => dok.id_petent == Convert.ToInt32(zazancz)))
               {
                   cbDokument.Items.Add(dok.id_dokumentu);
               }
            }
        }
                
        private void Swiadczenie_Load(object sender, EventArgs e)
        {
            this.świadczenieTableAdapter.Fill(this.mopsDataSet.świadczenie);
            this.dokumentyTableAdapter.Fill(this.mopsDataSet.dokumenty);
            this.cbDokument.Text = null;
            this.cbDokument.Text = zaznaczony_dok;
        }

        private void bAnuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bZapisz_Click(object sender, EventArgs e)
        {
           if (czydodac == true)
              {
                try
                {
                    świadczenie swiad = new świadczenie();
                    swiad.kwota = Convert.ToDecimal(tbKwota.Text);
                    swiad.operacja = cbSwiadczenie.Text;
                    swiad.data = monthCalendar1.SelectionStart;
                    swiad.id_dokumentu = Convert.ToInt32(cbDokument.Text);
                    baza.świadczenies.InsertOnSubmit(swiad);
                    baza.SubmitChanges();
                    Close();
                    this.świadczenieTableAdapter.Fill(this.mopsDataSet.świadczenie);
                    this.Hide();
                }
                catch
                {
                   MessageBox.Show("Bład");
                }
        }
            else
            {
                foreach (świadczenie s in baza.świadczenies.Where(s => s.id_świadczenia == Convert.ToInt32(zaznaczone_swiad)))
                {
                    s.kwota = Convert.ToDecimal(tbKwota.Text);
                    s.operacja = cbSwiadczenie.Text;
                    s.data = monthCalendar1.SelectionStart;
                }
                try
                {
                    var dokasacji = from p in baza.świadczenies where p.id_świadczenia == Convert.ToInt32(zaznaczone_swiad) select p;
                    baza.świadczenies.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();

                    świadczenie swiad = new świadczenie();
                    swiad.kwota = Convert.ToDecimal(tbKwota.Text);
                    swiad.operacja = cbSwiadczenie.Text;
                    swiad.data = monthCalendar1.SelectionStart;
                    swiad.id_dokumentu = Convert.ToInt32(zaznaczony_dok);
                    baza.świadczenies.InsertOnSubmit(swiad);
                    baza.SubmitChanges();
                    Close();
                    this.świadczenieTableAdapter.Fill(this.mopsDataSet.świadczenie);
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Bład");
                }
                this.świadczenieTableAdapter.Fill(this.mopsDataSet.świadczenie);
                this.Hide();
            }

        }

       
    }
}
