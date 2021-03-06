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
    public partial class Swiadczenia_Menu : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string zaznacz; //id petenta
        private string zaznaczone_swiad = null;
        private string zaznaczony_dok ;
        private string p = null;
        private bool czydodac = false;
        private bool petentOrDok;

        public Swiadczenia_Menu(string zaznacz, bool swiadOrDok)
        {
            InitializeComponent();
            this.zaznacz = zaznacz;
            this.petentOrDok = swiadOrDok;
            Shown += delegate { dgvSwiadczenie.ClearSelection(); };
            dgvSwiadczenie.DataSource = from pet in baza.petents
                                        join dok in baza.dokumenties on pet.id_petent equals dok.id_petent
                                        join swi in baza.świadczenies on dok.id_dokumentu equals swi.id_dokumentu
                                        where pet.id_petent == Convert.ToInt32(zaznacz)
                                        select swi;
        }

        public Swiadczenia_Menu(string zaznaczony_dok, string p, bool swiadOrDok)
        {
            InitializeComponent();
            this.zaznaczony_dok = zaznaczony_dok;
            this.p = p;
            this.petentOrDok = swiadOrDok;
            Shown += delegate { dgvSwiadczenie.ClearSelection(); };
            dgvSwiadczenie.DataSource = from swiad in baza.świadczenies
                                        where swiad.id_dokumentu == Convert.ToInt32(zaznaczony_dok)
                                        select swiad;
        }

        private void Dodaj_swiadczenia_Load(object sender, EventArgs e)
        {

        }

        private void tsbZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tsbUsun_Click(object sender, EventArgs e)
        {
            if (zaznaczone_swiad != null)
            {
                try
                {
                    var dokasacji = from p in baza.świadczenies where p.id_świadczenia == Convert.ToInt32(zaznaczone_swiad) select p;
                    baza.świadczenies.DeleteAllOnSubmit(dokasacji);
                    baza.SubmitChanges();
                    dgvSwiadczenie.Rows.RemoveAt(this.dgvSwiadczenie.CurrentCell.RowIndex);
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Nie wybrano świadczenia.");
            }
        }

        private void tsbDodaj_Click(object sender, EventArgs e)
        {
            bool flaga = false;
            foreach (dokumenty d in baza.dokumenties.Where(d => d.id_petent == Convert.ToInt32(zaznacz))) flaga = true;
            foreach (dokumenty d in baza.dokumenties.Where(d => d.id_dokumentu == Convert.ToInt32(zaznaczony_dok))) flaga = true;
           
          if (flaga == true)
           {
               Swiadczenie_Dodaj addswiad = new Swiadczenie_Dodaj(zaznaczone_swiad, zaznaczony_dok, true, petentOrDok, zaznacz);
               addswiad.FormClosed += addswiad_FormClosed;
               addswiad.ShowDialog();
           }
           else { 
            MessageBox.Show("Wybrany petent nie ma przypisanego dokumentu."); 
            }
        }

        private void addswiad_FormClosed(object sender, FormClosedEventArgs e)
        {
            zaznaczone_swiad = dgvSwiadczenie.Rows[0].Cells["idświadczeniaDataGridViewTextBoxColumn"].Value.ToString();
            zaznaczony_dok = dgvSwiadczenie.Rows[0].Cells["iddokumentuDataGridViewTextBoxColumn"].Value.ToString();
            if (p == "dokument")
            {
                Shown += delegate { dgvSwiadczenie.ClearSelection(); };
                dgvSwiadczenie.DataSource = from swiad in baza.świadczenies
                                            where swiad.id_dokumentu == Convert.ToInt32(zaznaczony_dok)
                                            select swiad;
            }
            else
            {
                Shown += delegate { dgvSwiadczenie.ClearSelection(); };
                dgvSwiadczenie.DataSource = from pet in baza.petents
                                            join dok in baza.dokumenties on pet.id_petent equals dok.id_petent
                                            join swi in baza.świadczenies on dok.id_dokumentu equals swi.id_dokumentu
                                            where pet.id_petent == Convert.ToInt32(zaznacz)
                                            select swi;
            }

        }

        private void tsbEdytuj_Click(object sender, EventArgs e)
        {
            if (zaznaczone_swiad != null)
            {
                Swiadczenie_Dodaj editswiad = new Swiadczenie_Dodaj(zaznaczone_swiad, zaznaczony_dok, false, petentOrDok, zaznacz);
                editswiad.FormClosed += editswiad_FormClosed;
                editswiad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano świadczenia.");
            }
        }

        private void editswiad_FormClosed(object sender, FormClosedEventArgs e)
        {
            zaznaczone_swiad = dgvSwiadczenie.Rows[0].Cells["idświadczeniaDataGridViewTextBoxColumn"].Value.ToString();
            zaznaczony_dok = dgvSwiadczenie.Rows[0].Cells["iddokumentuDataGridViewTextBoxColumn"].Value.ToString();
            if(p == "dokument")
            {
                Shown += delegate { dgvSwiadczenie.ClearSelection(); };
                dgvSwiadczenie.DataSource = from swiad in baza.świadczenies
                                            where swiad.id_dokumentu == Convert.ToInt32(zaznaczony_dok)
                                            select swiad;
            }
            else
            {
                Shown += delegate { dgvSwiadczenie.ClearSelection(); };
                dgvSwiadczenie.DataSource = from pet in baza.petents
                                            join dok in baza.dokumenties on pet.id_petent equals dok.id_petent
                                            join swi in baza.świadczenies on dok.id_dokumentu equals swi.id_dokumentu
                                            where pet.id_petent == Convert.ToInt32(zaznacz)
                                            select swi;
            }
        }

        private void dgvSwiadczenie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                zaznaczone_swiad = dgvSwiadczenie.Rows[e.RowIndex].Cells["idświadczeniaDataGridViewTextBoxColumn"].Value.ToString();
                zaznaczony_dok = dgvSwiadczenie.Rows[e.RowIndex].Cells["iddokumentuDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch { }
        }

        private void tsbOtworzDok_Click(object sender, EventArgs e)
        {
            if (zaznaczone_swiad != null) 
            {
                Swiadczenie_Podglad sp = new Swiadczenie_Podglad(zaznaczony_dok);
                sp.ShowDialog();
            }
            else { MessageBox.Show("Nie wybrano świadczenia."); }

        }
    }
}
