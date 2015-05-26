namespace POMOST_Lite
{
    partial class Konfiguracja_bazy
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
            this.nazwa_bazy = new System.Windows.Forms.TextBox();
            this.nazwa_serwera = new System.Windows.Forms.TextBox();
            this.label_haslo = new System.Windows.Forms.Label();
            this.label_uzytkownik = new System.Windows.Forms.Label();
            this.zamknij = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazwa_bazy
            // 
            this.nazwa_bazy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazwa_bazy.Location = new System.Drawing.Point(175, 72);
            this.nazwa_bazy.Name = "nazwa_bazy";
            this.nazwa_bazy.Size = new System.Drawing.Size(320, 23);
            this.nazwa_bazy.TabIndex = 18;
            // 
            // nazwa_serwera
            // 
            this.nazwa_serwera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nazwa_serwera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazwa_serwera.Location = new System.Drawing.Point(175, 43);
            this.nazwa_serwera.Name = "nazwa_serwera";
            this.nazwa_serwera.Size = new System.Drawing.Size(320, 23);
            this.nazwa_serwera.TabIndex = 17;
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_haslo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_haslo.Location = new System.Drawing.Point(82, 75);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(88, 17);
            this.label_haslo.TabIndex = 16;
            this.label_haslo.Text = "Nazwa bazy:";
            // 
            // label_uzytkownik
            // 
            this.label_uzytkownik.AutoSize = true;
            this.label_uzytkownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_uzytkownik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_uzytkownik.Location = new System.Drawing.Point(62, 46);
            this.label_uzytkownik.Name = "label_uzytkownik";
            this.label_uzytkownik.Size = new System.Drawing.Size(108, 17);
            this.label_uzytkownik.TabIndex = 15;
            this.label_uzytkownik.Text = "Nazwa serwera:";
            // 
            // zamknij
            // 
            this.zamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zamknij.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zamknij.Location = new System.Drawing.Point(420, 113);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(75, 32);
            this.zamknij.TabIndex = 14;
            this.zamknij.Text = "Zamknij";
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // zapisz
            // 
            this.zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zapisz.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.zapisz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zapisz.Location = new System.Drawing.Point(339, 113);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(75, 32);
            this.zapisz.TabIndex = 13;
            this.zapisz.Text = "Zapisz";
            this.zapisz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // Konfiguracja_bazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 161);
            this.Controls.Add(this.nazwa_bazy);
            this.Controls.Add(this.nazwa_serwera);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_uzytkownik);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.zapisz);
            this.MaximizeBox = false;
            this.Name = "Konfiguracja_bazy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfiguracja połaczenia z bazą";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox nazwa_bazy;
        public System.Windows.Forms.TextBox nazwa_serwera;
        private System.Windows.Forms.Label label_haslo;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.Button zapisz;
    }
}