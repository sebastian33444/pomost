namespace POMOST_Lite
{
    partial class Dodaj_dokumenty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodaj_dokumenty));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDodaj = new System.Windows.Forms.ToolStripButton();
            this.tsbUsun = new System.Windows.Forms.ToolStripButton();
            this.tsbEdytuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbZamknij = new System.Windows.Forms.ToolStripButton();
            this.dgvDokumenty = new System.Windows.Forms.DataGridView();
            this.mopsDataSet = new POMOST_Lite.mopsDataSet();
            this.dokumentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokumentyTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.dokumentyTableAdapter();
            this.iddokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typdokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zawartośćdokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpetentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).BeginInit();
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
            this.tsbZamknij});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(482, 26);
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
            // 
            // tsbUsun
            // 
            this.tsbUsun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbUsun.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsun.Image")));
            this.tsbUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsun.Name = "tsbUsun";
            this.tsbUsun.Size = new System.Drawing.Size(128, 23);
            this.tsbUsun.Text = "Usuń dokument";
            // 
            // tsbEdytuj
            // 
            this.tsbEdytuj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdytuj.Image")));
            this.tsbEdytuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdytuj.Name = "tsbEdytuj";
            this.tsbEdytuj.Size = new System.Drawing.Size(134, 23);
            this.tsbEdytuj.Text = "Edytuj dokument";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbZamknij
            // 
            this.tsbZamknij.Image = ((System.Drawing.Image)(resources.GetObject("tsbZamknij.Image")));
            this.tsbZamknij.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZamknij.Name = "tsbZamknij";
            this.tsbZamknij.Size = new System.Drawing.Size(70, 23);
            this.tsbZamknij.Text = "Zamknij";
            // 
            // dgvDokumenty
            // 
            this.dgvDokumenty.AllowUserToAddRows = false;
            this.dgvDokumenty.AllowUserToDeleteRows = false;
            this.dgvDokumenty.AutoGenerateColumns = false;
            this.dgvDokumenty.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDokumenty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDokumenty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentuDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.typdokumentuDataGridViewTextBoxColumn,
            this.zawartośćdokumentuDataGridViewTextBoxColumn,
            this.idpetentDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn});
            this.dgvDokumenty.DataSource = this.dokumentyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDokumenty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDokumenty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDokumenty.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDokumenty.Location = new System.Drawing.Point(0, 26);
            this.dgvDokumenty.MultiSelect = false;
            this.dgvDokumenty.Name = "dgvDokumenty";
            this.dgvDokumenty.ReadOnly = true;
            this.dgvDokumenty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDokumenty.Size = new System.Drawing.Size(482, 400);
            this.dgvDokumenty.TabIndex = 1;
            // 
            // mopsDataSet
            // 
            this.mopsDataSet.DataSetName = "mopsDataSet";
            this.mopsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dokumentyBindingSource
            // 
            this.dokumentyBindingSource.DataMember = "dokumenty";
            this.dokumentyBindingSource.DataSource = this.mopsDataSet;
            // 
            // dokumentyTableAdapter
            // 
            this.dokumentyTableAdapter.ClearBeforeFill = true;
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
            // Dodaj_dokumenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 426);
            this.Controls.Add(this.dgvDokumenty);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Dodaj_dokumenty";
            this.ShowIcon = false;
            this.Text = "POMOST Lite";
            this.Load += new System.EventHandler(this.Dodaj_dokumenty_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDokumenty;
        private mopsDataSet mopsDataSet;
        private System.Windows.Forms.BindingSource dokumentyBindingSource;
        private mopsDataSetTableAdapters.dokumentyTableAdapter dokumentyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typdokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zawartośćdokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
    }
}