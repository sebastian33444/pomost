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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Strona_glowna));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.Wyloguj = new System.Windows.Forms.ToolStripMenuItem();
            this.dodaj_petenta = new System.Windows.Forms.ToolStripButton();
            this.usun_petenta = new System.Windows.Forms.ToolStripButton();
            this.edytuj_petenta = new System.Windows.Forms.ToolStripButton();
            this.wyszukaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.lbPetent = new System.Windows.Forms.ListBox();
            this.lbDokumenty = new System.Windows.Forms.ListBox();
            this.lbSwiadczenia = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.dodaj_petenta,
            this.usun_petenta,
            this.edytuj_petenta,
            this.wyszukaj,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 25);
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
            this.menu.Size = new System.Drawing.Size(67, 22);
            this.menu.Text = "Menu";
            // 
            // Wyloguj
            // 
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(118, 22);
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // dodaj_petenta
            // 
            this.dodaj_petenta.Image = ((System.Drawing.Image)(resources.GetObject("dodaj_petenta.Image")));
            this.dodaj_petenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodaj_petenta.Name = "dodaj_petenta";
            this.dodaj_petenta.Size = new System.Drawing.Size(101, 22);
            this.dodaj_petenta.Text = "Dodaj petenta";
            // 
            // usun_petenta
            // 
            this.usun_petenta.Image = ((System.Drawing.Image)(resources.GetObject("usun_petenta.Image")));
            this.usun_petenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usun_petenta.Name = "usun_petenta";
            this.usun_petenta.Size = new System.Drawing.Size(97, 22);
            this.usun_petenta.Text = "Usuń petenta";
            // 
            // edytuj_petenta
            // 
            this.edytuj_petenta.Image = ((System.Drawing.Image)(resources.GetObject("edytuj_petenta.Image")));
            this.edytuj_petenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edytuj_petenta.Name = "edytuj_petenta";
            this.edytuj_petenta.Size = new System.Drawing.Size(103, 22);
            this.edytuj_petenta.Text = "Edytuj petenta";
            // 
            // wyszukaj
            // 
            this.wyszukaj.Image = ((System.Drawing.Image)(resources.GetObject("wyszukaj.Image")));
            this.wyszukaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Size = new System.Drawing.Size(76, 22);
            this.wyszukaj.Text = "Wyszukaj";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(970, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Login:";
            // 
            // tslabelLogin
            // 
            this.tslabelLogin.Name = "tslabelLogin";
            this.tslabelLogin.Size = new System.Drawing.Size(86, 22);
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
            this.toolStripLabel3.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel3.Text = "Miasto:";
            // 
            // tslabelMiasto
            // 
            this.tslabelMiasto.Name = "tslabelMiasto";
            this.tslabelMiasto.Size = new System.Drawing.Size(86, 22);
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
            this.toolStripLabel5.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel5.Text = "Dzielnica:";
            // 
            // tslabelDzielnica
            // 
            this.tslabelDzielnica.Name = "tslabelDzielnica";
            this.tslabelDzielnica.Size = new System.Drawing.Size(86, 22);
            this.tslabelDzielnica.Text = "toolStripLabel6";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lbPetent
            // 
            this.lbPetent.FormattingEnabled = true;
            this.lbPetent.Location = new System.Drawing.Point(0, 53);
            this.lbPetent.Name = "lbPetent";
            this.lbPetent.Size = new System.Drawing.Size(345, 407);
            this.lbPetent.TabIndex = 3;
            // 
            // lbDokumenty
            // 
            this.lbDokumenty.FormattingEnabled = true;
            this.lbDokumenty.Location = new System.Drawing.Point(351, 53);
            this.lbDokumenty.Name = "lbDokumenty";
            this.lbDokumenty.Size = new System.Drawing.Size(322, 407);
            this.lbDokumenty.TabIndex = 4;
            // 
            // lbSwiadczenia
            // 
            this.lbSwiadczenia.FormattingEnabled = true;
            this.lbSwiadczenia.Location = new System.Drawing.Point(679, 53);
            this.lbSwiadczenia.Name = "lbSwiadczenia";
            this.lbSwiadczenia.Size = new System.Drawing.Size(291, 407);
            this.lbSwiadczenia.TabIndex = 5;
            // 
            // Strona_glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 459);
            this.Controls.Add(this.lbSwiadczenia);
            this.Controls.Add(this.lbDokumenty);
            this.Controls.Add(this.lbPetent);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Strona_glowna";
            this.ShowIcon = false;
            this.Text = "POMOST Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Strona_glowna_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ListBox lbPetent;
        private System.Windows.Forms.ListBox lbDokumenty;
        private System.Windows.Forms.ListBox lbSwiadczenia;
    }
}