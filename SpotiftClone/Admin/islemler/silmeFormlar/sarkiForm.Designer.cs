
namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    partial class sarkiForm
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
            this.sarkiGuncelle = new FontAwesome.Sharp.IconButton();
            this.sarkiSuresi = new System.Windows.Forms.TextBox();
            this.sarkiAdi = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sarkiTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // sarkiGuncelle
            // 
            this.sarkiGuncelle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sarkiGuncelle.IconColor = System.Drawing.Color.Black;
            this.sarkiGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sarkiGuncelle.Location = new System.Drawing.Point(274, 248);
            this.sarkiGuncelle.Name = "sarkiGuncelle";
            this.sarkiGuncelle.Size = new System.Drawing.Size(112, 28);
            this.sarkiGuncelle.TabIndex = 27;
            this.sarkiGuncelle.Text = "Güncelle";
            this.sarkiGuncelle.UseVisualStyleBackColor = true;
            this.sarkiGuncelle.Click += new System.EventHandler(this.sarkiGuncelle_Click);
            // 
            // sarkiSuresi
            // 
            this.sarkiSuresi.Location = new System.Drawing.Point(259, 203);
            this.sarkiSuresi.Name = "sarkiSuresi";
            this.sarkiSuresi.Size = new System.Drawing.Size(139, 22);
            this.sarkiSuresi.TabIndex = 26;
            // 
            // sarkiAdi
            // 
            this.sarkiAdi.Location = new System.Drawing.Point(259, 118);
            this.sarkiAdi.Name = "sarkiAdi";
            this.sarkiAdi.Size = new System.Drawing.Size(139, 22);
            this.sarkiAdi.TabIndex = 24;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(259, 78);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(139, 22);
            this.ID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(135, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Şarkı Süresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(188, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(209, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(159, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Şarkı Adı :";
            // 
            // sarkiTarih
            // 
            this.sarkiTarih.Location = new System.Drawing.Point(259, 158);
            this.sarkiTarih.Name = "sarkiTarih";
            this.sarkiTarih.Size = new System.Drawing.Size(139, 22);
            this.sarkiTarih.TabIndex = 28;
            // 
            // sarkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sarkiTarih);
            this.Controls.Add(this.sarkiGuncelle);
            this.Controls.Add(this.sarkiSuresi);
            this.Controls.Add(this.sarkiAdi);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sarkiForm";
            this.Text = "sarkiForm";
            this.Load += new System.EventHandler(this.sarkiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton sarkiGuncelle;
        private System.Windows.Forms.TextBox sarkiSuresi;
        private System.Windows.Forms.TextBox sarkiAdi;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker sarkiTarih;
    }
}