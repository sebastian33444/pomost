namespace POMOST_Lite
{
    partial class Dokumenty_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dokumenty_Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDodaj = new System.Windows.Forms.ToolStripButton();
            this.tsbUsun = new System.Windows.Forms.ToolStripButton();
            this.tsbEdytuj = new System.Windows.Forms.ToolStripButton();
            this.tsbDrukuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOtworzSwiad = new System.Windows.Forms.ToolStripButton();
            this.Odswierz = new System.Windows.Forms.ToolStripButton();
            this.tsbZamknij = new System.Windows.Forms.ToolStripButton();
            this.dokumentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mopsDataSet = new POMOST_Lite.mopsDataSet();
            this.dokumentyTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.dokumentyTableAdapter();
            this.dgvDokumenty = new System.Windows.Forms.DataGridView();
            this.iddokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typdokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zawartośćdokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpetentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.WBPodglad_dokumentu = new System.Windows.Forms.WebBrowser();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource1)).BeginInit();
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
            this.tsbDrukuj,
            this.toolStripSeparator1,
            this.tsbOtworzSwiad,
            this.Odswierz,
            this.tsbZamknij});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDodaj
            // 
            this.tsbDodaj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbDodaj.Image = ((System.Drawing.Image)(resources.GetObject("tsbDodaj.Image")));
            this.tsbDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDodaj.Name = "tsbDodaj";
            this.tsbDodaj.Size = new System.Drawing.Size(132, 23);
            this.tsbDodaj.Text = "Dodaj dokument";
            this.tsbDodaj.Click += new System.EventHandler(this.tsbDodaj_Click);
            // 
            // tsbUsun
            // 
            this.tsbUsun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbUsun.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsun.Image")));
            this.tsbUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsun.Name = "tsbUsun";
            this.tsbUsun.Size = new System.Drawing.Size(128, 23);
            this.tsbUsun.Text = "Usuń dokument";
            this.tsbUsun.Click += new System.EventHandler(this.tsbUsun_Click);
            // 
            // tsbEdytuj
            // 
            this.tsbEdytuj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdytuj.Image")));
            this.tsbEdytuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdytuj.Name = "tsbEdytuj";
            this.tsbEdytuj.Size = new System.Drawing.Size(134, 23);
            this.tsbEdytuj.Text = "Edytuj dokument";
            this.tsbEdytuj.Click += new System.EventHandler(this.tsbEdytuj_Click);
            // 
            // tsbDrukuj
            // 
            this.tsbDrukuj.Image = ((System.Drawing.Image)(resources.GetObject("tsbDrukuj.Image")));
            this.tsbDrukuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDrukuj.Name = "tsbDrukuj";
            this.tsbDrukuj.Size = new System.Drawing.Size(62, 23);
            this.tsbDrukuj.Text = "Drukuj";
            this.tsbDrukuj.Click += new System.EventHandler(this.tsbDrukuj_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbOtworzSwiad
            // 
            this.tsbOtworzSwiad.Image = ((System.Drawing.Image)(resources.GetObject("tsbOtworzSwiad.Image")));
            this.tsbOtworzSwiad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOtworzSwiad.Name = "tsbOtworzSwiad";
            this.tsbOtworzSwiad.Size = new System.Drawing.Size(131, 23);
            this.tsbOtworzSwiad.Text = "Otwórz świadczenia";
            this.tsbOtworzSwiad.Click += new System.EventHandler(this.tsbOtworzSwiad_Click);
            // 
            // Odswierz
            // 
            this.Odswierz.Image = ((System.Drawing.Image)(resources.GetObject("Odswierz.Image")));
            this.Odswierz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Odswierz.Name = "Odswierz";
            this.Odswierz.Size = new System.Drawing.Size(75, 23);
            this.Odswierz.Text = "Odświerz";
            this.Odswierz.Click += new System.EventHandler(this.Odswierz_Click);
            // 
            // tsbZamknij
            // 
            this.tsbZamknij.Image = ((System.Drawing.Image)(resources.GetObject("tsbZamknij.Image")));
            this.tsbZamknij.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZamknij.Name = "tsbZamknij";
            this.tsbZamknij.Size = new System.Drawing.Size(70, 23);
            this.tsbZamknij.Text = "Zamknij";
            this.tsbZamknij.Click += new System.EventHandler(this.tsbZamknij_Click);
            // 
            // dokumentyBindingSource
            // 
            this.dokumentyBindingSource.DataMember = "dokumenty";
            this.dokumentyBindingSource.DataSource = this.mopsDataSet;
            // 
            // mopsDataSet
            // 
            this.mopsDataSet.DataSetName = "mopsDataSet";
            this.mopsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dokumentyTableAdapter
            // 
            this.dokumentyTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDokumenty
            // 
            this.dgvDokumenty.AllowUserToAddRows = false;
            this.dgvDokumenty.AllowUserToDeleteRows = false;
            this.dgvDokumenty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDokumenty.AutoGenerateColumns = false;
            this.dgvDokumenty.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDokumenty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentuDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.typdokumentuDataGridViewTextBoxColumn,
            this.zawartośćdokumentuDataGridViewTextBoxColumn,
            this.idpetentDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn});
            this.dgvDokumenty.DataSource = this.dokumentyBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDokumenty.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDokumenty.GridColor = System.Drawing.Color.DarkRed;
            this.dgvDokumenty.Location = new System.Drawing.Point(0, 26);
            this.dgvDokumenty.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDokumenty.MultiSelect = false;
            this.dgvDokumenty.Name = "dgvDokumenty";
            this.dgvDokumenty.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDokumenty.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDokumenty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDokumenty.Size = new System.Drawing.Size(349, 343);
            this.dgvDokumenty.TabIndex = 1;
            this.dgvDokumenty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDokumenty_CellClick);
            // 
            // iddokumentuDataGridViewTextBoxColumn
            // 
            this.iddokumentuDataGridViewTextBoxColumn.DataPropertyName = "id_dokumentu";
            this.iddokumentuDataGridViewTextBoxColumn.HeaderText = "id dokumentu";
            this.iddokumentuDataGridViewTextBoxColumn.Name = "iddokumentuDataGridViewTextBoxColumn";
            this.iddokumentuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typdokumentuDataGridViewTextBoxColumn
            // 
            this.typdokumentuDataGridViewTextBoxColumn.DataPropertyName = "typ_dokumentu";
            this.typdokumentuDataGridViewTextBoxColumn.HeaderText = "typ dokumentu";
            this.typdokumentuDataGridViewTextBoxColumn.Name = "typdokumentuDataGridViewTextBoxColumn";
            this.typdokumentuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zawartośćdokumentuDataGridViewTextBoxColumn
            // 
            this.zawartośćdokumentuDataGridViewTextBoxColumn.DataPropertyName = "zawartość_dokumentu";
            this.zawartośćdokumentuDataGridViewTextBoxColumn.HeaderText = "zawartość_dokumentu";
            this.zawartośćdokumentuDataGridViewTextBoxColumn.Name = "zawartośćdokumentuDataGridViewTextBoxColumn";
            this.zawartośćdokumentuDataGridViewTextBoxColumn.ReadOnly = true;
            this.zawartośćdokumentuDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpetentDataGridViewTextBoxColumn
            // 
            this.idpetentDataGridViewTextBoxColumn.DataPropertyName = "id_petent";
            this.idpetentDataGridViewTextBoxColumn.HeaderText = "id_petent";
            this.idpetentDataGridViewTextBoxColumn.Name = "idpetentDataGridViewTextBoxColumn";
            this.idpetentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpetentDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpracownikDataGridViewTextBoxColumn
            // 
            this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.HeaderText = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
            this.idpracownikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpracownikDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentyBindingSource1
            // 
            this.dokumentyBindingSource1.DataMember = "dokumenty";
            this.dokumentyBindingSource1.DataSource = this.mopsDataSet;
            // 
            // WBPodglad_dokumentu
            // 
            this.WBPodglad_dokumentu.Dock = System.Windows.Forms.DockStyle.Right;
            this.WBPodglad_dokumentu.Location = new System.Drawing.Point(354, 26);
            this.WBPodglad_dokumentu.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBPodglad_dokumentu.Name = "WBPodglad_dokumentu";
            this.WBPodglad_dokumentu.Size = new System.Drawing.Size(665, 343);
            this.WBPodglad_dokumentu.TabIndex = 4;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Dokumenty_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1019, 369);
            this.Controls.Add(this.WBPodglad_dokumentu);
            this.Controls.Add(this.dgvDokumenty);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "Dokumenty_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMOST Lite";
            this.Load += new System.EventHandler(this.Dodaj_dokumenty_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource1)).EndInit();
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
        private mopsDataSet mopsDataSet;
        private System.Windows.Forms.BindingSource dokumentyBindingSource;
        private mopsDataSetTableAdapters.dokumentyTableAdapter dokumentyTableAdapter;
        private System.Windows.Forms.DataGridView dgvDokumenty;
        private System.Windows.Forms.BindingSource dokumentyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typdokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zawartośćdokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbOtworzSwiad;
        private System.Windows.Forms.ToolStripButton Odswierz;
        private System.Windows.Forms.WebBrowser WBPodglad_dokumentu;
        private System.Windows.Forms.ToolStripButton tsbDrukuj;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}