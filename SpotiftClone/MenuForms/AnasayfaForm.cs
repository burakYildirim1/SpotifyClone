using SpotiftClone.DataAccess.User;
using SpotiftClone.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone.MenuForms
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
            anasayfaUsername.Text = User.user.name.ToUpper() + "\n" + User.user.surname.ToUpper();
        }

        private void anasayfaUsername_Click(object sender, EventArgs e)
        {

        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            var ulkeList = Connection.spotifydb.countries.ToList();
            ulkeListe.Items.Insert(0, "Ülkelere Göre");
            ulkeListe.SelectedIndex = 0;
            foreach (var item in ulkeList)
            {
                ulkeListe.Items.Add(item.name);
            }




            // var query = Connection.spotifydb.songs.Where(c => c.state == true).ToList();



            var query1 = from sarki in Connection.spotifydb.songs
                         join artistSong in Connection.spotifydb.artists_of_song
                         on sarki.ID equals artistSong.songID
                         join artist in Connection.spotifydb.artists
                         on artistSong.artistID equals artist.ID
                         where(sarki.state==true)
                         select new
                         {
                             sarki.ID,
                             sarki.name,
                             artist1 = artist.name,
                             artist.surname,
                             sarkiName =(sarki.time)/60.0

        };

            
            dataGridView1.DataSource = query1.ToList();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[0].Visible = false;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            var countryID=User.user.countryID;
            var sarkiID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = Connection.spotifydb.songs.SingleOrDefault(c => c.ID == sarkiID);
            query.playedCount++;

            var query2 = Connection.spotifydb.playedcount_countries.Where(c => c.countryID == countryID && c.songID == sarkiID).Count();
            
            if(query2 == 0)
            {
                Connection.spotifydb.playedcount_countries.Add(new playedcount_countries() { countryID = countryID, songID = sarkiID,playedCount = 1 });
                
            }
            
            else
            {
               var result = Connection.spotifydb.playedcount_countries.SingleOrDefault(c => c.countryID == countryID && c.songID == sarkiID);
               result.playedCount++;
            }

            Connection.spotifydb.SaveChanges();
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            int next = this.dataGridView1.CurrentRow.Index + 1;
            if (next < dataGridView1.RowCount)
            {
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[next].Cells[this.dataGridView1.CurrentCell.ColumnIndex];
            }
                
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int prev = this.dataGridView1.CurrentRow.Index - 1;
            if(prev>=0)
            {
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[prev].Cells[this.dataGridView1.CurrentCell.ColumnIndex];
            }
            
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = Connection.spotifydb.songs.OrderByDescending(c => c.playedCount).Take(10).ToList();
            dataGridView1.DataSource = query.ToList();


            var query1 = (from sarki in Connection.spotifydb.songs
                         join artistSong in Connection.spotifydb.artists_of_song
                         on sarki.ID equals artistSong.songID
                         join artist in Connection.spotifydb.artists
                         on artistSong.artistID equals artist.ID
                         where (sarki.state == true ) orderby sarki.playedCount descending 
                         select new
                         {
                             sarki.ID,
                             sarki.name,
                             artist1 = artist.name,
                             artist.surname,
                             sure = (sarki.time) / 60.0,
                             sarki.playedCount

                         }).Take(10);


            dataGridView1.DataSource = query1.ToList();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[0].Visible = false;


        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = Connection.spotifydb.songs.OrderByDescending(c => c.playedCount).Take(10).ToList();
            dataGridView1.DataSource = query.ToList();


            var query1 = (from sarki in Connection.spotifydb.songs
                          join artistSong in Connection.spotifydb.artists_of_song
                          on sarki.ID equals artistSong.songID
                          join artist in Connection.spotifydb.artists
                          on artistSong.artistID equals artist.ID
                          where (sarki.state == true && sarki.typeID == 6)
                          orderby sarki.playedCount descending
                          select new
                          {
                              sarki.ID,
                              sarki.name,
                              artist1 = artist.name,
                              artist.surname,
                              sure = (sarki.time) / 60.0,
                              sarki.playedCount

                          }).Take(10);


            dataGridView1.DataSource = query1.ToList();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[0].Visible = false;
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = Connection.spotifydb.songs.OrderByDescending(c => c.playedCount).Take(10).ToList();
            dataGridView1.DataSource = query.ToList();


            var query1 = (from sarki in Connection.spotifydb.songs
                          join artistSong in Connection.spotifydb.artists_of_song
                          on sarki.ID equals artistSong.songID
                          join artist in Connection.spotifydb.artists
                          on artistSong.artistID equals artist.ID
                          where (sarki.state == true && sarki.typeID == 7)
                          orderby sarki.playedCount descending
                          select new
                          {
                              sarki.ID,
                              sarki.name,
                              artist1 = artist.name,
                              artist.surname,
                              sure = (sarki.time) / 60.0,
                              sarki.playedCount

                          }).Take(10);


            dataGridView1.DataSource = query1.ToList();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[0].Visible = false;
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var query = Connection.spotifydb.songs.OrderByDescending(c => c.playedCount).Take(10).ToList();
            dataGridView1.DataSource = query.ToList();


            var query1 = (from sarki in Connection.spotifydb.songs
                          join artistSong in Connection.spotifydb.artists_of_song
                          on sarki.ID equals artistSong.songID
                          join artist in Connection.spotifydb.artists
                          on artistSong.artistID equals artist.ID
                          where (sarki.state == true && sarki.typeID == 8)
                          orderby sarki.playedCount descending
                          select new
                          {
                              sarki.ID,
                              sarki.name,
                              artist1 = artist.name,
                              artist.surname,
                              sure = (sarki.time) / 60.0,
                              sarki.playedCount

                          }).Take(10);


            dataGridView1.DataSource = query1.ToList();
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[0].Visible = false;
        }

        private void ulkeListe_SelectedIndexChanged(object sender, EventArgs e)
        {


            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int countryID = 1;
            var firstID = Connection.spotifydb.countries.FirstOrDefault(c => c.name == ulkeListe.Text);
            if (firstID != null)
            {
                countryID = Connection.spotifydb.countries.FirstOrDefault(c => c.name == ulkeListe.Text).ID;
            }
            

            



            //var query = Connection.spotifydb.songs.OrderByDescending(c => c.playedCount).Take(10).ToList();
            //dataGridView1.DataSource = query.ToList();


            var query1 = (from playedcount_countries in Connection.spotifydb.playedcount_countries
                                      join songs in Connection.spotifydb.songs
                                      on playedcount_countries.songID equals songs.ID
                                      where(playedcount_countries.countryID == countryID )
                                     orderby playedcount_countries.playedCount descending
                                    select new
                                      {
                                          songs.ID,
                                          songs.name,
                                          playedcount_countries.playedCount
                                      }).Take(10);
                   



            dataGridView1.DataSource = query1.ToList();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
