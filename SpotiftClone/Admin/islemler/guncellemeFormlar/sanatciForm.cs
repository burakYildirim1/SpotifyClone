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

namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    public partial class sanatciForm : Form
    {
        artists sanatci;
        public sanatciForm(artists sanatci)
        {
            this.sanatci = sanatci;
            InitializeComponent();
        }

        private void sanatciForm_Load(object sender, EventArgs e)
        {
            ID.Text = sanatci.ID.ToString();
            sanatciAdi.Text = sanatci.name;
            sanatciSoyad.Text = sanatci.surname;
            sahneAdi.Text = sanatci.stageName;

        }

        private void sanatciGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            var x = Connection.spotifydb.artists.SingleOrDefault(c => c.ID == id);
            x.name = sanatciAdi.Text;
            x.surname = sanatciSoyad.Text;
            x.stageName = sahneAdi.Text;
            Connection.spotifydb.SaveChanges();
        }
    }
}
