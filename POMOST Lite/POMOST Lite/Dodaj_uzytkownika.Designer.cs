namespace POMOST_Lite
{
    partial class Dodaj_uzytkownika
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
            this.dodaj = new System.Windows.Forms.Button();
            this.haslol = new System.Windows.Forms.TextBox();
            this.nazwa_uzytkownika = new System.Windows.Forms.TextBox();
            this.label_haslo = new System.Windows.Forms.Label();
            this.label_uzytkownik = new System.Windows.Forms.Label();
            this.wroc = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.nazwiskol = new System.Windows.Forms.TextBox();
            this.imiel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.miastol = new System.Windows.Forms.TextBox();
            this.dzielnical = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edytuj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.lbPracownicy = new System.Windows.Forms.ListBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.zapisz_edycja = new System.Windows.Forms.Button();
            this.anuluj_edycja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hasloponl = new System.Windows.Forms.TextBox();
            this.zapisz_dodaj = new System.Windows.Forms.Button();
            this.anuluj_dodaj = new System.Windows.Forms.Button();
            this.mopsDataSet = new POMOST_Lite.mopsDataSet();
            this.mopsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikTableAdapter = new POMOST_Lite.mopsDataSetTableAdapters.pracownikTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lCzyAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dodaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dodaj.Location = new System.Drawing.Point(473, 285);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 32);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // haslol
            // 
            this.haslol.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.haslol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.haslol.Location = new System.Drawing.Point(147, 84);
            this.haslol.Name = "haslol";
            this.haslol.PasswordChar = '*';
            this.haslol.Size = new System.Drawing.Size(320, 23);
            this.haslol.TabIndex = 4;
            // 
            // nazwa_uzytkownika
            // 
            this.nazwa_uzytkownika.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.nazwa_uzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazwa_uzytkownika.Location = new System.Drawing.Point(147, 55);
            this.nazwa_uzytkownika.Name = "nazwa_uzytkownika";
            this.nazwa_uzytkownika.Size = new System.Drawing.Size(320, 23);
            this.nazwa_uzytkownika.TabIndex = 3;
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_haslo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_haslo.Location = new System.Drawing.Point(97, 87);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(44, 17);
            this.label_haslo.TabIndex = 30;
            this.label_haslo.Text = "Hasło";
            // 
            // label_uzytkownik
            // 
            this.label_uzytkownik.AutoSize = true;
            this.label_uzytkownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_uzytkownik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_uzytkownik.Location = new System.Drawing.Point(11, 58);
            this.label_uzytkownik.Name = "label_uzytkownik";
            this.label_uzytkownik.Size = new System.Drawing.Size(130, 17);
            this.label_uzytkownik.TabIndex = 30;
            this.label_uzytkownik.Text = "Nazwa użytkownika";
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wroc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wroc.Location = new System.Drawing.Point(550, 322);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 3;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.info.Location = new System.Drawing.Point(193, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(206, 17);
            this.info.TabIndex = 29;
            this.info.Text = "Zarządzanie użytkownikami";
            // 
            // nazwiskol
            // 
            this.nazwiskol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazwiskol.Location = new System.Drawing.Point(147, 171);
            this.nazwiskol.Name = "nazwiskol";
            this.nazwiskol.Size = new System.Drawing.Size(320, 23);
            this.nazwiskol.TabIndex = 7;
            // 
            // imiel
            // 
            this.imiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imiel.Location = new System.Drawing.Point(147, 142);
            this.imiel.Name = "imiel";
            this.imiel.Size = new System.Drawing.Size(320, 23);
            this.imiel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(76, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(108, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Imię";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(76, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dzielnica";
            // 
            // miastol
            // 
            this.miastol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.miastol.Location = new System.Drawing.Point(148, 228);
            this.miastol.Name = "miastol";
            this.miastol.Size = new System.Drawing.Size(320, 23);
            this.miastol.TabIndex = 9;
            // 
            // dzielnical
            // 
            this.dzielnical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dzielnical.Location = new System.Drawing.Point(147, 200);
            this.dzielnical.Name = "dzielnical";
            this.dzielnical.Size = new System.Drawing.Size(320, 23);
            this.dzielnical.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(92, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Miasto";
            // 
            // edytuj
            // 
            this.edytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edytuj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edytuj.Location = new System.Drawing.Point(473, 322);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(76, 32);
            this.edytuj.TabIndex = 2;
            this.edytuj.Text = "Edytuj";
            this.edytuj.UseVisualStyleBackColor = true;
            this.edytuj.Click += new System.EventHandler(this.edytuj_Click);
            // 
            // usun
            // 
            this.usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usun.Location = new System.Drawing.Point(550, 284);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(76, 32);
            this.usun.TabIndex = 1;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // lbPracownicy
            // 
            this.lbPracownicy.ColumnWidth = 20;
            this.lbPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPracownicy.FormattingEnabled = true;
            this.lbPracownicy.ItemHeight = 16;
            this.lbPracownicy.Location = new System.Drawing.Point(473, 55);
            this.lbPracownicy.Name = "lbPracownicy";
            this.lbPracownicy.Size = new System.Drawing.Size(153, 196);
            this.lbPracownicy.TabIndex = 35;
            this.lbPracownicy.Click += new System.EventHandler(this.lbPracownicy_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAdmin.Location = new System.Drawing.Point(56, 256);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAdmin.Size = new System.Drawing.Size(111, 21);
            this.checkBoxAdmin.TabIndex = 10;
            this.checkBoxAdmin.Text = "Administracja";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // zapisz_edycja
            // 
            this.zapisz_edycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zapisz_edycja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zapisz_edycja.Location = new System.Drawing.Point(196, 284);
            this.zapisz_edycja.Name = "zapisz_edycja";
            this.zapisz_edycja.Size = new System.Drawing.Size(76, 32);
            this.zapisz_edycja.TabIndex = 11;
            this.zapisz_edycja.Text = "Zapisz";
            this.zapisz_edycja.UseVisualStyleBackColor = true;
            this.zapisz_edycja.Click += new System.EventHandler(this.zapisz_edycja_Click);
            // 
            // anuluj_edycja
            // 
            this.anuluj_edycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.anuluj_edycja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.anuluj_edycja.Location = new System.Drawing.Point(278, 284);
            this.anuluj_edycja.Name = "anuluj_edycja";
            this.anuluj_edycja.Size = new System.Drawing.Size(75, 32);
            this.anuluj_edycja.TabIndex = 12;
            this.anuluj_edycja.Text = "Anuluj";
            this.anuluj_edycja.UseVisualStyleBackColor = true;
            this.anuluj_edycja.Click += new System.EventHandler(this.anuluj_edycja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ponów hasło";
            // 
            // hasloponl
            // 
            this.hasloponl.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hasloponl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hasloponl.Location = new System.Drawing.Point(147, 112);
            this.hasloponl.Name = "hasloponl";
            this.hasloponl.PasswordChar = '*';
            this.hasloponl.Size = new System.Drawing.Size(320, 23);
            this.hasloponl.TabIndex = 5;
            // 
            // zapisz_dodaj
            // 
            this.zapisz_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zapisz_dodaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zapisz_dodaj.Location = new System.Drawing.Point(196, 270);
            this.zapisz_dodaj.Name = "zapisz_dodaj";
            this.zapisz_dodaj.Size = new System.Drawing.Size(76, 32);
            this.zapisz_dodaj.TabIndex = 11;
            this.zapisz_dodaj.Text = "Zapisz";
            this.zapisz_dodaj.UseVisualStyleBackColor = true;
            this.zapisz_dodaj.Click += new System.EventHandler(this.zapisz_dodaj_Click);
            // 
            // anuluj_dodaj
            // 
            this.anuluj_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.anuluj_dodaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.anuluj_dodaj.Location = new System.Drawing.Point(278, 270);
            this.anuluj_dodaj.Name = "anuluj_dodaj";
            this.anuluj_dodaj.Size = new System.Drawing.Size(75, 32);
            this.anuluj_dodaj.TabIndex = 12;
            this.anuluj_dodaj.Text = "Anuluj";
            this.anuluj_dodaj.UseVisualStyleBackColor = true;
            this.anuluj_dodaj.Click += new System.EventHandler(this.anuluj_dodaj_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(471, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Użytkownicy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(474, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Administrator:";
            // 
            // lCzyAdmin
            // 
            this.lCzyAdmin.AutoSize = true;
            this.lCzyAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lCzyAdmin.Location = new System.Drawing.Point(575, 257);
            this.lCzyAdmin.Name = "lCzyAdmin";
            this.lCzyAdmin.Size = new System.Drawing.Size(23, 17);
            this.lCzyAdmin.TabIndex = 38;
            this.lCzyAdmin.Text = "---";
            // 
            // Dodaj_uzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 360);
            this.Controls.Add(this.lCzyAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hasloponl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.lbPracownicy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dzielnical);
            this.Controls.Add(this.miastol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imiel);
            this.Controls.Add(this.nazwiskol);
            this.Controls.Add(this.zapisz_dodaj);
            this.Controls.Add(this.zapisz_edycja);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.haslol);
            this.Controls.Add(this.nazwa_uzytkownika);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_uzytkownik);
            this.Controls.Add(this.anuluj_dodaj);
            this.Controls.Add(this.anuluj_edycja);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.info);
            this.MaximizeBox = false;
            this.Name = "Dodaj_uzytkownika";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMOST Lite";
            this.Load += new System.EventHandler(this.Dodaj_uzytkownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mopsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        public System.Windows.Forms.TextBox haslol;
        public System.Windows.Forms.TextBox nazwa_uzytkownika;
        private System.Windows.Forms.Label label_haslo;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label info;
        public System.Windows.Forms.TextBox nazwiskol;
        public System.Windows.Forms.TextBox imiel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox miastol;
        public System.Windows.Forms.TextBox dzielnical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.ListBox lbPracownicy;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button zapisz_edycja;
        private System.Windows.Forms.Button anuluj_edycja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hasloponl;
        private System.Windows.Forms.Button zapisz_dodaj;
        private System.Windows.Forms.Button anuluj_dodaj;
        private System.Windows.Forms.BindingSource mopsDataSetBindingSource;
        private mopsDataSet mopsDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private mopsDataSetTableAdapters.pracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lCzyAdmin;
    }
}