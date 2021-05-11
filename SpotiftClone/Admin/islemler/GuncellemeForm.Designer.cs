
namespace SpotiftClone.Admin.islemler
{
    partial class GuncellemeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAlbum = new FontAwesome.Sharp.IconButton();
            this.btnSanatci = new FontAwesome.Sharp.IconButton();
            this.btnSarki = new FontAwesome.Sharp.IconButton();
            this.panelGuncel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(996, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnAlbum
            // 
            this.btnAlbum.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAlbum.IconColor = System.Drawing.Color.Black;
            this.btnAlbum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlbum.Location = new System.Drawing.Point(12, 255);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(231, 48);
            this.btnAlbum.TabIndex = 1;
            this.btnAlbum.Text = "Albüm";
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // btnSanatci
            // 
            this.btnSanatci.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSanatci.IconColor = System.Drawing.Color.Black;
            this.btnSanatci.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanatci.Location = new System.Drawing.Point(12, 346);
            this.btnSanatci.Name = "btnSanatci";
            this.btnSanatci.Size = new System.Drawing.Size(231, 48);
            this.btnSanatci.TabIndex = 2;
            this.btnSanatci.Text = "Sanatçı";
            this.btnSanatci.UseVisualStyleBackColor = true;
            this.btnSanatci.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // btnSarki
            // 
            this.btnSarki.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSarki.IconColor = System.Drawing.Color.Black;
            this.btnSarki.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSarki.Location = new System.Drawing.Point(12, 440);
            this.btnSarki.Name = "btnSarki";
            this.btnSarki.Size = new System.Drawing.Size(231, 48);
            this.btnSarki.TabIndex = 3;
            this.btnSarki.Text = "Şarkılar";
            this.btnSarki.UseVisualStyleBackColor = true;
            this.btnSarki.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // panelGuncel
            // 
            this.panelGuncel.Location = new System.Drawing.Point(262, 191);
            this.panelGuncel.Name = "panelGuncel";
            this.panelGuncel.Size = new System.Drawing.Size(731, 442);
            this.panelGuncel.TabIndex = 5;
            // 
            // GuncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(993, 631);
            this.Controls.Add(this.panelGuncel);
            this.Controls.Add(this.btnSarki);
            this.Controls.Add(this.btnSanatci);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuncellemeForm";
            this.Text = "GuncellemeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnAlbum;
        private FontAwesome.Sharp.IconButton btnSanatci;
        private FontAwesome.Sharp.IconButton btnSarki;
        private System.Windows.Forms.Panel panelGuncel;
    }
}