using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using SpotiftClone.DataAccess;
using SpotiftClone.DataAccess.User;

namespace SpotiftClone
{
    public partial class KullaniciGiris : Form
    {

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            EFUserDal eFUserDal = new EFUserDal();
            User.user = eFUserDal.login(txtUserMail.Text, txtUserPass.Text);
            if (User.user != null)
            {
                Anasayfa anasyf = new Anasayfa();
                anasyf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yetkisiz giriş!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
           
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
