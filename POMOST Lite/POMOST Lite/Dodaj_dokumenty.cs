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
    public partial class Dodaj_dokumenty : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string zaznacz;
        private string zaznaczony_dok;

        public Dodaj_dokumenty(string zaznacz)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
            Shown += delegate { dgvDokumenty.ClearSelection(); };
        }

        private void Dodaj_dokumenty_Load(object sender, EventArgs e)
        {
             dgvDokumenty.DataSource = from p in baza.dokumenties
                                       where p.id_petent == Convert.ToInt32(zaznacz)
                                       select p;
        }

        private void tsbDodaj_Click(object sender, EventArgs e)
        {
            ////dodać kod!
        }

        private void tsbUsun_Click(object sender, EventArgs e)
        {
            try
            {
                var dokasacji = from p in baza.dokumenties where p.id_dokumentu == Convert.ToInt32(zaznaczony_dok) select p;
                baza.dokumenties.DeleteAllOnSubmit(dokasacji);
                baza.SubmitChanges();
                dgvDokumenty.Rows.RemoveAt(this.dgvDokumenty.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Nie można usunąć dokumentu, który ma podpięte świadczenie.");
            }
        }

        private void tsbEdytuj_Click(object sender, EventArgs e)
        {
            ////dodać kod!
        }

        private void tsbZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvDokumenty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                zaznaczony_dok = dgvDokumenty.Rows[e.RowIndex].Cells["iddokumentuDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch { }
        }
    }
}
