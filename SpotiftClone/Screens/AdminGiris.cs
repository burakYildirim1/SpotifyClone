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
using SpotiftClone.Database;

namespace SpotiftClone
{
    public partial class AdminGiris : Form
    {
        
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            EFUserDal eFUserDal = new EFUserDal();
            var user = eFUserDal.login(txtMail.Text, txtPassword.Text);
            if(eFUserDal.checkIfAdmin(user))
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

       
    }
}
