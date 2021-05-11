using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone.Admin.islemler.guncellemeFormlar
{
    public partial class albumForm : Form
    {
        albums album;
        public albumForm(albums album)
        {
            this.album = album;
            InitializeComponent();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void albumForm_Load(object sender, EventArgs e)
        {
            textID.Text = album.ID.ToString();
            albumAdi.Text = album.name.ToString();
            sarkiSayi.Text = album.songCount.ToString();
            albumTarih.Value = album.date;

        }
    }
}
