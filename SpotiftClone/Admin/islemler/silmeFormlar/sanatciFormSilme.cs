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
    public partial class sanatciFormSilme : Form
    {
        artists sanatci;
        public sanatciFormSilme(artists sanatci)
        {
            this.sanatci = sanatci;
            InitializeComponent();
        }

        private void sanatciSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            var x = Connection.spotifydb.artists.SingleOrDefault(c => c.ID == id);
            x.name = "Silinmiş sanatçı";
            x.surname = "Silinmiş sanatçı";
            x.state = false;
            Connection.spotifydb.SaveChanges();

        }

        private void sanatciFormSilme_Load(object sender, EventArgs e)
        {

            ID.Text = sanatci.ID.ToString();
            sanatciAdi.Text = sanatci.name;
            sanatciSoyad.Text = sanatci.surname;
        }
    }
}
