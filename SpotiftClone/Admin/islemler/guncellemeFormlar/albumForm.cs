using SpotiftClone.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    public partial class albumForm : Form
    {
        albums album;
        public albumForm(albums album)
        {
            this.album = album;
            InitializeComponent();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textID.Text);
            var x = Connection.spotifydb.albums.SingleOrDefault(c => c.ID == id);
            x.name = albumAdi.Text;
            x.songCount = Convert.ToInt32(sarkiSayi.Text);
            x.date = albumTarih.Value;
            Connection.spotifydb.SaveChanges();



        }

        private void albumForm_Load(object sender, EventArgs e)
        {
            textID.Text = album.ID.ToString();
            albumAdi.Text = album.name.ToString();
            sarkiSayi.Text = album.songCount.ToString();
            albumTarih.Value = album.date;

        }
    }
}
