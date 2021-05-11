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
    public partial class sanatciForm : Form
    {
        artists sanatci;
        public sanatciForm(artists sanatci)
        {
            this.sanatci = sanatci;
            InitializeComponent();
        }

        private void sanatciForm_Load(object sender, EventArgs e)
        {
            ID.Text = sanatci.ID.ToString();
            sanatciAdi.Text = sanatci.name;
            sanatciSoyad.Text = sanatci.surname;
            sahneAdi.Text = sanatci.stageName;

        }
    }
}
