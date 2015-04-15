namespace POMOST_Lite
{
    partial class Edytuj_petenta
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
            this.label15 = new System.Windows.Forms.Label();
            this.Kalendarz = new System.Windows.Forms.MonthCalendar();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAnuluj = new System.Windows.Forms.Button();
            this.bZapisz = new System.Windows.Forms.Button();
            this.tbMieszkanie = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbNrUl = new System.Windows.Forms.TextBox();
            this.tbUlica = new System.Windows.Forms.TextBox();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.tbMiasto = new System.Windows.Forms.TextBox();
            this.tbWojewodztwo = new System.Windows.Forms.TextBox();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.mopsDataSet = new POMOST_Lite.mopsDataSet();
            this.mopsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.pracownikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(284, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Edytuj petenta";
            // 
            // Kalendarz
            // 
            this.Kalendarz.Location = new System.Drawing.Point(503, 66);
            this.Kalendarz.Name = "Kalendarz";
            this.Kalendarz.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(12, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Pracownik prowadzący";
            // 
            // cbPracownik
            // 
            this.cbPracownik.DataSource = this.pracownikBindingSource;
            this.cbPracownik.DisplayMember = "login";
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(171, 297);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(320, 24);
            this.cbPracownik.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(13, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Nazwisko";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(13, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Nr telefonu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(13, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Nr mieszkania";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(12, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Nr ulicy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Ulica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Kod pocztowy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(13, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Miasto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Województwo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "PESEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(532, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Data urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Imię";
            // 
            // bAnuluj
            // 
            this.bAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAnuluj.Location = new System.Drawing.Point(585, 289);
            this.bAnuluj.Name = "bAnuluj";
            this.bAnuluj.Size = new System.Drawing.Size(75, 32);
            this.bAnuluj.TabIndex = 44;
            this.bAnuluj.Text = "Anuluj";
            this.bAnuluj.UseVisualStyleBackColor = true;
            this.bAnuluj.Click += new System.EventHandler(this.bAnuluj_Click);
            // 
            // bZapisz
            // 
            this.bZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bZapisz.Location = new System.Drawing.Point(503, 289);
            this.bZapisz.Name = "bZapisz";
            this.bZapisz.Size = new System.Drawing.Size(75, 32);
            this.bZapisz.TabIndex = 43;
            this.bZapisz.Text = "Zapisz";
            this.bZapisz.UseVisualStyleBackColor = true;
            this.bZapisz.Click += new System.EventHandler(this.bZapisz_Click);
            // 
            // tbMieszkanie
            // 
            this.tbMieszkanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMieszkanie.Location = new System.Drawing.Point(171, 246);
            this.tbMieszkanie.MaxLength = 3;
            this.tbMieszkanie.Name = "tbMieszkanie";
            this.tbMieszkanie.Size = new System.Drawing.Size(320, 22);
            this.tbMieszkanie.TabIndex = 40;
            this.tbMieszkanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMieszkanie_KeyPress);
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazwisko.Location = new System.Drawing.Point(171, 63);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(320, 22);
            this.tbNazwisko.TabIndex = 32;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTelefon.Location = new System.Drawing.Point(171, 272);
            this.tbTelefon.MaxLength = 10;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(320, 22);
            this.tbTelefon.TabIndex = 41;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            // 
            // tbNrUl
            // 
            this.tbNrUl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNrUl.Location = new System.Drawing.Point(171, 220);
            this.tbNrUl.MaxLength = 3;
            this.tbNrUl.Name = "tbNrUl";
            this.tbNrUl.Size = new System.Drawing.Size(320, 22);
            this.tbNrUl.TabIndex = 39;
            this.tbNrUl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrUl_KeyPress);
            // 
            // tbUlica
            // 
            this.tbUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUlica.Location = new System.Drawing.Point(171, 194);
            this.tbUlica.Name = "tbUlica";
            this.tbUlica.Size = new System.Drawing.Size(320, 22);
            this.tbUlica.TabIndex = 38;
            // 
            // tbKod
            // 
            this.tbKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKod.Location = new System.Drawing.Point(171, 168);
            this.tbKod.MaxLength = 5;
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(320, 22);
            this.tbKod.TabIndex = 37;
            this.tbKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKod_KeyPress);
            // 
            // tbMiasto
            // 
            this.tbMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMiasto.Location = new System.Drawing.Point(171, 142);
            this.tbMiasto.Name = "tbMiasto";
            this.tbMiasto.Size = new System.Drawing.Size(320, 22);
            this.tbMiasto.TabIndex = 36;
            // 
            // tbWojewodztwo
            // 
            this.tbWojewodztwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbWojewodztwo.Location = new System.Drawing.Point(171, 116);
            this.tbWojewodztwo.Name = "tbWojewodztwo";
            this.tbWojewodztwo.Size = new System.Drawing.Size(320, 22);
            this.tbWojewodztwo.TabIndex = 35;
            // 
            // tbPesel
            // 
            this.tbPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPesel.Location = new System.Drawing.Point(171, 90);
            this.tbPesel.MaxLength = 11;
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(320, 22);
            this.tbPesel.TabIndex = 34;
            this.tbPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesel_KeyPress);
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImie.Location = new System.Drawing.Point(171, 37);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(320, 22);
            this.tbImie.TabIndex = 31;
            // 
            // mopsDataSet
            // 
            this.mopsDataSet.DataSetName = "mopsDataSet";
            this.mopsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mopsDataSetBindingSource
            // 
            this.mopsDataSetBindingSource.DataSource = this.mopsDataSet;
            this.mopsDataSetBindingSource.Position = 0;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "pracownik";
            this.pracownikBindingSource.DataSource = this.mopsDataSetBindingSource;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // Edytuj_petenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 329);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Kalendarz);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAnuluj);
            this.Controls.Add(this.bZapisz);
            this.Controls.Add(this.tbMieszkanie);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNrUl);
            this.Controls.Add(this.tbUlica);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.tbMiasto);
            this.Controls.Add(this.tbWojewodztwo);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.tbImie);
            this.MaximizeBox = false;
            this.Name = "Edytuj_petenta";
            this.ShowIcon = false;
            this.Text = "POMOST Lite";
            this.Load += new System.EventHandler(this.Edytuj_petenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MonthCalendar Kalendarz;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAnuluj;
        private System.Windows.Forms.Button bZapisz;
        private System.Windows.Forms.TextBox tbMieszkanie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbNrUl;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.TextBox tbMiasto;
        private System.Windows.Forms.TextBox tbWojewodztwo;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.BindingSource mopsDataSetBindingSource;
        private mopsDataSet mopsDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private mopsDataSetTableAdapters.pracownikTableAdapter pracownikTableAdapter;
    }
}