﻿using SpotiftClone.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone.Admin.islemler.silmeFormlar
{
    public partial class albumFormSilme : Form
    {
        albums album;
        public albumFormSilme(albums album)
        {
            this.album = album;
            InitializeComponent();
        }

        private void albumSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = Connection.spotifydb.albums.SingleOrDefault(c => c.ID == id);
            x.name = "Silinmis album";
            x.state = false;
            Connection.spotifydb.SaveChanges();
        }

        private void albumFormSilme_Load(object sender, EventArgs e)
        {
            textID.Text = album.ID.ToString();
            albumAdi.Text = album.name.ToString();
        }
    }
}
