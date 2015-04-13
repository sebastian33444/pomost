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
    public partial class Dokumenty : Form
    {
        public Dokumenty()
        {
            InitializeComponent();
            for (int i = 0; i < 1; i++)
            {
                WebBrowser.Navigate("http://localhost:49286/Dokument.aspx");
            }
        }
    }
}
