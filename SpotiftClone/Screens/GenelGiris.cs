﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone
{
    public partial class GenelGiris : Form
    {
        public GenelGiris()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            adminGiris.Show();
            this.Hide();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapOlustur hesapOlustur = new HesapOlustur();
            hesapOlustur.Show();
            this.Hide();
        }

        private void GenelGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
