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

namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    
    public partial class sarkiForm : Form
    {
        songs sarki = new songs();
        public sarkiForm(songs sarki)
        {
            this.sarki = sarki;
            InitializeComponent();
        }

        private void sarkiForm_Load(object sender, EventArgs e)
        {
            ID.Text = sarki.ID.ToString();
            sarkiAdi.Text = sarki.name;
            sarkiTarih.Value = sarki.date;
            sarkiSuresi.Text = sarki.time.ToString();

        }

        private void sarkiGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((ID.Text).ToString());
            var x = Connection.spotifydb.songs.SingleOrDefault(c => c.ID == id);
            x.name = sarkiAdi.Text;
            x.date = sarkiTarih.Value;
            x.time =Convert.ToInt32(sarkiSuresi.Text);
            Connection.spotifydb.SaveChanges();
        }
    }
}
