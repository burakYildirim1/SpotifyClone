﻿
namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    partial class albumForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.sarkiSayi = new System.Windows.Forms.TextBox();
            this.albumAdi = new System.Windows.Forms.TextBox();
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.albumTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(164, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şarkı Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(224, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(174, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Albüm Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(204, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih :";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(266, 61);
            this.textID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(105, 20);
            this.textID.TabIndex = 4;
            // 
            // sarkiSayi
            // 
            this.sarkiSayi.Location = new System.Drawing.Point(266, 114);
            this.sarkiSayi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sarkiSayi.Name = "sarkiSayi";
            this.sarkiSayi.Size = new System.Drawing.Size(105, 20);
            this.sarkiSayi.TabIndex = 5;
            // 
            // albumAdi
            // 
            this.albumAdi.Location = new System.Drawing.Point(266, 167);
            this.albumAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.albumAdi.Name = "albumAdi";
            this.albumAdi.Size = new System.Drawing.Size(105, 20);
            this.albumAdi.TabIndex = 6;
            // 
            // ıconButton4
            // 
            this.ıconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconButton4.IconColor = System.Drawing.Color.Black;
            this.ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton4.Location = new System.Drawing.Point(266, 278);
            this.ıconButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Size = new System.Drawing.Size(105, 23);
            this.ıconButton4.TabIndex = 9;
            this.ıconButton4.Text = "Güncelle";
            this.ıconButton4.UseVisualStyleBackColor = true;
            this.ıconButton4.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // albumTarih
            // 
            this.albumTarih.CustomFormat = "yyyy-MM-dd";
            this.albumTarih.Location = new System.Drawing.Point(266, 220);
            this.albumTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.albumTarih.Name = "albumTarih";
            this.albumTarih.Size = new System.Drawing.Size(105, 20);
            this.albumTarih.TabIndex = 10;
            // 
            // albumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.albumTarih);
            this.Controls.Add(this.ıconButton4);
            this.Controls.Add(this.albumAdi);
            this.Controls.Add(this.sarkiSayi);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "albumForm";
            this.Text = "albumForm";
            this.Load += new System.EventHandler(this.albumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox sarkiSayi;
        private System.Windows.Forms.TextBox albumAdi;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private System.Windows.Forms.DateTimePicker albumTarih;
    }
}