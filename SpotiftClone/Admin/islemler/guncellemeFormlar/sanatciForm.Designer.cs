
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
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sanatciGuncelle
            // 
            this.sanatciGuncelle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sanatciGuncelle.IconColor = System.Drawing.Color.Black;
            this.sanatciGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sanatciGuncelle.Location = new System.Drawing.Point(238, 243);
            this.sanatciGuncelle.Name = "sanatciGuncelle";
            this.sanatciGuncelle.Size = new System.Drawing.Size(112, 28);
            this.sanatciGuncelle.TabIndex = 18;
            this.sanatciGuncelle.Text = "Güncelle";
            this.sanatciGuncelle.UseVisualStyleBackColor = true;
            // 
            // sahneAdi
            // 
            this.sahneAdi.Location = new System.Drawing.Point(223, 198);
            this.sahneAdi.Name = "sahneAdi";
            this.sahneAdi.Size = new System.Drawing.Size(139, 22);
            this.sahneAdi.TabIndex = 17;
            // 
            // sanatciSoyad
            // 
            this.sanatciSoyad.Location = new System.Drawing.Point(223, 155);
            this.sanatciSoyad.Name = "sanatciSoyad";
            this.sanatciSoyad.Size = new System.Drawing.Size(139, 22);
            this.sanatciSoyad.TabIndex = 16;
            // 
            // sanatciAdi
            // 
            this.sanatciAdi.Location = new System.Drawing.Point(223, 113);
            this.sanatciAdi.Name = "sanatciAdi";
            this.sanatciAdi.Size = new System.Drawing.Size(139, 22);
            this.sanatciAdi.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(223, 73);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(139, 22);
            this.ID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(99, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sahne Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(64, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sanatçı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(158, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sanatçı Adı :";
            // 
            // sanatciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sanatciGuncelle);
            this.Controls.Add(this.sahneAdi);
            this.Controls.Add(this.sanatciSoyad);
            this.Controls.Add(this.sanatciAdi);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}