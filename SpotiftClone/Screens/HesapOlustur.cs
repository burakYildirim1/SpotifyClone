﻿using SpotiftClone.DataAccess;
using SpotiftClone.Database;
using System;
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
    public partial class HesapOlustur : Form
    {
        public HesapOlustur()
        {
            InitializeComponent();
        }

        private void HesapOlustur_Load(object sender, EventArgs e)
        {
            var ulkeList = Connection.spotifydb.countries.ToList();
            foreach (var item in ulkeList)
            {
                ulkeListe.Items.Add(item.name);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            EFUserDal eFUserDal = new EFUserDal();
            if(eFUserDal.checkIfEmail(textMail.Text))
            {
                var subscribeID = Connection.spotifydb.subscriber_type.FirstOrDefault(c => c.type == comboBox1.Text).ID;
                var countryID = Connection.spotifydb.countries.FirstOrDefault(c => c.name == ulkeListe.Text).ID;

                //var subscribeID = (comboBox1.SelectedIndex == 0) ? 3 : 4; //database'den idleri alıp ata --- country id aynı sekilde
                eFUserDal.addUser(new users()
                {
                    name = textAd.Text,
                    surname = textSoyad.Text,
                    mail = textMail.Text,
                    password = textSifre.Text,
                    subscriberID = subscribeID,
                    countryID = countryID
                });
                
            }

            else
            {
                MessageBox.Show("Bu mail adresiyle eşleşen hesap mevcut!","Spotify Clone",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            GenelGiris girisYap = new GenelGiris();
            girisYap.Show();
            this.Hide();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                textSifre.UseSystemPasswordChar = false;
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                textSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
