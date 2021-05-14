using SpotiftClone.DataAccess.User;
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

namespace SpotiftClone.MenuForms
{
    public partial class playListForm : Form
    {
        public playListForm()
        {
            InitializeComponent();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();




            var query = Connection.spotifydb.playlists.SingleOrDefault(c => c.userID == User.user.ID && c.songTypeID == 6).ID;

            // var query2 = Connection.spotifydb.user_playlist_songs.Where(c => c.playlistID == query).ToList();
            var query2 = from song in Connection.spotifydb.songs
            join plSong in Connection.spotifydb.user_playlist_songs
            on song.ID equals plSong.songID
            where (plSong.playlistID == query)
            select new
            {
                plSong.ID,
                song.name
            };



            dataGridView1.DataSource = query2.ToList();
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            var query = Connection.spotifydb.playlists.SingleOrDefault(c => c.userID == User.user.ID && c.songTypeID == 8).ID;

            // var query2 = Connection.spotifydb.user_playlist_songs.Where(c => c.playlistID == query).ToList();
            var query2 = from song in Connection.spotifydb.songs
                         join plSong in Connection.spotifydb.user_playlist_songs
                         on song.ID equals plSong.songID
                         where (plSong.playlistID == query)
                         select new
                         {
                             plSong.ID,
                             song.name
                         };



            dataGridView1.DataSource = query2.ToList();
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            var query = Connection.spotifydb.playlists.SingleOrDefault(c => c.userID == User.user.ID && c.songTypeID == 7).ID;

            // var query2 = Connection.spotifydb.user_playlist_songs.Where(c => c.playlistID == query).ToList();
            var query2 = from song in Connection.spotifydb.songs
                         join plSong in Connection.spotifydb.user_playlist_songs
                         on song.ID equals plSong.songID
                         where (plSong.playlistID == query)
                         select new
                         {
                             plSong.ID,
                             song.name
                         };



            dataGridView1.DataSource = query2.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deleteID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var delete = Connection.spotifydb.user_playlist_songs.SingleOrDefault(c => c.ID == deleteID);
            Connection.spotifydb.user_playlist_songs.Remove(delete);
            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Şarkı silindi!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Refresh();

        }
    }
}
