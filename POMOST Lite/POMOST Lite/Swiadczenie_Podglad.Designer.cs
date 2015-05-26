namespace POMOST_Lite
{
    partial class Swiadczenie_Podglad
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
            this.WBSwiadczenia_Podglad = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WBSwiadczenia_Podglad
            // 
            this.WBSwiadczenia_Podglad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBSwiadczenia_Podglad.Location = new System.Drawing.Point(0, 0);
            this.WBSwiadczenia_Podglad.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSwiadczenia_Podglad.Name = "WBSwiadczenia_Podglad";
            this.WBSwiadczenia_Podglad.Size = new System.Drawing.Size(563, 371);
            this.WBSwiadczenia_Podglad.TabIndex = 0;
            // 
            // Swiadczenie_Podglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 371);
            this.Controls.Add(this.WBSwiadczenia_Podglad);
            this.Name = "Swiadczenie_Podglad";
            this.Text = "Podgląd dokumentu dla danego świadczenia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBSwiadczenia_Podglad;
    }
}