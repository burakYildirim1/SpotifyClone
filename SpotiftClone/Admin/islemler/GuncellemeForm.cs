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

namespace SpotiftClone.Admin.islemler
{
    public partial class GuncellemeForm : Form
    {
        public GuncellemeForm()
        {
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            //spotifydbEntities 
            var album = Connection.spotifydb.albums.ToList();

            dataGridView1.DataSource = album;

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            var sanatcilar = Connection.spotifydb.artists.ToList();

            dataGridView1.DataSource = sanatcilar;
        }
    }
}
