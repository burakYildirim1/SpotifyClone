
namespace SpotiftClone.Admin.islemler.silmeFormlar
{
    partial class albumFormSilme
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
            this.albumSil = new FontAwesome.Sharp.IconButton();
            this.albumAdi = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // albumSil
            // 
            this.albumSil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.albumSil.IconColor = System.Drawing.Color.Black;
            this.albumSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.albumSil.Location = new System.Drawing.Point(195, 144);
            this.albumSil.Margin = new System.Windows.Forms.Padding(2);
            this.albumSil.Name = "albumSil";
            this.albumSil.Size = new System.Drawing.Size(84, 23);
            this.albumSil.TabIndex = 18;
            this.albumSil.Text = "Sil";
            this.albumSil.UseVisualStyleBackColor = true;
            this.albumSil.Click += new System.EventHandler(this.albumSil_Click);
            // 
            // albumAdi
            // 
            this.albumAdi.Location = new System.Drawing.Point(186, 100);
            this.albumAdi.Margin = new System.Windows.Forms.Padding(2);
            this.albumAdi.Name = "albumAdi";
            this.albumAdi.Size = new System.Drawing.Size(105, 20);
            this.albumAdi.TabIndex = 17;
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(186, 54);
            this.textID.Margin = new System.Windows.Forms.Padding(2);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(105, 20);
            this.textID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(103, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Albüm Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(147, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID :";
            // 
            // albumFormSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.albumSil);
            this.Controls.Add(this.albumAdi);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "albumFormSilme";
            this.Text = "albumFormSilme";
            this.Load += new System.EventHandler(this.albumFormSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton albumSil;
        private System.Windows.Forms.TextBox albumAdi;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}