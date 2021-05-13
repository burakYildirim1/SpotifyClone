using SpotiftClone.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace SpotiftClone.Admin.islemler
{
    public partial class EklemeForm : Form
    {
        public EklemeForm()
        {
            InitializeComponent();

            var ulkeList = Connection.spotifydb.countries.ToList();
            
            foreach (var item in ulkeList)
            {
                ulkeListe.Items.Add(item.name);          
            }



        }


        private void tabPage5_Click(object sender, EventArgs e)
        {

        }


        private int GetItemIndex(string item)
        {
            int index = 0;

            foreach (object o in checkedListBox1.Items)
            {
                if (item == o.ToString())
                {
                    return index;
                }

                index++;
            }

            return -1;
        }


            private void ulkeEkle_Click(object sender, EventArgs e)
        {
            String ulkeAd =(ulkeAdi.Text.ToUpper());
            if (Connection.spotifydb.countries.FirstOrDefault(c=> c.name == ulkeAd) == null)
            {
                Connection.spotifydb.countries.Add(new countries() { name = ulkeAd });
                Connection.spotifydb.SaveChanges();
                MessageBox.Show("Ülke Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Ülke zaten listede var!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ulkeListe.Items.Clear();
            var ulkeList = Connection.spotifydb.countries.ToList();
            foreach (var item in ulkeList)
            {
                ulkeListe.Items.Add(item.name);
            }

            ulkeAdi.Clear();

        }

        private void ulkeListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int countryID = Connection.spotifydb.countries.FirstOrDefault(c => c.name == ulkeSec.SelectedItem.ToString()).ID;
            var artistt = new artists() { name = textSAdi.Text.ToLower(), surname = textSSoyad.Text.ToLower(), stageName = textSSahneAd.Text.ToLower(), countryID = countryID };
            
            Connection.spotifydb.artists.Add(artistt);
            Connection.spotifydb.SaveChanges();
            textSAdi.Clear();
            textSSahneAd.Clear();
            textSSoyad.Clear();
            MessageBox.Show("Sanatçı Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {

            //String value = SanatciAdList.Text;
            //String[] arr = value.Split('-');
            //int id = Convert.ToInt32(arr[0]);

            int id = Connection.spotifydb.artists.FirstOrDefault(c => c.name == SanatciAdList.Text).ID;
            int typeID = Connection.spotifydb.song_type.FirstOrDefault(c => c.name == sarkiTurList.Text).ID;
            Connection.spotifydb.albums.Add(new albums() { songCount = Convert.ToInt32(textSarkiSayi.Text), name = textAlbumAd.Text,
           date = albumTarih.Value, typeID = typeID , artistID = id});
           MessageBox.Show("Albüm Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.spotifydb.SaveChanges();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int typeID = Connection.spotifydb.song_type.FirstOrDefault(c => c.name == sarkiTurleri.Text).ID;
            int id = Connection.spotifydb.albums.FirstOrDefault(c => c.name == albumAdi.Text).ID;
            int artistID = Connection.spotifydb.artists.FirstOrDefault(c => c.name == sanatciAdlari.Text).ID;
            Connection.spotifydb.songs.Add(new songs() { albumID = id, typeID = typeID, name = sarkiAdi.Text,
            date = sarkiTarihi.Value, time = Convert.ToInt32(sarkiSure.Text) });
            Connection.spotifydb.SaveChanges();
            var sarkiID = Connection.spotifydb.songs.OrderByDescending(c => c.ID).Take(1).FirstOrDefault();

            Connection.spotifydb.artists_of_song.Add(new artists_of_song() { artistID = artistID, songID = sarkiID.ID });


            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Şarkı Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sanatciAdlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumAdi.Items.Clear();

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void ulkeSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(tabControl2.SelectedTab.Text == "Ülke")
            {
                var ulkeList = Connection.spotifydb.countries.ToList();
                ulkeListe.Items.Clear();
                foreach (var item in ulkeList)
                {
                    ulkeListe.Items.Add(item.name);
                }
            }




            if(tabControl2.SelectedTab.Text == "Sanatçı")
            {
                var ulkeList = Connection.spotifydb.countries.ToList();
                ulkeSec.Items.Clear();
                foreach (var item in ulkeList)
                {

                    ulkeSec.Items.Add(item.name);

                }
            }



            if (tabControl2.SelectedTab.Text == "Albüm")
            {
                var turList = Connection.spotifydb.song_type.ToList();
                sarkiTurList.Items.Clear();
                SanatciAdList.Items.Clear();
                foreach (var item in turList)
                {
                    sarkiTurList.Items.Add(item.name);

                }

                var sanatciAdiList = Connection.spotifydb.artists.ToList();
                foreach (var item in sanatciAdiList)
                {
                    SanatciAdList.Items.Add(item.name);
                   //item.ID + "-" + ------- + " " + item.surname)
                }
            }

            if(tabControl2.SelectedTab.Text == "Şarkı")
            {
                sarkiTurleri.Items.Clear();
                sanatciAdlari.Items.Clear();
                albumAdi.Items.Clear();
                var turList = Connection.spotifydb.song_type.ToList();
                foreach (var item in turList)
                {
                    sarkiTurleri.Items.Add(item.name);
                }
                //-------------------------------------------------------------
                var sanatciAdiList = Connection.spotifydb.artists.Where(c => c.state == true).ToList(); 
                foreach (var item in sanatciAdiList)
                {
                    sanatciAdlari.Items.Add(item.name);
                    checkedListBox1.Items.Add(item.name);
                }

                //-------------------------------------------------------------
                var albumAdlari = Connection.spotifydb.albums.ToList();
                foreach (var item in albumAdlari)
                {
                    albumAdi.Items.Add(item.name);
                }

            }


        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void ulkeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sarkiTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumAdi.Items.Clear();

            int id = Connection.spotifydb.artists.FirstOrDefault(c => c.name == sanatciAdlari.Text).ID;
            //int sarkiID = 6;
            //if (sarkiTurleri.Text != "")
            //{
                
            //}
            int sarkiID = Connection.spotifydb.song_type.FirstOrDefault(c => c.name == sarkiTurleri.Text).ID;
            var albumler = Connection.spotifydb.albums.Where(c => c.artistID == id && c.typeID == sarkiID).ToList();
            foreach (var item in albumler)
            {
                albumAdi.Items.Add(item.name);

            }
        }
    }
}
