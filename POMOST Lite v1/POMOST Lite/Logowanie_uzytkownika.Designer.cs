namespace POMOST_Lite
{
    partial class Logowanie_uzytkownika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie_uzytkownika));
            this.info = new System.Windows.Forms.Label();
            this.zamknij = new System.Windows.Forms.Button();
            this.label_uzytkownik = new System.Windows.Forms.Label();
            this.label_haslo = new System.Windows.Forms.Label();
            this.nazwa_uzytkownika = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.zaloguj = new System.Windows.Forms.Button();
            this.dodaj_uzytkownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            resources.ApplyResources(this.info, "info");
            this.info.Name = "info";
            // 
            // zamknij
            // 
            resources.ApplyResources(this.zamknij, "zamknij");
            this.zamknij.Name = "zamknij";
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // label_uzytkownik
            // 
            resources.ApplyResources(this.label_uzytkownik, "label_uzytkownik");
            this.label_uzytkownik.Name = "label_uzytkownik";
            // 
            // label_haslo
            // 
            resources.ApplyResources(this.label_haslo, "label_haslo");
            this.label_haslo.Name = "label_haslo";
            // 
            // nazwa_uzytkownika
            // 
            this.nazwa_uzytkownika.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.nazwa_uzytkownika, "nazwa_uzytkownika");
            this.nazwa_uzytkownika.Name = "nazwa_uzytkownika";
            // 
            // haslo
            // 
            this.haslo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.haslo, "haslo");
            this.haslo.Name = "haslo";
            // 
            // zaloguj
            // 
            resources.ApplyResources(this.zaloguj, "zaloguj");
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // dodaj_uzytkownika
            // 
            resources.ApplyResources(this.dodaj_uzytkownika, "dodaj_uzytkownika");
            this.dodaj_uzytkownika.Name = "dodaj_uzytkownika";
            this.dodaj_uzytkownika.UseVisualStyleBackColor = true;
            this.dodaj_uzytkownika.Click += new System.EventHandler(this.dodaj_uzytkownika_Click);
            // 
            // Logowanie_uzytkownika
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.dodaj_uzytkownika);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.nazwa_uzytkownika);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_uzytkownik);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.info);
            this.MaximizeBox = false;
            this.Name = "Logowanie_uzytkownika";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button zaloguj;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Label label_haslo;
        public System.Windows.Forms.TextBox nazwa_uzytkownika;
        public System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Button dodaj_uzytkownika;
    }
}

