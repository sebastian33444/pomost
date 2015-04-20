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
    public partial class Swiadczenie : Form
    {
        private bool czydodac = false;
        private string zaznacz;
        private string zaznaczone_swiad;
        private string zaznaczony_dok;
        DataClassesDataContext baza = new DataClassesDataContext();


        public Swiadczenie(string zaznacz, string zaznaczone_swiad, string zaznaczony_dok, bool czydodac)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
            this.zaznaczone_swiad = zaznaczone_swiad;
            this.zaznaczony_dok = zaznaczony_dok;
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
        }

        
        private void Swiadczenie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mopsDataSet.dokumenty' table. You can move, or remove it, as needed.
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
                    baza.świadczenies.InsertOnSubmit(swiad);
                    swiad.kwota = Convert.ToDecimal(tbKwota.Text);
                    swiad.operacja = cbSwiadczenie.Text;
                    swiad.data = monthCalendar1.SelectionStart;
                    swiad.id_dokumentu = Convert.ToInt32(zaznaczony_dok);
                    swiad.id_pracownik = 9;
                    baza.SubmitChanges();
                    Close();
                    MessageBox.Show("Dodano świadczenie.");
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
                baza.SubmitChanges();
                Close();
            }
        }
    }
}
