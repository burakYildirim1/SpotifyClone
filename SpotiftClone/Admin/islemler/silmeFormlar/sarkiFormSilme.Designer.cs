
namespace SpotiftClone.Admin.islemler.silmeFormlar
{
    partial class sarkiFormSilme
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
            this.sarkiSil = new FontAwesome.Sharp.IconButton();
            this.sarkiAdi = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sarkiSil
            // 
            this.sarkiSil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sarkiSil.IconColor = System.Drawing.Color.Black;
            this.sarkiSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sarkiSil.Location = new System.Drawing.Point(229, 133);
            this.sarkiSil.Margin = new System.Windows.Forms.Padding(2);
            this.sarkiSil.Name = "sarkiSil";
            this.sarkiSil.Size = new System.Drawing.Size(84, 23);
            this.sarkiSil.TabIndex = 36;
            this.sarkiSil.Text = "Sil";
            this.sarkiSil.UseVisualStyleBackColor = true;
            this.sarkiSil.Click += new System.EventHandler(this.sarkiSil_Click);
            // 
            // sarkiAdi
            // 
            this.sarkiAdi.Location = new System.Drawing.Point(218, 97);
            this.sarkiAdi.Margin = new System.Windows.Forms.Padding(2);
            this.sarkiAdi.Name = "sarkiAdi";
            this.sarkiAdi.Size = new System.Drawing.Size(105, 20);
            this.sarkiAdi.TabIndex = 34;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(218, 64);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(105, 20);
            this.ID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(181, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(143, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Şarkı Adı :";
            // 
            // sarkiFormSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.sarkiSil);
            this.Controls.Add(this.sarkiAdi);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sarkiFormSilme";
            this.Text = "sarkiFormSilme";
            this.Load += new System.EventHandler(this.sarkiFormSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton sarkiSil;
        private System.Windows.Forms.TextBox sarkiAdi;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}