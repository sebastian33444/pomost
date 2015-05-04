using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace POMOST_Lite
{
    public partial class Dokumenty_Menu : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string zaznacz;
        private string zaznaczony_dok = null;
        private string p;

        public Dokumenty_Menu(string zaznacz, string p)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
            this.p = p;
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
            Dokumenty_Dodaj d = new Dokumenty_Dodaj(zaznacz,p);
            d.Show();
        }

        private void tsbUsun_Click(object sender, EventArgs e)
        {
            if (zaznaczony_dok != null)
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
            else
            {
                MessageBox.Show("Nie wybrano dokumentu.");
            }
        }

        private void tsbEdytuj_Click(object sender, EventArgs e)
        {
            if (zaznaczony_dok != null)
            {
                            
                Dokumenty_Edycja de = new Dokumenty_Edycja(zaznaczony_dok);
                de.Show();
             }
            else
            {
                MessageBox.Show("Nie zaznaczono dokumentu.");
            }
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

            WBPodglad_dokumentu.DocumentText = baza.dokumenties.Single(d => d.id_dokumentu == Convert.ToInt32(zaznaczony_dok)).zawartość_dokumentu.ToString();
               
       
       }

        private void tsbOtworzSwiad_Click(object sender, EventArgs e)
        {
            if (zaznaczony_dok != null)
            {
                Dodaj_swiadczenia swiad = new Dodaj_swiadczenia(zaznaczony_dok, "dokument");
                swiad.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano dokumentu.");
            }
        }

        private void Odswierz_Click(object sender, EventArgs e)
        {
            dgvDokumenty.DataSource = from p in baza.dokumenties
                                      where p.id_petent == Convert.ToInt32(zaznacz)
                                      select p;

        }

        private void tsbDrukuj_Click(object sender, EventArgs e)
        {

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document = printDocument1;
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
        }

        void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            string textprint = WBPodglad_dokumentu.Document.Body.OuterText;
            g.DrawString(textprint, this.Font, Brushes.Black, 50, 50);
        }



    }
}
