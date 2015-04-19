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

        md5 szyfrowanie = new md5();
        Konfiguracja_bazy konfbaza = new Konfiguracja_bazy();
        Dodaj_uzytkownika adduser = new Dodaj_uzytkownika();

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
            DataClassesDataContext baza = new DataClassesDataContext();
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
                Strona_glowna str_gl = new Strona_glowna(nazwa_uzytkownika.Text);
                str_gl.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bład logowania.");
            }
        }

        private void KonfBazy_Click(object sender, EventArgs e)
        {
            this.Hide();
            konfbaza.ShowDialog();
        }
    }

}
