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

namespace SpotiftClone.Admin.islemler.silmeFormlar
{
    public partial class sarkiFormSilme : Form
    {
        songs sarki;
        public sarkiFormSilme(songs sarki)
        {
            this.sarki = sarki;
            InitializeComponent();
        }

        private void sarkiSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            var x = Connection.spotifydb.songs.SingleOrDefault(c => c.ID == id);
            x.name = "Silinmiş şarkı";
            x.state = false;
            Connection.spotifydb.SaveChanges();
        }

        private void sarkiFormSilme_Load(object sender, EventArgs e)
        {
            ID.Text = sarki.ID.ToString();
            sarkiAdi.Text = sarki.name;
        }
    }
}
