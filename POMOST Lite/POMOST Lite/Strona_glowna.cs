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

        
        public Strona_glowna()
        {
            InitializeComponent();
            foreach(pracownik p in baza.pracowniks)
            {
                richTextBox1.AppendText(p.imie + " "+ p.nazwisko +"\n");
            }
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {

        }

        private void Strona_glowna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
