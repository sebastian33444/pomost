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
    public partial class Dodaj_swiadczenia : Form
    {
        private string zaznacz;

        public Dodaj_swiadczenia(string zaznacz)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
        }

        private void Dodaj_swiadczenia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mopsDataSet.świadczenie' table. You can move, or remove it, as needed.
            this.świadczenieTableAdapter.Fill(this.mopsDataSet.świadczenie);

        }
    }
}
