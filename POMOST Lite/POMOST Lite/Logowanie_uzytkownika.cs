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
    public partial class Logowanie_uzytkownika : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        md5 szyfrowanie = new md5();

        public Logowanie_uzytkownika()
        {
            InitializeComponent();            
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void zaloguj_Click(object sender, EventArgs e)
        {
            bool log = false;
            foreach (pracownik p in baza.pracowniks)
            {
                if (p.login == nazwa_uzytkownika.Text && p.haslo.ToUpper() == szyfrowanie.SzyfrujMD5(haslo.Text))
                {
                    log = true;
                }
            }
             if (log == true)
            {
                this.Hide();
                Strona_glowna str_gl = new Strona_glowna();
                str_gl.Show();
            }
            else
            {
                MessageBox.Show("Bład logowania.");
            }
        }

        private void dodaj_uzytkownika_Click(object sender, EventArgs e)
        {
            bool log = false;
            Dodaj_uzytkownika adduser = new Dodaj_uzytkownika();
            foreach (pracownik prac in baza.pracowniks.Where(prac => prac.admin == true))
            {
                if (prac.login == nazwa_uzytkownika.Text && prac.haslo.ToUpper() == szyfrowanie.SzyfrujMD5(haslo.Text))
                {
                    log = true;
                }
            }
            if (log == true)
            {
                this.Hide();
                adduser.Show();
            }
            else
            {
                MessageBox.Show("Brak uprawnień! \nSprawdź login i hasło.");
            }
        }

        private void KonfBazy_Click(object sender, EventArgs e)
        {
            Konfiguracja_bazy konfbaza = new Konfiguracja_bazy();
            this.Hide();
            konfbaza.Show();
        }
    }

}
