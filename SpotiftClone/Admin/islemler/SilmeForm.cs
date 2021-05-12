using SpotiftClone.Admin.islemler.silmeFormlar;
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
    public partial class SilmeForm : Form
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

        public SilmeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var query = from item in Connection.spotifydb.albums where item.state == true
                        select new
                        {
                            // item.artists,
                            // item.song_type,
                            item.ID,
                            item.songCount,
                            item.name,
                            item.date
                        };


            dataGridView1.DataSource = query.ToList(); //queryden gelen dataları liste olarak yazdır
            control = 0;
        }

        private void btnSanatci_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var query = from item in Connection.spotifydb.artists 
                        where item.state == true
                        select new
                        {
                            item.ID,
                            item.name,
                            item.surname,
                            item.stageName,
                        };


            dataGridView1.DataSource = query.ToList();



            control = 1;
        }

        private void btnSarki_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            var query = from item in Connection.spotifydb.songs
                        where item.state == true
                        select new
                        {
                            item.ID,
                            item.name,
                            item.date,
                            item.time,
                            item.playedCount
                        };


            dataGridView1.DataSource = query.ToList();
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
                album.date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                albumFormSilme albumForm = new albumFormSilme(album);
                FormGetir(albumForm);
            }
            else if (control == 1)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;

                sanatci.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sanatci.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sanatci.surname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sanatci.stageName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sanatciFormSilme sanatciForm = new sanatciFormSilme(sanatci);
                FormGetir(sanatciForm);
            }

            else
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Red;
                sarki.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sarki.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sarki.date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                sarki.time = (int)(dataGridView1.CurrentRow.Cells[3].Value);
                sarkiFormSilme sarkiForm = new sarkiFormSilme(sarki);
                FormGetir(sarkiForm);
            }
            GC.Collect();
        }
    }
}
