﻿using System;
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
    public partial class Dokumenty_Edycja : Form
    {
        public Dokumenty_Edycja(string q, string w, string e)
        {
            //q - id dokumentu
            //w- id petenta
            //e- log pracownika
            InitializeComponent();
            for (int i = 0; i < 1; i++)
            {
                WBDokumenty_Edycja.Navigate("http://localhost:49286/Dokumenty_Edycja.aspx?zmienna=" + q);//+"&zmienna2="+w+"&zmienna3="+e);
            }
        }
    }
}
