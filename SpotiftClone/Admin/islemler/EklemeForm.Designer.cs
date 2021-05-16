
namespace SpotiftClone.Admin.islemler
{
    partial class EklemeForm
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ulkeAdi = new System.Windows.Forms.TextBox();
            this.ulkeListe = new System.Windows.Forms.ComboBox();
            this.ulkeEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textSSahneAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSAdi = new System.Windows.Forms.TextBox();
            this.ulkeSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnAlbumEkle = new System.Windows.Forms.Button();
            this.albumTarih = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textSarkiSayi = new System.Windows.Forms.TextBox();
            this.SanatciAdList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textAlbumAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sarkiTurList = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.sarkiSure = new System.Windows.Forms.TextBox();
            this.sarkiTarihi = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.sarkiAdi = new System.Windows.Forms.TextBox();
            this.albumAdi = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sarkiTurleri = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sanatciAdlari = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(10, 8);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1298, 753);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage5.Controls.Add(this.ulkeAdi);
            this.tabPage5.Controls.Add(this.ulkeListe);
            this.tabPage5.Controls.Add(this.ulkeEkle);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Location = new System.Drawing.Point(4, 36);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1290, 713);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Ülke";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // ulkeAdi
            // 
            this.ulkeAdi.Location = new System.Drawing.Point(706, 123);
            this.ulkeAdi.Name = "ulkeAdi";
            this.ulkeAdi.Size = new System.Drawing.Size(196, 23);
            this.ulkeAdi.TabIndex = 4;
            this.ulkeAdi.TextChanged += new System.EventHandler(this.ulkeAdi_TextChanged);
            // 
            // ulkeListe
            // 
            this.ulkeListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ulkeListe.FormattingEnabled = true;
            this.ulkeListe.Location = new System.Drawing.Point(144, 123);
            this.ulkeListe.Name = "ulkeListe";
            this.ulkeListe.Size = new System.Drawing.Size(196, 25);
            this.ulkeListe.TabIndex = 3;
            this.ulkeListe.SelectedIndexChanged += new System.EventHandler(this.ulkeListe_SelectedIndexChanged);
            // 
            // ulkeEkle
            // 
            this.ulkeEkle.Location = new System.Drawing.Point(723, 182);
            this.ulkeEkle.Name = "ulkeEkle";
            this.ulkeEkle.Size = new System.Drawing.Size(158, 36);
            this.ulkeEkle.TabIndex = 2;
            this.ulkeEkle.Text = "Ekle";
            this.ulkeEkle.UseVisualStyleBackColor = true;
            this.ulkeEkle.Click += new System.EventHandler(this.ulkeEkle_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(433, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "Eklenecek Ülke Adını Giriniz : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 51);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ülkeler :";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage6.Controls.Add(this.btnKaydet);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.textSSahneAd);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.textSSoyad);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.textSAdi);
            this.tabPage6.Controls.Add(this.ulkeSec);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 36);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1290, 713);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Sanatçı";
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(654, 287);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(506, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 51);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sahne Adı :";
            // 
            // textSSahneAd
            // 
            this.textSSahneAd.Location = new System.Drawing.Point(634, 223);
            this.textSSahneAd.Name = "textSSahneAd";
            this.textSSahneAd.Size = new System.Drawing.Size(196, 23);
            this.textSSahneAd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(471, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 51);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sanatçı Soyadı :";
            // 
            // textSSoyad
            // 
            this.textSSoyad.Location = new System.Drawing.Point(634, 124);
            this.textSSoyad.Name = "textSSoyad";
            this.textSSoyad.Size = new System.Drawing.Size(196, 23);
            this.textSSoyad.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 51);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sanatçı Adı :";
            // 
            // textSAdi
            // 
            this.textSAdi.Location = new System.Drawing.Point(181, 223);
            this.textSAdi.Name = "textSAdi";
            this.textSAdi.Size = new System.Drawing.Size(196, 23);
            this.textSAdi.TabIndex = 6;
            // 
            // ulkeSec
            // 
            this.ulkeSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ulkeSec.FormattingEnabled = true;
            this.ulkeSec.Location = new System.Drawing.Point(181, 124);
            this.ulkeSec.Name = "ulkeSec";
            this.ulkeSec.Size = new System.Drawing.Size(196, 25);
            this.ulkeSec.TabIndex = 5;
            this.ulkeSec.SelectedIndexChanged += new System.EventHandler(this.ulkeSec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ülke Seçiniz :";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage7.Controls.Add(this.btnAlbumEkle);
            this.tabPage7.Controls.Add(this.albumTarih);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.textSarkiSayi);
            this.tabPage7.Controls.Add(this.SanatciAdList);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Controls.Add(this.textAlbumAd);
            this.tabPage7.Controls.Add(this.label10);
            this.tabPage7.Controls.Add(this.sarkiTurList);
            this.tabPage7.Controls.Add(this.label11);
            this.tabPage7.Location = new System.Drawing.Point(4, 36);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1290, 713);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Albüm";
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // btnAlbumEkle
            // 
            this.btnAlbumEkle.Location = new System.Drawing.Point(723, 305);
            this.btnAlbumEkle.Name = "btnAlbumEkle";
            this.btnAlbumEkle.Size = new System.Drawing.Size(130, 39);
            this.btnAlbumEkle.TabIndex = 22;
            this.btnAlbumEkle.Text = "Ekle";
            this.btnAlbumEkle.UseVisualStyleBackColor = true;
            this.btnAlbumEkle.Click += new System.EventHandler(this.btnAlbumEkle_Click);
            // 
            // albumTarih
            // 
            this.albumTarih.CustomFormat = "yyyy-MM-dd";
            this.albumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.albumTarih.Location = new System.Drawing.Point(689, 221);
            this.albumTarih.Name = "albumTarih";
            this.albumTarih.Size = new System.Drawing.Size(210, 23);
            this.albumTarih.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(556, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 51);
            this.label13.TabIndex = 20;
            this.label13.Text = "Çıkış tarihi :";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(452, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 51);
            this.label12.TabIndex = 18;
            this.label12.Text = "Albümdeki şarkı sayısı  :";
            // 
            // textSarkiSayi
            // 
            this.textSarkiSayi.Location = new System.Drawing.Point(689, 126);
            this.textSarkiSayi.Name = "textSarkiSayi";
            this.textSarkiSayi.Size = new System.Drawing.Size(210, 23);
            this.textSarkiSayi.TabIndex = 17;
            // 
            // SanatciAdList
            // 
            this.SanatciAdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SanatciAdList.FormattingEnabled = true;
            this.SanatciAdList.Location = new System.Drawing.Point(181, 221);
            this.SanatciAdList.Name = "SanatciAdList";
            this.SanatciAdList.Size = new System.Drawing.Size(210, 25);
            this.SanatciAdList.TabIndex = 16;
            this.SanatciAdList.SelectedIndexChanged += new System.EventHandler(this.SanatciAdList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 51);
            this.label9.TabIndex = 15;
            this.label9.Text = "Albüm adı :";
            // 
            // textAlbumAd
            // 
            this.textAlbumAd.Location = new System.Drawing.Point(181, 313);
            this.textAlbumAd.Name = "textAlbumAd";
            this.textAlbumAd.Size = new System.Drawing.Size(210, 23);
            this.textAlbumAd.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 51);
            this.label10.TabIndex = 13;
            this.label10.Text = "Sanatçı Adı :";
            // 
            // sarkiTurList
            // 
            this.sarkiTurList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sarkiTurList.FormattingEnabled = true;
            this.sarkiTurList.Location = new System.Drawing.Point(181, 124);
            this.sarkiTurList.Name = "sarkiTurList";
            this.sarkiTurList.Size = new System.Drawing.Size(210, 25);
            this.sarkiTurList.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(45, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 51);
            this.label11.TabIndex = 10;
            this.label11.Text = "Şarkı türü :";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage8.Controls.Add(this.textBox1);
            this.tabPage8.Controls.Add(this.checkedListBox1);
            this.tabPage8.Controls.Add(this.button1);
            this.tabPage8.Controls.Add(this.label19);
            this.tabPage8.Controls.Add(this.sarkiSure);
            this.tabPage8.Controls.Add(this.sarkiTarihi);
            this.tabPage8.Controls.Add(this.label18);
            this.tabPage8.Controls.Add(this.label17);
            this.tabPage8.Controls.Add(this.sarkiAdi);
            this.tabPage8.Controls.Add(this.albumAdi);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.sarkiTurleri);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.sanatciAdlari);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Location = new System.Drawing.Point(4, 36);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1290, 713);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Şarkı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(214, 122);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(214, 94);
            this.checkedListBox1.TabIndex = 30;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(505, 363);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 51);
            this.label19.TabIndex = 28;
            this.label19.Text = "Süre (saniye) :";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // sarkiSure
            // 
            this.sarkiSure.Location = new System.Drawing.Point(691, 365);
            this.sarkiSure.Name = "sarkiSure";
            this.sarkiSure.Size = new System.Drawing.Size(214, 23);
            this.sarkiSure.TabIndex = 27;
            // 
            // sarkiTarihi
            // 
            this.sarkiTarihi.CustomFormat = "yyyy-MM-dd";
            this.sarkiTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sarkiTarihi.Location = new System.Drawing.Point(691, 268);
            this.sarkiTarihi.Name = "sarkiTarihi";
            this.sarkiTarihi.Size = new System.Drawing.Size(214, 23);
            this.sarkiTarihi.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(525, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 51);
            this.label18.TabIndex = 25;
            this.label18.Text = "Yayın tarihi :";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(542, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 51);
            this.label17.TabIndex = 24;
            this.label17.Text = "Şarkı Adı :";
            // 
            // sarkiAdi
            // 
            this.sarkiAdi.Location = new System.Drawing.Point(691, 123);
            this.sarkiAdi.Name = "sarkiAdi";
            this.sarkiAdi.Size = new System.Drawing.Size(214, 23);
            this.sarkiAdi.TabIndex = 23;
            // 
            // albumAdi
            // 
            this.albumAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumAdi.FormattingEnabled = true;
            this.albumAdi.Location = new System.Drawing.Point(214, 364);
            this.albumAdi.Name = "albumAdi";
            this.albumAdi.Size = new System.Drawing.Size(214, 25);
            this.albumAdi.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(51, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 51);
            this.label16.TabIndex = 21;
            this.label16.Text = "Albüm Adı :";
            // 
            // sarkiTurleri
            // 
            this.sarkiTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sarkiTurleri.FormattingEnabled = true;
            this.sarkiTurleri.Location = new System.Drawing.Point(214, 266);
            this.sarkiTurleri.Name = "sarkiTurleri";
            this.sarkiTurleri.Size = new System.Drawing.Size(214, 25);
            this.sarkiTurleri.TabIndex = 20;
            this.sarkiTurleri.SelectedIndexChanged += new System.EventHandler(this.sarkiTurleri_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(59, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 51);
            this.label15.TabIndex = 19;
            this.label15.Text = "Şarkı türü :";
            // 
            // sanatciAdlari
            // 
            this.sanatciAdlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sanatciAdlari.FormattingEnabled = true;
            this.sanatciAdlari.Location = new System.Drawing.Point(214, 74);
            this.sanatciAdlari.Name = "sanatciAdlari";
            this.sanatciAdlari.Size = new System.Drawing.Size(214, 25);
            this.sanatciAdlari.TabIndex = 18;
            this.sanatciAdlari.SelectedIndexChanged += new System.EventHandler(this.sanatciAdlari_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(40, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 51);
            this.label14.TabIndex = 17;
            this.label14.Text = "Sanatçı Adı :";
            // 
            // EklemeForm
            // 
            this.ClientSize = new System.Drawing.Size(975, 584);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EklemeForm";
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ulkeIsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ulkeListesi;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox ulkeAdi;
        private System.Windows.Forms.ComboBox ulkeListe;
        private System.Windows.Forms.Button ulkeEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ulkeSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSSahneAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSAdi;
        private System.Windows.Forms.Button btnAlbumEkle;
        private System.Windows.Forms.DateTimePicker albumTarih;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textSarkiSayi;
        private System.Windows.Forms.ComboBox SanatciAdList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAlbumAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sarkiTurList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox sarkiSure;
        private System.Windows.Forms.DateTimePicker sarkiTarihi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox sarkiAdi;
        private System.Windows.Forms.ComboBox albumAdi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox sarkiTurleri;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox sanatciAdlari;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TextBox textBox1;
    }
}