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
    public partial class VeritabaniForm : Form
    {
        public VeritabaniForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = from admin in Connection.spotifydb.admins
                        join user in Connection.spotifydb.users
                        on admin.userID equals user.ID

                        select new
                        {
                            user.name,
                            user.surname


                        };

            dataGridView1.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır

            dataGridView1.Columns[0].HeaderText = "Ad";
            dataGridView1.Columns[1].HeaderText = "Soyad";
        }
        
        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab.Text == "Admins")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                var query = from admin in Connection.spotifydb.admins
                            join user in Connection.spotifydb.users
                            on admin.userID equals user.ID
                           
                            select new
                            {
                                user.name,
                                user.surname
                               

                            };

                dataGridView1.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır

                dataGridView1.Columns[0].HeaderText = "Ad";
                dataGridView1.Columns[1].HeaderText = "Soyad";
               
            }
            if (tabControl2.SelectedTab.Text == "Albums")
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();

                var query = from album in Connection.spotifydb.albums
                            join artist in Connection.spotifydb.artists
                            on album.artistID equals artist.ID
                            join stype in Connection.spotifydb.song_type
                            on album.typeID equals stype.ID

                            select new
                            {
                                artistAd=artist.name,
                                album.name,
                                album.date,
                                album.songCount,
                                SarkiTuru=stype.name


                            };


                dataGridView2.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır


            }
            if (tabControl2.SelectedTab.Text == "Artist")
            {
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();

                var query = from artist in Connection.spotifydb.artists
                            join country in Connection.spotifydb.countries
                            on artist.countryID equals country.ID
                           

                            select new
                            {
                                artist.name ,
                                artist.surname,
                                artist.stageName,
                                Ulke=country.name                                


                            };

                dataGridView3.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "ArtistOfSongs")
            {
                dataGridView4.DataSource = null;
                dataGridView4.Rows.Clear();
                dataGridView4.Refresh();

                var query = from artistSong in Connection.spotifydb.artists_of_song
                            join artist in Connection.spotifydb.artists
                            on artistSong.artistID equals artist.ID
                            join song in Connection.spotifydb.songs
                            on artistSong.songID equals song.ID


                            select new
                            {
                                artist.name,
                                artist.surname,
                                sarki=song.name


                            };

                dataGridView4.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "Countries")
            {
                dataGridView5.DataSource = null;
                dataGridView5.Rows.Clear();
                dataGridView5.Refresh();

                var query = from countrie in Connection.spotifydb.countries
                           
                            select new
                            {
                                countrie.name,
                               

                            };


                dataGridView5.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "PlayedCountCountries")
            {
                dataGridView6.DataSource = null;
                dataGridView6.Rows.Clear();
                dataGridView6.Refresh();

                var query = from playedCountCountri in Connection.spotifydb.playedcount_countries
                            join countrie in Connection.spotifydb.countries
                            on playedCountCountri.countryID equals countrie.ID
                            join song in Connection.spotifydb.songs
                            on playedCountCountri.songID equals song.ID


                            select new
                            {
                                countrie.name,
                                sakiAdi=song.name,
                                playedCountCountri.playedCount


                            };

                dataGridView6.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "Playlists")
            {
                dataGridView7.DataSource = null;
                dataGridView7.Rows.Clear();
                dataGridView7.Refresh();

                var query = from playlist in Connection.spotifydb.playlists
                            join user in Connection.spotifydb.users
                            on playlist.userID equals user.ID
                            join songtype in Connection.spotifydb.song_type
                            on playlist.songTypeID equals songtype.ID


                            select new
                            {
                                user.name,
                                albumTuru=songtype.name
                                


                            };

                dataGridView7.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "Songs")
            {
                dataGridView8.DataSource = null;
                dataGridView8.Rows.Clear();
                dataGridView8.Refresh();

                var query = from song in Connection.spotifydb.songs
                            join album in Connection.spotifydb.albums
                            on song.albumID equals album.ID
                            join songtype in Connection.spotifydb.song_type
                            on song.typeID equals songtype.ID


                            select new
                            {
                                song.name,
                                albumAdi = album.name,
                                sarkiTuru=songtype.name,
                                song.date,
                                song.time,
                                song.playedCount



                            };


                dataGridView8.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "SongType")
            {
                dataGridView9.DataSource = null;
                dataGridView9.Rows.Clear();
                dataGridView9.Refresh();

                var query = from songtype in Connection.spotifydb.song_type
                            select new
                            {
                                songtype.name,
                               



                            };


                dataGridView9.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır

            }
            if (tabControl2.SelectedTab.Text == "SubscriberType")
            {
                dataGridView10.DataSource = null;
                dataGridView10.Rows.Clear();
                dataGridView10.Refresh();

                var query = from subType in Connection.spotifydb.subscriber_type
                            select new
                            {
                                subType.type,
                                                                                             
                            };


                dataGridView10.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır

            }
            if (tabControl2.SelectedTab.Text == "Users")
            {
                dataGridView11.DataSource = null;
                dataGridView11.Rows.Clear();
                dataGridView11.Refresh();

                var query = from user in Connection.spotifydb.users
                            join countri in Connection.spotifydb.countries
                            on user.countryID equals countri.ID
                            join subtype in Connection.spotifydb.subscriber_type
                            on user.subscriberID equals subtype.ID


                            select new
                            {
                                user.name,
                                user.surname,
                                user.mail,
                                user.password,
                                subtype.type,
                                ulke=countri.name
                                



                            };

                dataGridView11.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "UserFollows")
            {
                dataGridView12.DataSource = null;
                dataGridView12.Rows.Clear();
                dataGridView12.Refresh();

                var query = from userfollow in Connection.spotifydb.user_follows
                            join user in Connection.spotifydb.users
                            on userfollow.userID equals user.ID

                            join user1 in Connection.spotifydb.users
                            on userfollow.followingID equals user1.ID


                            select new
                            {
                                takipEdenAd=user.name,
                                takipEdenSoyad= user.surname,
                                takipEdilenAd=user1.name,
                                takipEdilenSoyad = user1.surname,




                            };


                dataGridView12.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            }
            if (tabControl2.SelectedTab.Text == "UserPlaylistSongs")
            {
                dataGridView13.DataSource = null;
                dataGridView13.Rows.Clear();
                dataGridView13.Refresh();

                var query = from userplaylist in Connection.spotifydb.user_playlist_songs
                            join playslit in Connection.spotifydb.playlists
                            on userplaylist.playlistID equals playslit.ID

                            join song in Connection.spotifydb.songs
                            on userplaylist.songID equals song.ID
                            join user in Connection.spotifydb.users
                            on playslit.userID equals user.ID

                            join songType in Connection.spotifydb.song_type
                           on song.typeID equals songType.ID

                            select new
                            {
                               user.name,
                               sarkiAdı= song.name,
                               albumTuru= songType.name




                            };


                dataGridView13.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır

            }
        }
    }
}
