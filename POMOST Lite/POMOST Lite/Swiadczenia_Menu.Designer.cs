﻿namespace POMOST_Lite
{
    partial class Swiadczenia_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swiadczenia_Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDodaj = new System.Windows.Forms.ToolStripButton();
            this.tsbUsun = new System.Windows.Forms.ToolStripButton();
            this.tsbEdytuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOtworzDok = new System.Windows.Forms.ToolStripButton();
            this.tsbZamknij = new System.Windows.Forms.ToolStripButton();
            this.dgvSwiadczenie = new System.Windows.Forms.DataGridView();
            this.idświadczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.świadczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mopsDataSet = new POMOST_Lite.mopsDataSet();
            this.świadczenieTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.świadczenieTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwiadczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.świadczenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDodaj,
            this.tsbUsun,
            this.tsbEdytuj,
            this.toolStripSeparator1,
            this.tsbOtworzDok,
            this.tsbZamknij});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDodaj
            // 
            this.tsbDodaj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbDodaj.Image = ((System.Drawing.Image)(resources.GetObject("tsbDodaj.Image")));
            this.tsbDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDodaj.Name = "tsbDodaj";
            this.tsbDodaj.Size = new System.Drawing.Size(140, 23);
            this.tsbDodaj.Text = "Dodaj świadczenie";
            this.tsbDodaj.Click += new System.EventHandler(this.tsbDodaj_Click);
            // 
            // tsbUsun
            // 
            this.tsbUsun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbUsun.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsun.Image")));
            this.tsbUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsun.Name = "tsbUsun";
            this.tsbUsun.Size = new System.Drawing.Size(136, 23);
            this.tsbUsun.Text = "Usuń świadczenie";
            this.tsbUsun.Click += new System.EventHandler(this.tsbUsun_Click);
            // 
            // tsbEdytuj
            // 
            this.tsbEdytuj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdytuj.Image")));
            this.tsbEdytuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdytuj.Name = "tsbEdytuj";
            this.tsbEdytuj.Size = new System.Drawing.Size(142, 23);
            this.tsbEdytuj.Text = "Edytuj świadczenie";
            this.tsbEdytuj.Click += new System.EventHandler(this.tsbEdytuj_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbOtworzDok
            // 
            this.tsbOtworzDok.Image = ((System.Drawing.Image)(resources.GetObject("tsbOtworzDok.Image")));
            this.tsbOtworzDok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOtworzDok.Name = "tsbOtworzDok";
            this.tsbOtworzDok.Size = new System.Drawing.Size(112, 23);
            this.tsbOtworzDok.Text = "Otwórz dokument";
            this.tsbOtworzDok.Click += new System.EventHandler(this.tsbOtworzDok_Click);
            // 
            // tsbZamknij
            // 
            this.tsbZamknij.Image = ((System.Drawing.Image)(resources.GetObject("tsbZamknij.Image")));
            this.tsbZamknij.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZamknij.Name = "tsbZamknij";
            this.tsbZamknij.Size = new System.Drawing.Size(63, 23);
            this.tsbZamknij.Text = "Zamknij";
            this.tsbZamknij.Click += new System.EventHandler(this.tsbZamknij_Click);
            // 
            // dgvSwiadczenie
            // 
            this.dgvSwiadczenie.AllowUserToAddRows = false;
            this.dgvSwiadczenie.AllowUserToDeleteRows = false;
            this.dgvSwiadczenie.AutoGenerateColumns = false;
            this.dgvSwiadczenie.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSwiadczenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwiadczenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idświadczeniaDataGridViewTextBoxColumn,
            this.kwotaDataGridViewTextBoxColumn,
            this.operacjaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn,
            this.iddokumentuDataGridViewTextBoxColumn});
            this.dgvSwiadczenie.DataSource = this.świadczenieBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSwiadczenie.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSwiadczenie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSwiadczenie.GridColor = System.Drawing.Color.DarkRed;
            this.dgvSwiadczenie.Location = new System.Drawing.Point(0, 26);
            this.dgvSwiadczenie.MultiSelect = false;
            this.dgvSwiadczenie.Name = "dgvSwiadczenie";
            this.dgvSwiadczenie.ReadOnly = true;
            this.dgvSwiadczenie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSwiadczenie.Size = new System.Drawing.Size(684, 426);
            this.dgvSwiadczenie.TabIndex = 2;
            this.dgvSwiadczenie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSwiadczenie_CellClick);
            // 
            // idświadczeniaDataGridViewTextBoxColumn
            // 
            this.idświadczeniaDataGridViewTextBoxColumn.DataPropertyName = "id_świadczenia";
            this.idświadczeniaDataGridViewTextBoxColumn.HeaderText = "id_świadczenia";
            this.idświadczeniaDataGridViewTextBoxColumn.Name = "idświadczeniaDataGridViewTextBoxColumn";
            this.idświadczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idświadczeniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kwotaDataGridViewTextBoxColumn
            // 
            this.kwotaDataGridViewTextBoxColumn.DataPropertyName = "kwota";
            this.kwotaDataGridViewTextBoxColumn.HeaderText = "kwota";
            this.kwotaDataGridViewTextBoxColumn.Name = "kwotaDataGridViewTextBoxColumn";
            this.kwotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operacjaDataGridViewTextBoxColumn
            // 
            this.operacjaDataGridViewTextBoxColumn.DataPropertyName = "operacja";
            this.operacjaDataGridViewTextBoxColumn.HeaderText = "operacja";
            this.operacjaDataGridViewTextBoxColumn.Name = "operacjaDataGridViewTextBoxColumn";
            this.operacjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpracownikDataGridViewTextBoxColumn
            // 
            this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.HeaderText = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
            this.idpracownikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpracownikDataGridViewTextBoxColumn.Visible = false;
            // 
            // iddokumentuDataGridViewTextBoxColumn
            // 
            this.iddokumentuDataGridViewTextBoxColumn.DataPropertyName = "id_dokumentu";
            this.iddokumentuDataGridViewTextBoxColumn.HeaderText = "nr dokumentu";
            this.iddokumentuDataGridViewTextBoxColumn.Name = "iddokumentuDataGridViewTextBoxColumn";
            this.iddokumentuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // świadczenieBindingSource
            // 
            this.świadczenieBindingSource.DataMember = "świadczenie";
            this.świadczenieBindingSource.DataSource = this.mopsDataSet;
            // 
            // mopsDataSet
            // 
            this.mopsDataSet.DataSetName = "mopsDataSet";
            this.mopsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // świadczenieTableAdapter
            // 
            this.świadczenieTableAdapter.ClearBeforeFill = true;
            // 
            // Swiadczenia_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 452);
            this.Controls.Add(this.dgvSwiadczenie);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Swiadczenia_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie świadczeniami";
            this.Load += new System.EventHandler(this.Dodaj_swiadczenia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwiadczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.świadczenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDodaj;
        private System.Windows.Forms.ToolStripButton tsbUsun;
        private System.Windows.Forms.ToolStripButton tsbEdytuj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbZamknij;
        private System.Windows.Forms.DataGridView dgvSwiadczenie;
        private mopsDataSet mopsDataSet;
        private System.Windows.Forms.BindingSource świadczenieBindingSource;
        private System.Windows.Forms.ToolStripButton tsbOtworzDok;
        public mopsDataSetTableAdapters.świadczenieTableAdapter świadczenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idświadczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentuDataGridViewTextBoxColumn;
    }
}