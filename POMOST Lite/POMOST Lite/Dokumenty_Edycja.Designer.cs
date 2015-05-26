namespace POMOST_Lite
{
    partial class Dokumenty_Edycja
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
            this.WBDokumenty_Edycja = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WBDokumenty_Edycja
            // 
            this.WBDokumenty_Edycja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBDokumenty_Edycja.Location = new System.Drawing.Point(0, 0);
            this.WBDokumenty_Edycja.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBDokumenty_Edycja.Name = "WBDokumenty_Edycja";
            this.WBDokumenty_Edycja.Size = new System.Drawing.Size(792, 473);
            this.WBDokumenty_Edycja.TabIndex = 0;
            // 
            // Dokumenty_Edycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.WBDokumenty_Edycja);
            this.Name = "Dokumenty_Edycja";
            this.Text = "Edycja dokumentu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBDokumenty_Edycja;
    }
}