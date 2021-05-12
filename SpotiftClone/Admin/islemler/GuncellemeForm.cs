using SpotiftClone.Admin.islemler.guncellemeFormlar;
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

        albums album = new albums();
        artists sanatci = new artists();
        songs sarki = new songs();

        byte control = 0;
        private void FormGetir(Form frm)
        {
            panelGuncel.Controls.Clear();
            frm.MdiParent = this.ParentForm;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelGuncel.Controls.Add(frm);
            frm.Show();
        }


        public GuncellemeForm()
        {
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            //var query = from item in Connection.spotifydb.albums
            //            from item2 in Connection.spotifydb.artists
            //            where item.state == true && item2.ID == item.ID
            //            select new
            //            {
            //                ad = item2.name,
            //                item.ID,
            //                item.songCount,
            //                item.name,
            //                item.date
            //            };

            // 



            var query = from artists1 in Connection.spotifydb.artists
                        join album1 in Connection.spotifydb.albums
                        on artists1.ID equals album1.artistID
                        select new
                        {
                            artistName = artists1.name,
                            album1.name,
                            album1.ID,
                            album1.songCount,
                            album1.date

                        };
            
            dataGridView1.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            dataGridView1.Columns[0].HeaderText = "Sanatçı Adı";
            control = 0;




        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var query = from item in Connection.spotifydb.artists where item.state == true
                        select new 
                        {
                            item.ID,
                            item.name,
                            item.surname,
                            item.stageName,
                        }  ;


            dataGridView1.DataSource = query.ToList();



            control = 1;
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            var query = from artists1 in Connection.spotifydb.artists
                        join sarki1 in Connection.spotifydb.songs
                        on artists1.ID equals sarki1.artistID
                        select new
                        {
                            artistName = artists1.name,
                            sarki1.name,
                            sarki1.ID,
                            sarki1.time,
                            sarki.playedCount

                        };

            dataGridView1.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            dataGridView1.Columns[0].HeaderText = "Sanatçı Adı";
            control = 2;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (control == 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;
                album.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                album.songCount = (int)(dataGridView1.CurrentRow.Cells[1].Value);

                album.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                album.date = Convert.ToDateTime (dataGridView1.CurrentRow.Cells[3].Value.ToString());
                albumForm albumForm = new albumForm(album);
                FormGetir(albumForm);
            }
            else if (control == 1)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;

                sanatci.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sanatci.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sanatci.surname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sanatci.stageName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sanatciForm sanatciForm = new sanatciForm(sanatci);
                FormGetir(sanatciForm);
            }

            else
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;
                sarki.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sarki.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sarki.date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                sarki.time = (int)(dataGridView1.CurrentRow.Cells[3].Value);
                sarkiForm sarkiForm = new sarkiForm(sarki);
                FormGetir(sarkiForm);
            }
            GC.Collect();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelGuncel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
