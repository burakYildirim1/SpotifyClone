
namespace SpotiftClone.MenuForms
{
    partial class AnasayfaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.anasayfaUsername = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPause = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label1 = new System.Windows.Forms.Label();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.ıconButton5 = new FontAwesome.Sharp.IconButton();
            this.ulkeListe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // anasayfaUsername
            // 
            this.anasayfaUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaUsername.Location = new System.Drawing.Point(603, 166);
            this.anasayfaUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anasayfaUsername.Name = "anasayfaUsername";
            this.anasayfaUsername.Size = new System.Drawing.Size(120, 47);
            this.anasayfaUsername.TabIndex = 9;
            this.anasayfaUsername.Text = "label3";
            this.anasayfaUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.anasayfaUsername.Click += new System.EventHandler(this.anasayfaUsername_Click);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ıconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ıconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 120;
            this.ıconPictureBox1.Location = new System.Drawing.Point(604, 20);
            this.ıconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(120, 130);
            this.ıconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ıconPictureBox1.TabIndex = 8;
            this.ıconPictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(332, 422);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 49);
            this.btnNext.TabIndex = 10;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPause
            // 
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPause.IconColor = System.Drawing.Color.Black;
            this.btnPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPause.Location = new System.Drawing.Point(239, 422);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(87, 49);
            this.btnPause.TabIndex = 11;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(146, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 49);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 404);
            this.dataGridView1.TabIndex = 13;
            // 
            // ıconButton1
            // 
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconButton1.IconColor = System.Drawing.Color.Black;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.Location = new System.Drawing.Point(617, 262);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(95, 23);
            this.ıconButton1.TabIndex = 14;
            this.ıconButton1.Text = "Tüm Şarkılar";
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(595, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "TOP 10 LİSTELERİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ıconButton3
            // 
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconButton3.IconColor = System.Drawing.Color.Black;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.Location = new System.Drawing.Point(617, 347);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(95, 23);
            this.ıconButton3.TabIndex = 17;
            this.ıconButton3.Text = "Klasik";
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // ıconButton4
            // 
            this.ıconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconButton4.IconColor = System.Drawing.Color.Black;
            this.ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton4.Location = new System.Drawing.Point(617, 390);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Size = new System.Drawing.Size(95, 23);
            this.ıconButton4.TabIndex = 18;
            this.ıconButton4.Text = "Pop";
            this.ıconButton4.UseVisualStyleBackColor = true;
            this.ıconButton4.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // ıconButton5
            // 
            this.ıconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconButton5.IconColor = System.Drawing.Color.Black;
            this.ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton5.Location = new System.Drawing.Point(617, 431);
            this.ıconButton5.Name = "ıconButton5";
            this.ıconButton5.Size = new System.Drawing.Size(95, 23);
            this.ıconButton5.TabIndex = 19;
            this.ıconButton5.Text = "Jazz";
            this.ıconButton5.UseVisualStyleBackColor = true;
            this.ıconButton5.Click += new System.EventHandler(this.ıconButton5_Click);
            // 
            // ulkeListe
            // 
            this.ulkeListe.FormattingEnabled = true;
            this.ulkeListe.Location = new System.Drawing.Point(617, 305);
            this.ulkeListe.Name = "ulkeListe";
            this.ulkeListe.Size = new System.Drawing.Size(95, 21);
            this.ulkeListe.TabIndex = 20;
            this.ulkeListe.Tag = "";
            this.ulkeListe.SelectedIndexChanged += new System.EventHandler(this.ulkeListe_SelectedIndexChanged);
            // 
            // AnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(745, 513);
            this.Controls.Add(this.ulkeListe);
            this.Controls.Add(this.ıconButton5);
            this.Controls.Add(this.ıconButton4);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.anasayfaUsername);
            this.Controls.Add(this.ıconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnasayfaForm";
            this.Text = "AnasayfaForm";
            this.Load += new System.EventHandler(this.AnasayfaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label anasayfaUsername;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPause;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private System.Windows.Forms.ComboBox ulkeListe;
    }
}