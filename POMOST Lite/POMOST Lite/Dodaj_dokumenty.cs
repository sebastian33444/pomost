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

        private void Dodaj_dokumenty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mopsDataSet.dokumenty' table. You can move, or remove it, as needed.
            this.dokumentyTableAdapter.Fill(this.mopsDataSet.dokumenty);

        }
    }
}
