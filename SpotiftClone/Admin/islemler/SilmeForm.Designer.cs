﻿
namespace SpotiftClone.Admin.islemler
{
    partial class SilmeForm
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
            this.btnSarki = new FontAwesome.Sharp.IconButton();
            this.btnSanatci = new FontAwesome.Sharp.IconButton();
            this.btnAlbum = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSarki
            // 
            this.btnSarki.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSarki.IconColor = System.Drawing.Color.Black;
            this.btnSarki.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSarki.Location = new System.Drawing.Point(22, 483);
            this.btnSarki.Name = "btnSarki";
            this.btnSarki.Size = new System.Drawing.Size(231, 48);
            this.btnSarki.TabIndex = 6;
            this.btnSarki.Text = "Şarkılar";
            this.btnSarki.UseVisualStyleBackColor = true;
            // 
            // btnSanatci
            // 
            this.btnSanatci.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSanatci.IconColor = System.Drawing.Color.Black;
            this.btnSanatci.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanatci.Location = new System.Drawing.Point(22, 389);
            this.btnSanatci.Name = "btnSanatci";
            this.btnSanatci.Size = new System.Drawing.Size(231, 48);
            this.btnSanatci.TabIndex = 5;
            this.btnSanatci.Text = "Sanatçı";
            this.btnSanatci.UseVisualStyleBackColor = true;
            // 
            // btnAlbum
            // 
            this.btnAlbum.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAlbum.IconColor = System.Drawing.Color.Black;
            this.btnAlbum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlbum.Location = new System.Drawing.Point(22, 298);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(231, 48);
            this.btnAlbum.TabIndex = 4;
            this.btnAlbum.Text = "Albüm";
            this.btnAlbum.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 232);
            this.dataGridView1.TabIndex = 7;
            // 
            // SilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(993, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSarki);
            this.Controls.Add(this.btnSanatci);
            this.Controls.Add(this.btnAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SilmeForm";
            this.Text = "SilmeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSarki;
        private FontAwesome.Sharp.IconButton btnSanatci;
        private FontAwesome.Sharp.IconButton btnAlbum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}