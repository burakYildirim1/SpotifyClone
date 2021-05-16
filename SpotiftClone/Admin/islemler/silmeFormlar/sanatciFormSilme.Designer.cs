
namespace SpotiftClone.Admin.islemler.silmeFormlar
{
    partial class sanatciFormSilme
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
            this.sanatciSil = new FontAwesome.Sharp.IconButton();
            this.sanatciSoyad = new System.Windows.Forms.TextBox();
            this.sanatciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sanatciSil
            // 
            this.sanatciSil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sanatciSil.IconColor = System.Drawing.Color.Black;
            this.sanatciSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sanatciSil.Location = new System.Drawing.Point(218, 168);
            this.sanatciSil.Margin = new System.Windows.Forms.Padding(2);
            this.sanatciSil.Name = "sanatciSil";
            this.sanatciSil.Size = new System.Drawing.Size(84, 23);
            this.sanatciSil.TabIndex = 27;
            this.sanatciSil.Text = "Sil";
            this.sanatciSil.UseVisualStyleBackColor = true;
            this.sanatciSil.Click += new System.EventHandler(this.sanatciSil_Click);
            // 
            // sanatciSoyad
            // 
            this.sanatciSoyad.Location = new System.Drawing.Point(208, 127);
            this.sanatciSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.sanatciSoyad.Name = "sanatciSoyad";
            this.sanatciSoyad.Size = new System.Drawing.Size(105, 20);
            this.sanatciSoyad.TabIndex = 25;
            // 
            // sanatciAdi
            // 
            this.sanatciAdi.Location = new System.Drawing.Point(208, 93);
            this.sanatciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.sanatciAdi.Name = "sanatciAdi";
            this.sanatciAdi.Size = new System.Drawing.Size(105, 20);
            this.sanatciAdi.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(89, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sanatçı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(159, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(109, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sanatçı Adı :";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(208, 60);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(105, 20);
            this.ID.TabIndex = 28;
            // 
            // sanatciFormSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.sanatciSil);
            this.Controls.Add(this.sanatciSoyad);
            this.Controls.Add(this.sanatciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sanatciFormSilme";
            this.Text = "sanatciFormSilme";
            this.Load += new System.EventHandler(this.sanatciFormSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton sanatciSil;
        private System.Windows.Forms.TextBox sanatciSoyad;
        private System.Windows.Forms.TextBox sanatciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
    }
}