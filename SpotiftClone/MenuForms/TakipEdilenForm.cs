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
    public partial class TakipEdilenForm : Form
    {
        public TakipEdilenForm()
        {
            InitializeComponent();
        }

        private void TakipEdilenForm_Load(object sender, EventArgs e)
        {
            var userID = User.user.ID;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = from user in Connection.spotifydb.users
                        join follow in Connection.spotifydb.user_follows
                        on user.ID equals follow.followingID
                        where  user.ID != userID

                        select new
                        {
                            user.name,
                            user.surname,
                            user.ID

                        };

                        dataGridView1.DataSource = query.ToList();

            dataGridView1.Columns[0].HeaderText = "Ad";
            dataGridView1.Columns[1].HeaderText = "Soyad";
            this.dataGridView1.Columns[2].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userID = int.Parse( dataGridView1.CurrentRow.Cells[2].Value.ToString());
            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == userID).ToList();
            int klasik = playListID[0].ID;
            int jazz = playListID[1].ID;
            int pop = playListID[2].ID;


            var query = from playlist in Connection.spotifydb.user_playlist_songs

                        join item in Connection.spotifydb.songs
                        on playlist.songID equals item.ID
                        where playlist.playlistID == klasik
                        select new
                        {
                            item.name,
                            item.ID
                        };







            var query2 = from playlist in Connection.spotifydb.user_playlist_songs

                        join item in Connection.spotifydb.songs
                        on playlist.songID equals item.ID
                        where playlist.playlistID == pop
                        select new
                        {
                            item.name,
                            item.ID
                        };



            var query3 = from playlist in Connection.spotifydb.user_playlist_songs

                        join item in Connection.spotifydb.songs
                        on playlist.songID equals item.ID
                        where playlist.playlistID == jazz
                        select new
                        {
                            item.name,
                            item.ID
                        };


                dataGridView2.DataSource = query.ToList();
                dataGridView3.DataSource = query2.ToList();
                dataGridView4.DataSource = query3.ToList();

                this.dataGridView2.Columns[1].Visible = false;
                this.dataGridView3.Columns[1].Visible = false;
                this.dataGridView4.Columns[1].Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == User.user.ID).ToList();
            int klasik = playListID[0].ID;



            int sarki = int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString());

            var varMi = Connection.spotifydb.user_playlist_songs.Any(c=>c.songID == sarki && c.playlistID == klasik);

            if(varMi == false)
            {
                Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = klasik, songID = sarki });
                Connection.spotifydb.SaveChanges();
            }
            else
            {
                MessageBox.Show("Şarkı zaten mevcut!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == User.user.ID).ToList();
            int jazz = playListID[1].ID;



            int sarki = int.Parse(dataGridView3.CurrentRow.Cells[1].Value.ToString());

            var varMi = Connection.spotifydb.user_playlist_songs.Any(c => c.songID == sarki && c.playlistID == jazz);

            if (varMi == false)
            {
                Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = jazz, songID = sarki });
                Connection.spotifydb.SaveChanges();
            }
            else
            {
                MessageBox.Show("Şarkı zaten mevcut!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == User.user.ID).ToList();
            int pop = playListID[2].ID;



            int sarki = int.Parse(dataGridView4.CurrentRow.Cells[1].Value.ToString());

            var varMi = Connection.spotifydb.user_playlist_songs.Any(c => c.songID == sarki && c.playlistID == pop);

            if (varMi == false)
            {
                Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = pop, songID = sarki });
                Connection.spotifydb.SaveChanges();
            }
            else
            {
                MessageBox.Show("Şarkı zaten mevcut!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == User.user.ID).ToList();
            int klasik = playListID[0].ID;
            
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                var sarki = int.Parse(item.Cells[1].Value.ToString());
                var varMi = Connection.spotifydb.user_playlist_songs.Any(c => c.songID == sarki && c.playlistID == klasik);
                if (varMi == false)
                {
                    Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = klasik, songID = sarki });     
                }

            }

            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Tüm Şarkılar Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //var sarki = (dataGridView2.Rows[1].Cells[2].Value.ToString());


        }


        



        private void button4_Click(object sender, EventArgs e)
        {

            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == User.user.ID).ToList();
            int jazz = playListID[1].ID;

            foreach (DataGridViewRow item in dataGridView3.Rows)
            {
                var sarki = int.Parse(item.Cells[1].Value.ToString());
                var varMi = Connection.spotifydb.user_playlist_songs.Any(c => c.songID == sarki && c.playlistID == jazz);
                if (varMi == false)
                {
                    Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = jazz, songID = sarki });
                }

            }

            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Tüm Şarkılar Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //var sarki = (dataGridView2.Rows[1].Cells[2].Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var playListID = Connection.spotifydb.playlists.Where(c => c.userID == User.user.ID).ToList();
            int pop = playListID[2].ID;

            foreach (DataGridViewRow item in dataGridView4.Rows)
            {
                var sarki = int.Parse(item.Cells[1].Value.ToString());
                var varMi = Connection.spotifydb.user_playlist_songs.Any(c => c.songID == sarki && c.playlistID == pop);
                if (varMi == false)
                {
                    Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = pop, songID = sarki });
                }

            }

            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Tüm Şarkılar Eklendi ", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //var sarki = (dataGridView2.Rows[1].Cells[2].Value.ToString());
        }
    }
    
}
