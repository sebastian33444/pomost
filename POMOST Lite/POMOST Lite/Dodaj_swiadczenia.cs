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
    public partial class Dodaj_swiadczenia : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string zaznacz; //id petenta
        private string zaznaczone_swiad = null;
        private string zaznaczony_dok ;
        private string p = null;
        private bool czydodac = false;

        public Dodaj_swiadczenia(string zaznacz)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
            Shown += delegate { dgvSwiadczenie.ClearSelection(); };
            dgvSwiadczenie.DataSource = from pet in baza.petents
                                        join dok in baza.dokumenties on pet.id_petent equals dok.id_petent
                                        join swi in baza.świadczenies on dok.id_dokumentu equals swi.id_dokumentu
                                        where pet.id_petent == Convert.ToInt32(zaznacz)
                                        select swi;
        }

        public Dodaj_swiadczenia(string zaznaczony_dok, string p)
        {
            InitializeComponent();
            this.zaznaczony_dok = zaznaczony_dok;
            this.p = p;
            Shown += delegate { dgvSwiadczenie.ClearSelection(); };
            dgvSwiadczenie.DataSource = from swiad in baza.świadczenies
                                        where swiad.id_dokumentu == Convert.ToInt32(zaznaczony_dok)
                                        select swiad;
        }

        private void Dodaj_swiadczenia_Load(object sender, EventArgs e)
        {

        }

        private void tsbZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tsbUsun_Click(object sender, EventArgs e)
        {
            if (zaznaczone_swiad != null)
            {
                try
                {
                    var dokasacji = from p in baza.świadczenies where p.id_świadczenia == Convert.ToInt32(zaznaczone_swiad) select p;
                    baza.świadczenies.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();
                    dgvSwiadczenie.Rows.RemoveAt(this.dgvSwiadczenie.CurrentCell.RowIndex);
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Nie wybrano świadczenia.");
            }
        }

        private void tsbDodaj_Click(object sender, EventArgs e)
        {
            czydodac = true;
            {
                Swiadczenie addswiad = new Swiadczenie(zaznacz, zaznaczone_swiad, zaznaczony_dok, czydodac );
                addswiad.FormClosed += addswiad_FormClosed;
                addswiad.Show();
            }
        }

        private void addswiad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (p == "dokument")
            {
                this.Hide();
                Dodaj_swiadczenia s = new Dodaj_swiadczenia(zaznaczony_dok, p);
                s.Show();
            }
            else
            {
                this.Hide();
                Dodaj_swiadczenia s = new Dodaj_swiadczenia(zaznacz);
                s.Show();
            }

        }

        private void tsbEdytuj_Click(object sender, EventArgs e)
        {
            if (zaznaczone_swiad != null)
            {
                Swiadczenie editswiad = new Swiadczenie(zaznacz, zaznaczone_swiad, zaznaczony_dok, czydodac);
                editswiad.FormClosed += editswiad_FormClosed;
                editswiad.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano świadczenia.");
            }
        }

        private void editswiad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(p == "dokument")
            {
                this.Hide();
                Dodaj_swiadczenia s = new Dodaj_swiadczenia(zaznaczony_dok, p);
                s.Show();
            }
            else
            {
                this.Hide();
                Dodaj_swiadczenia s = new Dodaj_swiadczenia(zaznacz);
                s.Show();
            }
        }

        private void dgvSwiadczenie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                zaznaczone_swiad = dgvSwiadczenie.Rows[e.RowIndex].Cells["idświadczeniaDataGridViewTextBoxColumn"].Value.ToString();
                zaznaczony_dok = dgvSwiadczenie.Rows[e.RowIndex].Cells["iddokumentuDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch { }
        }

        private void tsbOtworzDok_Click(object sender, EventArgs e)
        {

        }
    }
}
