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
        private string p; //login pracownika
        private bool admin = false;
        private int id_prac;
        private string zaznacz = null;
          
        public Strona_glowna(string p)
        {
            InitializeComponent();
            this.p = p;
            Shown += delegate { dgvPetent.ClearSelection(); };
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
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
            this.Hide();
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
            if (zaznacz != null)
            {
                try
                {
                    var dokasacji = from p in baza.petents where p.id_petent == Convert.ToInt32(zaznacz) select p;
                    baza.petents.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();
                    dgvPetent.Rows.RemoveAt(this.dgvPetent.CurrentCell.RowIndex);
                }
                catch
                {
                    MessageBox.Show("Nie można usunąć petenta, do którego są podpięte dokumenty i świadczenia.");
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono petenta.");
            }
        }

        private void dodaj_petenta_Click(object sender, EventArgs e)
        {
            Dodaj_petenta add = new Dodaj_petenta(p);
            add.FormClosed += add_FormClosed;
            add.Show();
        }

        private void add_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (admin == true)
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

        private void dgvPetent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                zaznacz = dgvPetent.Rows[e.RowIndex].Cells["idpetentDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch { }
        }

        private void edytuj_petenta_Click(object sender, EventArgs e)
        {
            if (zaznacz != null)
            {
                Edytuj_petenta edit = new Edytuj_petenta(zaznacz, p);
                edit.FormClosed += edit_FormClosed;
                edit.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono petenta.");
            }
        }

        private void edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (admin == true)
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


        private void swiadczenia_Click(object sender, EventArgs e)
        {
            if (zaznacz != null)
            {
                Swiadczenia_Menu swiad = new Swiadczenia_Menu(zaznacz);
                swiad.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono petenta.");
            }
        }

        private void dokumenty_Click(object sender, EventArgs e)
        {
            if (zaznacz != null)
            {
                Dokumenty_Menu dok = new Dokumenty_Menu(zaznacz,p);
                dok.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono petenta.");
            }
        }

        private void Uzytkownicy_Click(object sender, EventArgs e)
        {
            bool log = false;
            foreach (pracownik prac in baza.pracowniks.Where(prac => prac.login == p))
            {
                if (prac.admin == true)
                {
                    log = true;
                }
            }
            if (log == true)
            {
                this.Hide();
                Dodaj_uzytkownika adduser = new Dodaj_uzytkownika();
                adduser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Brak uprawnień!");
            }
        }

    }
}
