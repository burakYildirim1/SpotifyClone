using SpotiftClone.Database;
using System;
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
                ulkeSec.Items.Add(item.name);
               
            }
        //-------------------------------------------------------------
            var turList = Connection.spotifydb.song_type.ToList();
            foreach (var item in turList)
            {
                sarkiTurList.Items.Add(item.name);
                sarkiTurleri.Items.Add(item.name);
            }
        //-------------------------------------------------------------
            var sanatciAdiList = Connection.spotifydb.artists.ToList();
            foreach (var item in sanatciAdiList)
            {
                SanatciAdList.Items.Add(item.ID+"-"+item.name+" "+item.surname);
                sanatciAdlari.Items.Add(item.ID + "-" + item.name + " " + item.surname);
            }

         //-------------------------------------------------------------
            var albumAdlari = Connection.spotifydb.albums.ToList();
            foreach (var item in albumAdlari)
            {
                albumAdi.Items.Add(item.name);
            }




        }


        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void ulkeEkle_Click(object sender, EventArgs e)
        {
            Connection.spotifydb.countries.Add(new countries() { name = ulkeAdi.Text });
            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Ülke Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Connection.spotifydb.countries.Add(new countries() { name = ulkeAdi.Text });
            Connection.spotifydb.artists.Add(new artists() { name = textSAdi.Text.ToLower(), surname = textSSoyad.Text.ToLower(), stageName = textSSahneAd.Text.ToLower(), countryID = ulkeSec.SelectedIndex+1 });
            Connection.spotifydb.SaveChanges();
            textSAdi.Clear();
            textSSahneAd.Clear();
            textSSoyad.Clear();
            MessageBox.Show("Sanatçı Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {

            String value = SanatciAdList.Text;
            String[] arr = value.Split('-');
            int id = Convert.ToInt32(arr[0]);

            Connection.spotifydb.albums.Add(new albums() { songCount = Convert.ToInt32(textSarkiSayi.Text), name = textAlbumAd.Text,
           date = albumTarih.Value, typeID = sarkiTurList.SelectedIndex+1 , artistID = id});
           MessageBox.Show("Albüm Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.spotifydb.SaveChanges();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String value = albumAdi.Text;
            String[] arr = value.Split('-');
            int id = Convert.ToInt32(arr[0]);

            String value1 = sanatciAdlari.Text;
            String[] arr1 = value1.Split('-');
            int id1 = Convert.ToInt32(arr1[0]);


            Connection.spotifydb.songs.Add(new songs() { artistID = id1, albumID = id, typeID = sarkiTurleri.SelectedIndex + 1, name = sarkiAdi.Text,
            date = sarkiTarihi.Value, time = Convert.ToInt32(sarkiSure.Text) });
            Connection.spotifydb.SaveChanges();
            MessageBox.Show("Şarkı Eklendi", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sanatciAdlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumAdi.Items.Clear();

            String value = sanatciAdlari.Text;
            String[] arr = value.Split('-');
            int id = Convert.ToInt32(arr[0]);

            var albumler = Connection.spotifydb.albums.Where(c => c.artistID == id).ToList();
            foreach (var item in albumler)
            {
                albumAdi.Items.Add(item.ID+"-"+item.name);
                
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }
    }
}
