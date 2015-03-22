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
    public partial class Dodaj_uzytkownika : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        md5 szyfrowanie = new md5();
        

        public Dodaj_uzytkownika()
        {
            InitializeComponent();
            wczytajOsoby();
            anuluj.Visible = false;
            zapisz.Visible = false;
            tryb_edycji.Visible = false;
        }

        void wczytajOsoby()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(baza.pracowniks.OrderBy(o => o.login).ToArray());
            listBox1.DisplayMember = "login";
            listBox1.ValueMember = "id_pracownik";
        }

        void wczytajAdmin()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(baza.administratorzies.ToArray());
            listBox1.DisplayMember = "login";
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                bool ok = true;
                foreach (administratorzy adm in baza.administratorzies)
                {
                    if (adm.login == nazwa_uzytkownika.Text)
                    {
                        ok = false;
                        break;
                    }
                }
                if (nazwa_uzytkownika != null && haslol.Text != null && ok == true)
                {
                    administratorzy adm = new administratorzy();
                    baza.administratorzies.InsertOnSubmit(adm);
                    adm.login = nazwa_uzytkownika.Text;
                    adm.haslo = szyfrowanie.SzyfrujMD5(haslol.Text);
                    baza.SubmitChanges();
                    MessageBox.Show("Pomyślnie dodano administratora.");
                    wczytajAdmin();
                }
                else
                {
                    MessageBox.Show("Nie wszystkie pola są wypełnione lub login już zajety.");
                }
            }
            else
            {
                bool ok = true;
                foreach (pracownik p in baza.pracowniks)
                {
                    if (p.login == nazwa_uzytkownika.Text)
                    {
                        ok = false;
                        break;
                    }
                }
                if (imiel.Text != null && nazwiskol.Text != null && nazwa_uzytkownika != null && haslol.Text != null && miastol.Text != null && dzielnical.Text != null && ok == true)
                {
                    pracownik prac = new pracownik();
                    baza.pracowniks.InsertOnSubmit(prac);
                    prac.imie = imiel.Text;
                    prac.nazwisko = nazwiskol.Text;
                    prac.login = nazwa_uzytkownika.Text;
                    prac.haslo = szyfrowanie.SzyfrujMD5(haslol.Text);
                    prac.miasto = miastol.Text;
                    prac.dzielnica = dzielnical.Text;
                    baza.SubmitChanges();
                    MessageBox.Show("Pomyślnie dodano użytkownika.");
                    wczytajOsoby();
                }
                else
                {
                    MessageBox.Show("Nie wszystkie pola są wypełnione lub login już zajety.");
                }
               
            }
        }

        private void Dodaj_uzytkownika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                foreach(administratorzy adm in baza.administratorzies.Where(adm => adm.login == listBox1.Text))
                {
                    nazwa_uzytkownika.Text = adm.login;
                    haslol.Text = adm.haslo;
                    anuluj.Visible = true;
                    zapisz.Visible = true;
                    tryb_edycji.Visible = true;
                    dodaj.Enabled = false;
                    usun.Enabled = false;
                }
            }
            else
            {
                foreach(pracownik p in baza.pracowniks.Where(p => p.login == listBox1.Text))
                {
                    nazwa_uzytkownika.Text = p.login;
                    haslol.Text = p.haslo;
                    imiel.Text = p.imie;
                    nazwiskol.Text = p.nazwisko;
                    dzielnical.Text = p.dzielnica;
                    miastol.Text = p.miasto;
                    anuluj.Visible = true;
                    zapisz.Visible = true;
                    tryb_edycji.Visible = true;
                    dodaj.Enabled = false;
                    usun.Enabled = false;
                }

            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                var dokasacji = from p in baza.administratorzies where p.login == listBox1.Text && p.login !="admin" select p;
                try
                {
                    baza.administratorzies.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("Nie można usunąć głównego administratora.");
                }
                wczytajAdmin();
            }
            else
            {
                var dokasacji = from p in baza.pracowniks where p.login == listBox1.Text select p;
                try
                {
                    baza.pracowniks.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("Nie można usunąć pracownika, do którego są podpięci petenci, dokumenty lub świadczenia.");
                }
                wczytajOsoby();
            }

        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                wczytajAdmin();
                nazwa_uzytkownika.Text = null;
                haslol.Text = null;
                imiel.Text = null;
                nazwiskol.Text = null;
                dzielnical.Text = null;
                miastol.Text = null;
                imiel.Enabled = false;
                nazwiskol.Enabled = false;
                dzielnical.Enabled = false;
                miastol.Enabled = false;
            }
            else
            {
                wczytajOsoby();
                nazwa_uzytkownika.Text = null;
                haslol.Text = null;
                imiel.Text = null;
                nazwiskol.Text = null;
                dzielnical.Text = null;
                miastol.Text = null;
                imiel.Enabled = true;
                nazwiskol.Enabled = true;
                dzielnical.Enabled = true;
                miastol.Enabled = true;
            }
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            nazwa_uzytkownika.Text = null;
            haslol.Text = null;
            imiel.Text = null;
            nazwiskol.Text = null;
            dzielnical.Text = null;
            miastol.Text = null;
            dodaj.Enabled = true;
            usun.Enabled = true;
            anuluj.Visible = false;
            zapisz.Visible = false;
            tryb_edycji.Visible = false;
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                foreach (administratorzy adm in baza.administratorzies.Where(adm => adm.login == listBox1.Text))
                {
                    adm.login = nazwa_uzytkownika.Text;
                    adm.haslo = szyfrowanie.SzyfrujMD5(haslol.Text);
                    anuluj.Visible = false;
                    zapisz.Visible = false;
                    tryb_edycji.Visible = false;
                    dodaj.Enabled = true;
                    usun.Enabled = true;
                }
            }
            else
            {
                foreach (pracownik p in baza.pracowniks.Where(p => p.login == listBox1.Text))
                {
                    p.login = nazwa_uzytkownika.Text;
                    p.haslo = szyfrowanie.SzyfrujMD5(haslol.Text);
                    p.imie = imiel.Text;
                    p.nazwisko = nazwiskol.Text;
                    p.dzielnica = dzielnical.Text;
                    p.miasto = miastol.Text;
                    anuluj.Visible = false;
                    zapisz.Visible = false;
                    tryb_edycji.Visible = false;
                    dodaj.Enabled = true;
                    usun.Enabled = true;
                }
            }
            baza.SubmitChanges();
        }
    }
}
