
namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    partial class sanatciForm
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
            this.sanatciGuncelle = new FontAwesome.Sharp.IconButton();
            this.sahneAdi = new System.Windows.Forms.TextBox();
            this.sanatciSoyad = new System.Windows.Forms.TextBox();
            this.sanatciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sanatciGuncelle
            // 
            this.sanatciGuncelle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sanatciGuncelle.IconColor = System.Drawing.Color.Black;
            this.sanatciGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sanatciGuncelle.Location = new System.Drawing.Point(266, 278);
            this.sanatciGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.sanatciGuncelle.Name = "sanatciGuncelle";
            this.sanatciGuncelle.Size = new System.Drawing.Size(105, 23);
            this.sanatciGuncelle.TabIndex = 18;
            this.sanatciGuncelle.Text = "Güncelle";
            this.sanatciGuncelle.UseVisualStyleBackColor = true;
            this.sanatciGuncelle.Click += new System.EventHandler(this.sanatciGuncelle_Click);
            // 
            // sahneAdi
            // 
            this.sahneAdi.Location = new System.Drawing.Point(266, 220);
            this.sahneAdi.Margin = new System.Windows.Forms.Padding(2);
            this.sahneAdi.Name = "sahneAdi";
            this.sahneAdi.Size = new System.Drawing.Size(105, 20);
            this.sahneAdi.TabIndex = 17;
            // 
            // sanatciSoyad
            // 
            this.sanatciSoyad.Location = new System.Drawing.Point(266, 167);
            this.sanatciSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.sanatciSoyad.Name = "sanatciSoyad";
            this.sanatciSoyad.Size = new System.Drawing.Size(105, 20);
            this.sanatciSoyad.TabIndex = 16;
            // 
            // sanatciAdi
            // 
            this.sanatciAdi.Location = new System.Drawing.Point(266, 114);
            this.sanatciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.sanatciAdi.Name = "sanatciAdi";
            this.sanatciAdi.Size = new System.Drawing.Size(105, 20);
            this.sanatciAdi.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(168, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sahne Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(139, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sanatçı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(220, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sanatçı Adı :";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(266, 61);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(105, 20);
            this.ID.TabIndex = 19;
            // 
            // sanatciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.sanatciGuncelle);
            this.Controls.Add(this.sahneAdi);
            this.Controls.Add(this.sanatciSoyad);
            this.Controls.Add(this.sanatciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sanatciForm";
            this.Text = "sarkiForm";
            this.Load += new System.EventHandler(this.sanatciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton sanatciGuncelle;
        private System.Windows.Forms.TextBox sahneAdi;
        private System.Windows.Forms.TextBox sanatciSoyad;
        private System.Windows.Forms.TextBox sanatciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
    }
}