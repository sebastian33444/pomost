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
    public partial class Edytuj_petenta : Form
    {
        private string id_petent;
        private string id_prac;
        DataClassesDataContext baza = new DataClassesDataContext();

        
        public Edytuj_petenta(string id_petent, string id_prac)
        {
            InitializeComponent();
            this.id_petent = id_petent;
            this.id_prac = id_prac;
            bool admin = false;
            foreach (pracownik prac in baza.pracowniks.Where(prac => prac.login == id_prac))
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
            foreach(petent p in baza.petents.Where(p => p.id_petent == Convert.ToInt32(id_petent)))
            {
                tbImie.Text = p.imie;
                tbNazwisko.Text = p.nazwisko;
                tbPesel.Text = p.pesel;
                tbWojewodztwo.Text = p.województwo;
                tbMiasto.Text = p.miasto;
                tbKod.Text = p.kod_pocztowy;
                tbUlica.Text = p.ulica;
                tbNrUl.Text = p.nr_ulicy.ToString();
                tbMieszkanie.Text = p.nr_mieszkania.ToString();
                tbTelefon.Text = p.nr_telefonu;
                Kalendarz.SelectionStart = p.d_ur;
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
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
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

        private void bAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bZapisz_Click(object sender, EventArgs e)
        {
            foreach (petent p in baza.petents.Where(p => p.id_petent == Convert.ToInt32(id_petent)))
            {
                p.imie = tbImie.Text;
                p.nazwisko = tbNazwisko.Text;
                p.pesel = tbPesel.Text;
                p.województwo = tbWojewodztwo.Text;
                p.miasto = tbMiasto.Text;
                p.kod_pocztowy = tbKod.Text;
                p.ulica = tbUlica.Text;
                p.nr_ulicy = Convert.ToInt32(tbNrUl.Text);
                p.nr_mieszkania = Convert.ToInt32(tbMieszkanie.Text);
                p.nr_telefonu = tbTelefon.Text;
                p.d_ur = Kalendarz.SelectionStart;
                foreach (pracownik prac in baza.pracowniks.Where(prac => prac.login == cbPracownik.Text))
                {
                    p.id_pracownik = prac.id_pracownik;
                }
            }
            baza.SubmitChanges();
            Close();
            MessageBox.Show("Pomyślnie zaktualizowano petenta.");
        }

        private void Edytuj_petenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mopsDataSet.pracownik' table. You can move, or remove it, as needed.
            this.pracownikTableAdapter.Fill(this.mopsDataSet.pracownik);
            this.cbPracownik.Text = null;
            this.cbPracownik.SelectedText = id_prac;
        }
    }
}
