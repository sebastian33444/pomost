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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.zapisz = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.tryb_edycji = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasloponl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dodaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dodaj.Location = new System.Drawing.Point(474, 257);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 32);
            this.dodaj.TabIndex = 20;
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
            this.haslol.TabIndex = 19;
            // 
            // nazwa_uzytkownika
            // 
            this.nazwa_uzytkownika.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.nazwa_uzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazwa_uzytkownika.Location = new System.Drawing.Point(147, 55);
            this.nazwa_uzytkownika.Name = "nazwa_uzytkownika";
            this.nazwa_uzytkownika.Size = new System.Drawing.Size(320, 23);
            this.nazwa_uzytkownika.TabIndex = 18;
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_haslo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_haslo.Location = new System.Drawing.Point(97, 87);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(44, 17);
            this.label_haslo.TabIndex = 17;
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
            this.label_uzytkownik.TabIndex = 16;
            this.label_uzytkownik.Text = "Nazwa użytkownika";
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wroc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wroc.Location = new System.Drawing.Point(551, 294);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 15;
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
            this.info.TabIndex = 13;
            this.info.Text = "Zarządzanie użytkownikami";
            // 
            // nazwiskol
            // 
            this.nazwiskol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazwiskol.Location = new System.Drawing.Point(147, 171);
            this.nazwiskol.Name = "nazwiskol";
            this.nazwiskol.Size = new System.Drawing.Size(320, 23);
            this.nazwiskol.TabIndex = 25;
            // 
            // imiel
            // 
            this.imiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imiel.Location = new System.Drawing.Point(147, 142);
            this.imiel.Name = "imiel";
            this.imiel.Size = new System.Drawing.Size(320, 23);
            this.imiel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(76, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 27;
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
            this.label3.TabIndex = 28;
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
            this.miastol.TabIndex = 32;
            // 
            // dzielnical
            // 
            this.dzielnical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dzielnical.Location = new System.Drawing.Point(147, 200);
            this.dzielnical.Name = "dzielnical";
            this.dzielnical.Size = new System.Drawing.Size(320, 23);
            this.dzielnical.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(92, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Miasto";
            // 
            // edytuj
            // 
            this.edytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edytuj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edytuj.Location = new System.Drawing.Point(474, 294);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(76, 32);
            this.edytuj.TabIndex = 20;
            this.edytuj.Text = "Edytuj";
            this.edytuj.UseVisualStyleBackColor = true;
            this.edytuj.Click += new System.EventHandler(this.edytuj_Click);
            // 
            // usun
            // 
            this.usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usun.Location = new System.Drawing.Point(551, 256);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(76, 32);
            this.usun.TabIndex = 20;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(474, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 196);
            this.listBox1.TabIndex = 35;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxAdmin.Location = new System.Drawing.Point(494, 31);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAdmin.TabIndex = 36;
            this.checkBoxAdmin.Text = "administracja";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // zapisz
            // 
            this.zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zapisz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zapisz.Location = new System.Drawing.Point(145, 279);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(76, 32);
            this.zapisz.TabIndex = 20;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // anuluj
            // 
            this.anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.anuluj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.anuluj.Location = new System.Drawing.Point(227, 279);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(75, 32);
            this.anuluj.TabIndex = 15;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // tryb_edycji
            // 
            this.tryb_edycji.AutoSize = true;
            this.tryb_edycji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tryb_edycji.Location = new System.Drawing.Point(145, 257);
            this.tryb_edycji.Name = "tryb_edycji";
            this.tryb_edycji.Size = new System.Drawing.Size(157, 17);
            this.tryb_edycji.TabIndex = 37;
            this.tryb_edycji.Text = "Tryb edycji użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 38;
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
            this.hasloponl.TabIndex = 39;
            // 
            // Dodaj_uzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 328);
            this.Controls.Add(this.hasloponl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tryb_edycji);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dzielnical);
            this.Controls.Add(this.miastol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imiel);
            this.Controls.Add(this.nazwiskol);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.haslol);
            this.Controls.Add(this.nazwa_uzytkownika);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_uzytkownik);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.info);
            this.MaximizeBox = false;
            this.Name = "Dodaj_uzytkownika";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMOST Lite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dodaj_uzytkownika_FormClosing);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Button anuluj;
        private System.Windows.Forms.Label tryb_edycji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hasloponl;
    }
}