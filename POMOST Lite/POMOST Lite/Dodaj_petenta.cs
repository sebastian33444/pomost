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
    public partial class Dodaj_petenta : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string p;

        public Dodaj_petenta(string p)
        {
            InitializeComponent();
            this.p = p;
            bool admin = false;
            foreach(pracownik prac in baza.pracowniks.Where(prac => prac.login == p))
            {
                admin = prac.admin;
            }
            if (admin == true)
            {
                cbPracownik.Enabled = true; 
            }
            else
            {
                cbPracownik.Enabled = false;
            }
        }

        private void tbPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void tbKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool cofaj = false;
            if (char.IsDigit(e.KeyChar))
            {
                base.OnKeyPress(e);
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                base.OnKeyPress(e);
                cofaj = true;
            }
            else
                e.Handled = true;
            if(tbKod.TextLength==2 && cofaj==false)
            {
                tbKod.Text += "-";
                tbKod.SelectionStart = tbKod.Text.Length;
            }
        }

        private void tbNrUl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void tbMieszkanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void bZapisz_Click(object sender, EventArgs e) 
        {
            try
            {
            petent p = new petent();
            baza.petents.InsertOnSubmit(p);
            p.imie = tbImie.Text;
            p.nazwisko = tbNazwisko.Text;
            p.d_ur = Kalendarz.SelectionStart;
            p.pesel = tbPesel.Text;
            p.województwo = tbWojewodztwo.Text;
            p.miasto = tbMiasto.Text;
            p.kod_pocztowy = tbKod.Text;
            p.ulica = tbUlica.Text;
            p.nr_ulicy = Convert.ToInt32(tbNrUl.Text); 
            p.nr_mieszkania = Convert.ToInt32(tbMieszkanie.Text);
            p.nr_telefonu = tbTelefon.Text;
            foreach (pracownik prac in baza.pracowniks.Where(prac => prac.login == cbPracownik.Text))
            {
                p.id_pracownik = prac.id_pracownik;
            }

            baza.SubmitChanges();
            Close();
            MessageBox.Show("Pomyślnie dodano petenta.");
            }
            catch
            {
                MessageBox.Show("Nie wszystkie pola zostały wypełnione!");
            }

        }

        private void bAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dodaj_petenta_Load(object sender, EventArgs e)
        {
            this.pracownikTableAdapter.Fill(this.mopsDataSet.pracownik);
            this.cbPracownik.Text = null;
            this.cbPracownik.SelectedText = p;
        }
    }
}
