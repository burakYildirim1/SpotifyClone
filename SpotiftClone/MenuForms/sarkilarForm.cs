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
    public partial class sarkilarForm : Form
    {
        songs sarki = new songs();
        user_playlist_songs playlist = new user_playlist_songs();
        playlists playlists = new playlists();

        public sarkilarForm()
        {
            InitializeComponent();
        }



        private void sarkilarForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = from artSong in Connection.spotifydb.artists_of_song
                        join artist1 in Connection.spotifydb.artists
                        on artSong.artistID equals artist1.ID 

                        join songs in Connection.spotifydb.songs
                        on artSong.songID equals songs.ID where(songs.state == true)

                        select new
                        {   
                            artistName = artist1.name,
                            songs.name,
                        };

            
            dataGridView1.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır

            dataGridView1.Columns[0].HeaderText = "Sanatçı Adı";
            dataGridView1.Columns[1].HeaderText = "Şarkı Adı";


        }

        private void playListeEkle_Click(object sender, EventArgs e)
        {

            var x = dataGridView1.CurrentRow.Cells[1].Value.ToString();//seçilen satırdaki sarki adini aliyoruz
            //var y = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var sarkiID = Connection.spotifydb.songs.FirstOrDefault(c => c.name == x).ID;//songs tablosundan, secilen sarkinin ID'sini aliyoruz
            var typeID = Connection.spotifydb.songs.FirstOrDefault(c => c.name == x).typeID;//songs tablosundan, secilen sarkinin typeID'sini aliyoruz
            var userID = User.user.ID; // giris yapan kullanicinin IDsi
            var playListID = Connection.spotifydb.playlists.SingleOrDefault(c => c.userID == userID && c.songTypeID == typeID).ID;  //playlist tablosundan; secilen sarkinin ve sarkiyi secen kullanıcının
            //idsini iceren satirin ID'sini aliyoruz (yani o sarkinin bulundugu playList IDsi)
            //MessageBox.Show("songID: " + typeID);
            
            var plTypeID = Connection.spotifydb.playlists.SingleOrDefault(c => c.userID == userID && c.songTypeID == typeID).songTypeID; //playlist tablosundan; giris yapan kullanicinin IDsine ve
            //secilen sarkinin typeID'sine esit satirin, typeIDsi?? (bu degisken degeri her zaman typeID ile esit)
            //MessageBox.Show("plTypeID: " + plTypeID);
            var sorgu = Connection.spotifydb.user_playlist_songs.Where(c => c.playlistID == playListID && c.songID == sarkiID ).Count();//sarkinin kullanicinin playlistinde olup olmadiginin kontrolu
            if(sorgu>0)
            {
                MessageBox.Show("Şarkı daha önce eklenmiş!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Connection.spotifydb.user_playlist_songs.Add(new user_playlist_songs() { playlistID = playListID, songID = sarkiID });

                Connection.spotifydb.SaveChanges();
                MessageBox.Show("Playliste Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           
            
            
        }
    }
}
