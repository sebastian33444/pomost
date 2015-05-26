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
            anuluj_edycja.Visible = false;
            zapisz_edycja.Visible = false;
            anuluj_dodaj.Visible = false;
            zapisz_dodaj.Visible = false;
            nazwa_uzytkownika.Enabled = false;
            haslol.Enabled = false;
            hasloponl.Enabled = false;
            imiel.Enabled = false;
            nazwiskol.Enabled = false;
            dzielnical.Enabled = false;
            miastol.Enabled = false;
            checkBoxAdmin.Enabled = false;
        }

        void wczytajOsoby()
        {
            lbPracownicy.Items.Clear();
            lbPracownicy.Items.AddRange(baza.pracowniks.OrderBy(o => o.login).ToArray());
            lbPracownicy.DisplayMember = "login";
            lbPracownicy.ValueMember = "id_pracownik";
        }


        private void dodaj_Click(object sender, EventArgs e)
        {
                anuluj_dodaj.Visible = true;
                zapisz_dodaj.Visible = true;
                nazwa_uzytkownika.Enabled = true;
                haslol.Enabled = true;
                hasloponl.Enabled = true;
                imiel.Enabled = true;
                nazwiskol.Enabled = true;
                dzielnical.Enabled = true;
                miastol.Enabled = true;
                checkBoxAdmin.Enabled = true;
                nazwa_uzytkownika.Text = null;
                haslol.Text = null;
                hasloponl.Text = null;
                imiel.Text = null;
                nazwiskol.Text = null;
                dzielnical.Text = null;
                miastol.Text = null;
                checkBoxAdmin.Checked = false;
                anuluj_dodaj.Visible = true;
                zapisz_dodaj.Visible = true;
                edytuj.Enabled = false;
                usun.Enabled = false;
                lbPracownicy.Enabled = false;
                dodaj.Enabled = false;
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            if (lbPracownicy.SelectedItem!=null)
            {
                lbPracownicy.Enabled = true;
                anuluj_edycja.Visible = true;
                zapisz_edycja.Visible = true;
                nazwa_uzytkownika.Enabled = true;
                haslol.Enabled = true;
                hasloponl.Enabled = true;
                imiel.Enabled = true;
                nazwiskol.Enabled = true;
                dzielnical.Enabled = true;
                miastol.Enabled = true;
                checkBoxAdmin.Enabled = true;
                anuluj_edycja.Visible = true;
                zapisz_edycja.Visible = true;
                dodaj.Enabled = false;
                usun.Enabled = false;
                foreach (pracownik p in baza.pracowniks.Where(p => p.login == lbPracownicy.Text))
                {
                    nazwa_uzytkownika.Text = p.login;
                    imiel.Text = p.imie;
                    nazwiskol.Text = p.nazwisko;
                    dzielnical.Text = p.dzielnica;
                    miastol.Text = p.miasto;
                    checkBoxAdmin.Checked = p.admin;
                }
            }
            else { MessageBox.Show("Zaznacz pracownika by edytować"); }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (lbPracownicy.SelectedItem != null)
            {
                var dokasacji = from p in baza.pracowniks where p.login == lbPracownicy.Text && p.login != "admin" select p;
                try
                {
                    baza.pracowniks.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("Nie można usunąć pracownika, do którego są podpięci petenci, dokumenty lub świadczenia.  Nie można usunąć głównego administratora.");
                }
                wczytajOsoby();
            }
            else { MessageBox.Show("Zaznacz pracownika by usunąć"); }    
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void lbPracownicy_Click(object sender, EventArgs e)
        {
            foreach (pracownik p in baza.pracowniks.Where(p => p.login == lbPracownicy.Text))
            {
                if (p.admin == true)
                {
                    checkBoxAdmin.Checked = true;
                    lCzyAdmin.Text = "TAK";
                }
                else
                {
                    checkBoxAdmin.Checked = false;
                    lCzyAdmin.Text = "NIE";
                }
        }
        }

        private void anuluj_edycja_Click(object sender, EventArgs e)
        {
            nazwa_uzytkownika.Text = null;
            haslol.Text = null;
            hasloponl.Text = null;
            imiel.Text = null;
            nazwiskol.Text = null;
            dzielnical.Text = null;
            miastol.Text = null;
            dodaj.Enabled = true;
            usun.Enabled = true;
            anuluj_edycja.Visible = false;
            zapisz_edycja.Visible = false;
            nazwa_uzytkownika.Enabled = false;
            haslol.Enabled = false;
            hasloponl.Enabled = false;
            imiel.Enabled = false;
            nazwiskol.Enabled = false;
            dzielnical.Enabled = false;
            miastol.Enabled = false;
            checkBoxAdmin.Enabled = false;
        }

        private void zapisz_edycja_Click(object sender, EventArgs e)
        {
            foreach (pracownik p in baza.pracowniks.Where(p => p.login == lbPracownicy.Text))
            {
                p.login = nazwa_uzytkownika.Text;
                if (haslol.Text == hasloponl.Text && haslol.Text.Length > 0 && p.imie.Length > 0 && p.nazwisko.Length > 0 && p.dzielnica.Length > 0 && p.miasto.Length > 0)
                {
                    p.haslo = szyfrowanie.SzyfrujMD5(haslol.Text);
                    p.imie = imiel.Text;
                    p.nazwisko = nazwiskol.Text;
                    p.dzielnica = dzielnical.Text;
                    p.miasto = miastol.Text;
                    if (checkBoxAdmin.Checked)
                    {
                        p.admin = true;
                    }
                    else
                    {
                        p.admin = false;
                    }
                    anuluj_edycja.Visible = false;
                    zapisz_edycja.Visible = false;
                    dodaj.Enabled = true;
                    usun.Enabled = true;
                    nazwa_uzytkownika.Text = null;
                    haslol.Text = null;
                    hasloponl.Text = null;
                    imiel.Text = null;
                    nazwiskol.Text = null;
                    dzielnical.Text = null;
                    miastol.Text = null;
                    MessageBox.Show("Pomyślnie zmodyfikowano użytkownika.");
                    nazwa_uzytkownika.Enabled = false;
                    haslol.Enabled = false;
                    hasloponl.Enabled = false;
                    imiel.Enabled = false;
                    nazwiskol.Enabled = false;
                    dzielnical.Enabled = false;
                    miastol.Enabled = false;
                    checkBoxAdmin.Enabled = false;
                }
                else if (haslol.Text == hasloponl.Text && haslol.Text.Length == 0 && p.imie.Length > 0 && p.nazwisko.Length > 0 && p.dzielnica.Length > 0 && p.miasto.Length > 0)
                {
                    p.imie = imiel.Text;
                    p.nazwisko = nazwiskol.Text;
                    p.dzielnica = dzielnical.Text;
                    p.miasto = miastol.Text;
                    if (checkBoxAdmin.Checked)
                    {
                        p.admin = true;
                    }
                    else
                    {
                        p.admin = false;
                    }
                    anuluj_edycja.Visible = false;
                    zapisz_edycja.Visible = false;
                    dodaj.Enabled = true;
                    usun.Enabled = true;
                    nazwa_uzytkownika.Text = null;
                    haslol.Text = null;
                    hasloponl.Text = null;
                    imiel.Text = null;
                    nazwiskol.Text = null;
                    dzielnical.Text = null;
                    miastol.Text = null;
                    MessageBox.Show("Pomyslnie zmodyfikowano użytkownika. Hasło pozostało bez zmian.");
                    nazwa_uzytkownika.Enabled = false;
                    haslol.Enabled = false;
                    hasloponl.Enabled = false;
                    imiel.Enabled = false;
                    nazwiskol.Enabled = false;
                    dzielnical.Enabled = false;
                    miastol.Enabled = false;
                    checkBoxAdmin.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hasła nie są identyczne.");
                }
            }
            baza.SubmitChanges();
            wczytajOsoby();
        }

        private void zapisz_dodaj_Click(object sender, EventArgs e)
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
            if (imiel.Text.Length > 0 && nazwiskol.Text.Length > 0 && nazwa_uzytkownika.Text.Length > 0 && haslol.Text.Length > 0 && miastol.Text.Length > 0 && dzielnical.Text.Length > 0 && ok == true && haslol.Text == hasloponl.Text)
            {
                pracownik prac = new pracownik();
                baza.pracowniks.InsertOnSubmit(prac);
                prac.imie = imiel.Text;
                prac.nazwisko = nazwiskol.Text;
                prac.login = nazwa_uzytkownika.Text;
                prac.haslo = szyfrowanie.SzyfrujMD5(haslol.Text);
                prac.miasto = miastol.Text;
                prac.dzielnica = dzielnical.Text;

                if (checkBoxAdmin.Checked)
                {
                    prac.admin = true;
                }
                else
                {
                    prac.admin = false;
                }
                baza.SubmitChanges();
                nazwa_uzytkownika.Text = null;
                haslol.Text = null;
                hasloponl.Text = null;
                imiel.Text = null;
                nazwiskol.Text = null;
                dzielnical.Text = null;
                miastol.Text = null;
                anuluj_dodaj.Visible = false;
                zapisz_dodaj.Visible = false;
                dodaj.Enabled = true;
                usun.Enabled = true;
                edytuj.Enabled = true;

                MessageBox.Show("Pomyślnie dodano użytkownika.");
                nazwa_uzytkownika.Enabled = false;
                haslol.Enabled = false;
                hasloponl.Enabled = false;
                imiel.Enabled = false;
                nazwiskol.Enabled = false;
                dzielnical.Enabled = false;
                miastol.Enabled = false;
                checkBoxAdmin.Enabled = false;
                lbPracownicy.Enabled = true;
                dodaj.Enabled = true;
                wczytajOsoby();
            }
            else
            {
                MessageBox.Show("Nie wszystkie pola są wypełnione lub login już zajety lub hasła nie są identyczne.");
            }
        }

        private void anuluj_dodaj_Click(object sender, EventArgs e)
        {
            nazwa_uzytkownika.Text = null;
            haslol.Text = null;
            hasloponl.Text = null;
            imiel.Text = null;
            nazwiskol.Text = null;
            dzielnical.Text = null;
            miastol.Text = null;
            edytuj.Enabled = true;
            usun.Enabled = true;
            anuluj_dodaj.Visible = false;
            zapisz_dodaj.Visible = false;
            nazwa_uzytkownika.Enabled = false;
            haslol.Enabled = false;
            hasloponl.Enabled = false;
            imiel.Enabled = false;
            nazwiskol.Enabled = false;
            dzielnical.Enabled = false;
            miastol.Enabled = false;
            checkBoxAdmin.Enabled = false;
            lbPracownicy.Enabled = true;
            dodaj.Enabled = true;
        }

        private void Dodaj_uzytkownika_Load(object sender, EventArgs e)
        {
            this.pracownikTableAdapter.Fill(this.mopsDataSet.pracownik);

        }
    }
}
