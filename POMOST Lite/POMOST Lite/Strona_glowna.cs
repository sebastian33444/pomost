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
    public partial class Strona_glowna : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string p;
        private string status;

        
        public Strona_glowna()
        {
            InitializeComponent();
        }

        public Strona_glowna(string p, string status)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.status = status;
            if (status == "admin")
            {
                MessageBox.Show(p + status);
                /*
                foreach(administratorzy adm in baza.administratorzies.Where(adm => adm.login == p))
                {
                    tslabelLogin.Text = adm.login;
                }
                 * */
            }
            else if (status =="user")
            {

            }
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {

        }

        private void Strona_glowna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dodaj_dokumenty d_d = new Dodaj_dokumenty();
            d_d.Show();

        }
    }
}
