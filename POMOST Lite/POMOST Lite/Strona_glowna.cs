﻿using System;
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
    public partial class Strona_glowna : Form
    {
        DataClassesDataContext baza = new DataClassesDataContext();
        private string p;
        private bool admin = false;
        private int id_prac;
        private string zaznacz;

        public Strona_glowna(string p)
        {
            InitializeComponent();
            this.dgvPetent.ClearSelection();
            this.dgvPetent.Refresh();
            this.p = p;
           foreach(pracownik prac in baza.pracowniks.Where(prac => prac.login == p))
           {
               tslabelLogin.Text = prac.login.ToString();
               tslabelMiasto.Text = prac.miasto.ToString();
               tslabelDzielnica.Text = prac.dzielnica.ToString();
               admin = prac.admin;
               id_prac = prac.id_pracownik;
           }
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
            this.Hide();
        }

        private void Strona_glowna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Strona_glowna_Load(object sender, EventArgs e)
        {
            if(admin == true)
            {
                this.petentTableAdapter.Fill(this.mopsDataSet1.petent);
            }
            else
            {
                dgvPetent.DataSource = from p in baza.petents
                                       where p.id_pracownik == id_prac
                                       select p;
            }
        }

        private void usun_petenta_Click(object sender, EventArgs e)
        {            
            
            try
            {
                var dokasacji = from p in baza.petents where p.id_petent == Convert.ToInt32(zaznacz) select p;
                baza.petents.DeleteAllOnSubmit(dokasacji);
                baza.SubmitChanges();
                dgvPetent.Rows.RemoveAt(this.dgvPetent.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Nie można usunąć petenta, do którego są podpięte dokumenty i świadczenia.");
            }
        }

        private void dokumenty_Click(object sender, EventArgs e)
        {
            Dokumenty d = new Dokumenty();
            d.Show(); 
        }

        private void dodaj_petenta_Click(object sender, EventArgs e)
        {
            Dodaj_petenta add = new Dodaj_petenta(p);
            add.Show();
        }

        private void dgvPetent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            zaznacz = dgvPetent.Rows[e.RowIndex].Cells["idpetentDataGridViewTextBoxColumn"].Value.ToString();
            //MessageBox.Show(zaznacz);
        }

        private void edytuj_petenta_Click(object sender, EventArgs e)
        {
            Edytuj_petenta edit = new Edytuj_petenta(zaznacz, p);
            edit.Show();
        }


    }
}
