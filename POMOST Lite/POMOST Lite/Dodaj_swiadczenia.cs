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
        private string zaznacz;
        private string zaznaczone_swiad;

        public Dodaj_swiadczenia(string zaznacz)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
            Shown += delegate { dgvSwiadczenie.ClearSelection(); };
        }

        private void Dodaj_swiadczenia_Load(object sender, EventArgs e)
        {
            dgvSwiadczenie.DataSource = from pet in baza.petents
                                        join dok in baza.dokumenties on pet.id_petent equals dok.id_petent
                                        join swi in baza.świadczenies on dok.id_dokumentu equals swi.id_dokumentu
                                        where pet.id_petent ==  Convert.ToInt32(zaznacz)  
                                        select swi;
        }

        private void tsbZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tsbEdytuj_Click(object sender, EventArgs e)
        {
            ////dodać kod!
        }

        private void tsbUsun_Click(object sender, EventArgs e)
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

        private void tsbDodaj_Click(object sender, EventArgs e)
        {
            ////dodać kod!
        }

        private void dgvSwiadczenie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                zaznaczone_swiad = dgvSwiadczenie.Rows[e.RowIndex].Cells["idświadczeniaDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch { }
        }
    }
}
