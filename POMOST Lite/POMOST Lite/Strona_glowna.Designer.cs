namespace POMOST_Lite
{
    partial class Strona_glowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Strona_glowna));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.Wyloguj = new System.Windows.Forms.ToolStripMenuItem();
            this.dodaj_petenta = new System.Windows.Forms.ToolStripButton();
            this.usun_petenta = new System.Windows.Forms.ToolStripButton();
            this.edytuj_petenta = new System.Windows.Forms.ToolStripButton();
            this.wyszukaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.swiadczenia = new System.Windows.Forms.ToolStripButton();
            this.dokumenty = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslabelLogin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tslabelMiasto = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tslabelDzielnica = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mopsDataSet1 = new POMOST_Lite.mopsDataSet();
            this.dgvPetent = new System.Windows.Forms.DataGridView();
            this.idpetentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.województwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodpocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrulicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrmieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mopsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petentTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.petentTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.dodaj_petenta,
            this.usun_petenta,
            this.edytuj_petenta,
            this.wyszukaj,
            this.toolStripSeparator1,
            this.swiadczenia,
            this.dokumenty});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1187, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Wyloguj});
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(74, 23);
            this.menu.Text = "Menu";
            // 
            // Wyloguj
            // 
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(128, 24);
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // dodaj_petenta
            // 
            this.dodaj_petenta.Image = ((System.Drawing.Image)(resources.GetObject("dodaj_petenta.Image")));
            this.dodaj_petenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodaj_petenta.Name = "dodaj_petenta";
            this.dodaj_petenta.Size = new System.Drawing.Size(116, 23);
            this.dodaj_petenta.Text = "Dodaj petenta";
            // 
            // usun_petenta
            // 
            this.usun_petenta.Image = ((System.Drawing.Image)(resources.GetObject("usun_petenta.Image")));
            this.usun_petenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usun_petenta.Name = "usun_petenta";
            this.usun_petenta.Size = new System.Drawing.Size(112, 23);
            this.usun_petenta.Text = "Usuń petenta";
            this.usun_petenta.Click += new System.EventHandler(this.usun_petenta_Click);
            // 
            // edytuj_petenta
            // 
            this.edytuj_petenta.Image = ((System.Drawing.Image)(resources.GetObject("edytuj_petenta.Image")));
            this.edytuj_petenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edytuj_petenta.Name = "edytuj_petenta";
            this.edytuj_petenta.Size = new System.Drawing.Size(118, 23);
            this.edytuj_petenta.Text = "Edytuj petenta";
            // 
            // wyszukaj
            // 
            this.wyszukaj.Image = ((System.Drawing.Image)(resources.GetObject("wyszukaj.Image")));
            this.wyszukaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Size = new System.Drawing.Size(86, 23);
            this.wyszukaj.Text = "Wyszukaj";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // swiadczenia
            // 
            this.swiadczenia.Image = ((System.Drawing.Image)(resources.GetObject("swiadczenia.Image")));
            this.swiadczenia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.swiadczenia.Name = "swiadczenia";
            this.swiadczenia.Size = new System.Drawing.Size(101, 23);
            this.swiadczenia.Text = "Świadczenia";
            // 
            // dokumenty
            // 
            this.dokumenty.Image = ((System.Drawing.Image)(resources.GetObject("dokumenty.Image")));
            this.dokumenty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dokumenty.Name = "dokumenty";
            this.dokumenty.Size = new System.Drawing.Size(101, 23);
            this.dokumenty.Text = "Dokumenty";
            this.dokumenty.Click += new System.EventHandler(this.dokumenty_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tslabelLogin,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tslabelMiasto,
            this.toolStripSeparator3,
            this.toolStripLabel5,
            this.tslabelDzielnica,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 26);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1187, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "Login:";
            // 
            // tslabelLogin
            // 
            this.tslabelLogin.Name = "tslabelLogin";
            this.tslabelLogin.Size = new System.Drawing.Size(101, 22);
            this.tslabelLogin.Text = "toolStripLabel2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel3.Text = "Miasto:";
            // 
            // tslabelMiasto
            // 
            this.tslabelMiasto.Name = "tslabelMiasto";
            this.tslabelMiasto.Size = new System.Drawing.Size(101, 22);
            this.tslabelMiasto.Text = "toolStripLabel4";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel5.Text = "Dzielnica:";
            // 
            // tslabelDzielnica
            // 
            this.tslabelDzielnica.Name = "tslabelDzielnica";
            this.tslabelDzielnica.Size = new System.Drawing.Size(101, 22);
            this.tslabelDzielnica.Text = "toolStripLabel6";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mopsDataSet1
            // 
            this.mopsDataSet1.DataSetName = "mopsDataSet";
            this.mopsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPetent
            // 
            this.dgvPetent.AllowUserToAddRows = false;
            this.dgvPetent.AllowUserToDeleteRows = false;
            this.dgvPetent.AutoGenerateColumns = false;
            this.dgvPetent.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPetent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpetentDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.durDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.województwoDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.kodpocztowyDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.nrulicyDataGridViewTextBoxColumn,
            this.nrmieszkaniaDataGridViewTextBoxColumn,
            this.nrtelefonuDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn});
            this.dgvPetent.DataSource = this.petentBindingSource;
            this.dgvPetent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPetent.Location = new System.Drawing.Point(0, 51);
            this.dgvPetent.Name = "dgvPetent";
            this.dgvPetent.ReadOnly = true;
            this.dgvPetent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPetent.Size = new System.Drawing.Size(1187, 469);
            this.dgvPetent.TabIndex = 6;
            // 
            // idpetentDataGridViewTextBoxColumn
            // 
            this.idpetentDataGridViewTextBoxColumn.DataPropertyName = "id_petent";
            this.idpetentDataGridViewTextBoxColumn.HeaderText = "id_petent";
            this.idpetentDataGridViewTextBoxColumn.Name = "idpetentDataGridViewTextBoxColumn";
            this.idpetentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durDataGridViewTextBoxColumn
            // 
            this.durDataGridViewTextBoxColumn.DataPropertyName = "d_ur";
            this.durDataGridViewTextBoxColumn.HeaderText = "d_ur";
            this.durDataGridViewTextBoxColumn.Name = "durDataGridViewTextBoxColumn";
            this.durDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // województwoDataGridViewTextBoxColumn
            // 
            this.województwoDataGridViewTextBoxColumn.DataPropertyName = "województwo";
            this.województwoDataGridViewTextBoxColumn.HeaderText = "województwo";
            this.województwoDataGridViewTextBoxColumn.Name = "województwoDataGridViewTextBoxColumn";
            this.województwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            this.miastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodpocztowyDataGridViewTextBoxColumn
            // 
            this.kodpocztowyDataGridViewTextBoxColumn.DataPropertyName = "kod_pocztowy";
            this.kodpocztowyDataGridViewTextBoxColumn.HeaderText = "kod_pocztowy";
            this.kodpocztowyDataGridViewTextBoxColumn.Name = "kodpocztowyDataGridViewTextBoxColumn";
            this.kodpocztowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrulicyDataGridViewTextBoxColumn
            // 
            this.nrulicyDataGridViewTextBoxColumn.DataPropertyName = "nr_ulicy";
            this.nrulicyDataGridViewTextBoxColumn.HeaderText = "nr_ulicy";
            this.nrulicyDataGridViewTextBoxColumn.Name = "nrulicyDataGridViewTextBoxColumn";
            this.nrulicyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrmieszkaniaDataGridViewTextBoxColumn
            // 
            this.nrmieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "nr_mieszkania";
            this.nrmieszkaniaDataGridViewTextBoxColumn.HeaderText = "nr_mieszkania";
            this.nrmieszkaniaDataGridViewTextBoxColumn.Name = "nrmieszkaniaDataGridViewTextBoxColumn";
            this.nrmieszkaniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrtelefonuDataGridViewTextBoxColumn
            // 
            this.nrtelefonuDataGridViewTextBoxColumn.DataPropertyName = "nr_telefonu";
            this.nrtelefonuDataGridViewTextBoxColumn.HeaderText = "nr_telefonu";
            this.nrtelefonuDataGridViewTextBoxColumn.Name = "nrtelefonuDataGridViewTextBoxColumn";
            this.nrtelefonuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpracownikDataGridViewTextBoxColumn
            // 
            this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.HeaderText = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
            this.idpracownikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petentBindingSource
            // 
            this.petentBindingSource.DataMember = "petent";
            this.petentBindingSource.DataSource = this.mopsDataSet1BindingSource;
            // 
            // mopsDataSet1BindingSource
            // 
            this.mopsDataSet1BindingSource.DataSource = this.mopsDataSet1;
            this.mopsDataSet1BindingSource.Position = 0;
            // 
            // petentTableAdapter
            // 
            this.petentTableAdapter.ClearBeforeFill = true;
            // 
            // Strona_glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1187, 520);
            this.Controls.Add(this.dgvPetent);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Strona_glowna";
            this.ShowIcon = false;
            this.Text = "POMOST Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Strona_glowna_FormClosed);
            this.Load += new System.EventHandler(this.Strona_glowna_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menu;
        private System.Windows.Forms.ToolStripMenuItem Wyloguj;
        private System.Windows.Forms.ToolStripButton dodaj_petenta;
        private System.Windows.Forms.ToolStripButton usun_petenta;
        private System.Windows.Forms.ToolStripButton edytuj_petenta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton wyszukaj;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslabelLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel tslabelMiasto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel tslabelDzielnica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private mopsDataSet mopsDataSet1;
        private System.Windows.Forms.DataGridView dgvPetent;
        private System.Windows.Forms.BindingSource mopsDataSet1BindingSource;
        private System.Windows.Forms.BindingSource petentBindingSource;
        private mopsDataSetTableAdapters.petentTableAdapter petentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn województwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodpocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrulicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrmieszkaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton swiadczenia;
        private System.Windows.Forms.ToolStripButton dokumenty;
    }
}