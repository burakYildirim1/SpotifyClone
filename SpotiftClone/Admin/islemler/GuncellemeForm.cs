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
            var query = from item in Connection.spotifydb.albums
                        select new
                        {
                           // item.artists,
                           // item.song_type,
                            item.ID,
                            item.songCount,
                            item.name,
                            item.date
                        };


            dataGridView1.DataSource = query.ToList();

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            var query = from item in Connection.spotifydb.artists
                        select new
                        {
                            item.ID,
                            item.name,
                            item.surname,
                            item.stageName,
                        };


            dataGridView1.DataSource = query.ToList();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            var query = from item in Connection.spotifydb.songs
                        select new
                        {
                            item.ID,
                            item.name,
                            item.date,
                            item.time,
                            item.playedCount
                        };


            dataGridView1.DataSource = query.ToList();
        }
    }
}
