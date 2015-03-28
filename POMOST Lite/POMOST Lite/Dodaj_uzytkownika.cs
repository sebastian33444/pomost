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


        private void dodaj_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Pomyślnie dodano użytkownika.");
                        wczytajOsoby();
                    
                }
                else
                {
                    MessageBox.Show("Nie wszystkie pola są wypełnione lub login już zajety lub hasła nie są identyczne.");
                }
        }

        private void Dodaj_uzytkownika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
                foreach(pracownik p in baza.pracowniks.Where(p => p.login == listBox1.Text))
                {
                    nazwa_uzytkownika.Text = p.login;
                    imiel.Text = p.imie;
                    nazwiskol.Text = p.nazwisko;
                    dzielnical.Text = p.dzielnica;
                    miastol.Text = p.miasto;
                    checkBoxAdmin.Checked = p.admin;
                    anuluj.Visible = true;
                    zapisz.Visible = true;
                    tryb_edycji.Visible = true;
                    dodaj.Enabled = false;
                    usun.Enabled = false;
                }
        }

        private void usun_Click(object sender, EventArgs e)
        {
                var dokasacji = from p in baza.pracowniks where p.login == listBox1.Text && p.login != "admin" select p;
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
            hasloponl.Text = null;
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
                foreach (pracownik p in baza.pracowniks.Where(p => p.login == listBox1.Text))
                {
                    p.login = nazwa_uzytkownika.Text;
                    if (haslol.Text == hasloponl.Text && haslol.Text.Length > 0 && p.imie.Length > 0 && p.nazwisko.Length > 0 && p.dzielnica.Length > 0 && p.miasto.Length > 0)
                    {
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
                        nazwa_uzytkownika.Text = null;
                        haslol.Text = null;
                        hasloponl.Text = null;
                        imiel.Text = null;
                        nazwiskol.Text = null;
                        dzielnical.Text = null;
                        miastol.Text = null;
                        MessageBox.Show("Pomyślnie zmodyfikowano użytkownika.");
                    }
                    else if (haslol.Text == hasloponl.Text && haslol.Text.Length == 0 && p.imie.Length > 0 && p.nazwisko.Length > 0 && p.dzielnica.Length > 0 && p.miasto.Length > 0)
                    {
                        p.imie = imiel.Text;
                        p.nazwisko = nazwiskol.Text;
                        p.dzielnica = dzielnical.Text;
                        p.miasto = miastol.Text;
                        anuluj.Visible = false;
                        zapisz.Visible = false;
                        tryb_edycji.Visible = false;
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
                    }
                    else
                    {
                        MessageBox.Show("Hasła nie są identyczne.");
                    }
                }
             baza.SubmitChanges();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            foreach (pracownik p in baza.pracowniks.Where(p => p.login == listBox1.Text))
            {
                if (p.admin == true)
                {
                    checkBoxAdmin.Checked = true;
                }
                else
                {
                    checkBoxAdmin.Checked = false;
                }
            }
        }
    }
}
