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
    public partial class Swiadczenie_Podglad : Form
    {
        DataClassesDataContext p = new DataClassesDataContext();

        public Swiadczenie_Podglad(string q)
        {
            InitializeComponent();
           foreach(dokumenty d in p.dokumenties.Where(d=>d.id_dokumentu==Convert.ToInt32(q)))
            {
                WBSwiadczenia_Podglad.DocumentText = d.zawartość_dokumentu;

            }
        }
    }
}
