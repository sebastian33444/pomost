using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace POMOST_Lite
{
    public partial class Strona_glowna : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string p;
        private bool admin = false;
        private int id_prac; 

        public Strona_glowna(string p)
        {
            InitializeComponent();

            this.p = p;
           foreach(pracownik prac in baza.pracowniks.Where(prac => prac.login == p))
           {
               tslabelLogin.Text = prac.login.ToString();
               tslabelMiasto.Text = prac.miasto.ToString();
               tslabelDzielnica.Text = prac.dzielnica.ToString();
               admin = prac.admin;
               id_prac = prac.id_pracownik;
           }
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {

        }

        private void Strona_glowna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Strona_glowna_Load(object sender, EventArgs e)
        {
            if(admin == true)
            {
                this.petentTableAdapter.Fill(this.mopsDataSet1.petent);
            }
            else
            {
                dgvPetent.DataSource = from p in baza.petents
                                       where p.id_pracownik == id_prac
                                       select p;
            }


        }

        private void usun_petenta_Click(object sender, EventArgs e)
        {

            dgvPetent.Rows.RemoveAt(this.dgvPetent.CurrentCell.RowIndex);
            
            try
            {
               //baza.petents.DeleteAllOnSubmit(dokasacji);
              //  baza.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Nie można usunąć pracownika, do którego są podpięci petenci, dokumenty lub świadczenia.  Nie można usunąć głównego administratora.");
            }
        }

        private void dokumenty_Click(object sender, EventArgs e)
        {
            Dokumenty d = new Dokumenty();
            d.Show(); 
        }


    }
}
