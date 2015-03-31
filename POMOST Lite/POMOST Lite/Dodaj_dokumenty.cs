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
    public partial class Dodaj_dokumenty : Form
    {
        public Dodaj_dokumenty()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser.Navigate("http://localhost:50015/Dokument.aspx");
           
        }
    }
}
