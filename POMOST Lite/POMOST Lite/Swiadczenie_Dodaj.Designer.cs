namespace POMOST_Lite
{
    partial class Swiadczenie_Dodaj
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bZapisz = new System.Windows.Forms.Button();
            this.bAnuluj = new System.Windows.Forms.Button();
            this.cbDokument = new System.Windows.Forms.ComboBox();
            this.dokumentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mopsDataSet = new POMOST_Lite.mopsDataSet();
            this.tbKwota = new System.Windows.Forms.TextBox();
            this.dokumentyTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.dokumentyTableAdapter();
            this.dokumentyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbSwiadczenie = new System.Windows.Forms.ComboBox();
            this.świadczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.świadczenieTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.świadczenieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.świadczenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kwota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operacja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(1, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nr dokument";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(90, 116);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // bZapisz
            // 
            this.bZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bZapisz.Location = new System.Drawing.Point(46, 321);
            this.bZapisz.Name = "bZapisz";
            this.bZapisz.Size = new System.Drawing.Size(75, 32);
            this.bZapisz.TabIndex = 6;
            this.bZapisz.Text = "Zapisz";
            this.bZapisz.UseVisualStyleBackColor = true;
            this.bZapisz.Click += new System.EventHandler(this.bZapisz_Click);
            // 
            // bAnuluj
            // 
            this.bAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAnuluj.Location = new System.Drawing.Point(127, 321);
            this.bAnuluj.Name = "bAnuluj";
            this.bAnuluj.Size = new System.Drawing.Size(75, 32);
            this.bAnuluj.TabIndex = 7;
            this.bAnuluj.Text = "Anuluj";
            this.bAnuluj.UseVisualStyleBackColor = true;
            this.bAnuluj.Click += new System.EventHandler(this.bAnuluj_Click);
            // 
            // cbDokument
            // 
            this.cbDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDokument.FormattingEnabled = true;
            this.cbDokument.Location = new System.Drawing.Point(90, 292);
            this.cbDokument.Name = "cbDokument";
            this.cbDokument.Size = new System.Drawing.Size(157, 24);
            this.cbDokument.TabIndex = 8;
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
            // tbKwota
            // 
            this.tbKwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbKwota.Location = new System.Drawing.Point(90, 44);
            this.tbKwota.Name = "tbKwota";
            this.tbKwota.Size = new System.Drawing.Size(157, 23);
            this.tbKwota.TabIndex = 10;
            // 
            // dokumentyTableAdapter
            // 
            this.dokumentyTableAdapter.ClearBeforeFill = true;
            // 
            // dokumentyBindingSource1
            // 
            this.dokumentyBindingSource1.DataMember = "dokumenty";
            this.dokumentyBindingSource1.DataSource = this.mopsDataSet;
            // 
            // cbSwiadczenie
            // 
            this.cbSwiadczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSwiadczenie.FormattingEnabled = true;
            this.cbSwiadczenie.Location = new System.Drawing.Point(92, 80);
            this.cbSwiadczenie.Name = "cbSwiadczenie";
            this.cbSwiadczenie.Size = new System.Drawing.Size(155, 24);
            this.cbSwiadczenie.TabIndex = 11;
            // 
            // świadczenieBindingSource
            // 
            this.świadczenieBindingSource.DataMember = "świadczenie";
            this.świadczenieBindingSource.DataSource = this.mopsDataSet;
            // 
            // świadczenieTableAdapter
            // 
            this.świadczenieTableAdapter.ClearBeforeFill = true;
            // 
            // Swiadczenie_Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 365);
            this.Controls.Add(this.cbSwiadczenie);
            this.Controls.Add(this.tbKwota);
            this.Controls.Add(this.cbDokument);
            this.Controls.Add(this.bAnuluj);
            this.Controls.Add(this.bZapisz);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Swiadczenie_Dodaj";
            this.ShowIcon = false;
            this.Text = "Dodawanie świadczenia";
            this.Load += new System.EventHandler(this.Swiadczenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.świadczenieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bZapisz;
        private System.Windows.Forms.Button bAnuluj;
        private System.Windows.Forms.ComboBox cbDokument;
        private System.Windows.Forms.TextBox tbKwota;
        private mopsDataSet mopsDataSet;
        private System.Windows.Forms.BindingSource dokumentyBindingSource;
        private mopsDataSetTableAdapters.dokumentyTableAdapter dokumentyTableAdapter;
        private System.Windows.Forms.BindingSource dokumentyBindingSource1;
        private System.Windows.Forms.ComboBox cbSwiadczenie;
        private System.Windows.Forms.BindingSource świadczenieBindingSource;
        public mopsDataSetTableAdapters.świadczenieTableAdapter świadczenieTableAdapter;
    }
}