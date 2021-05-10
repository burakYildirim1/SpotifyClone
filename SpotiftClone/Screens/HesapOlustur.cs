using SpotiftClone.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone
{
    public partial class HesapOlustur : Form
    {
        public HesapOlustur()
        {
            InitializeComponent();
        }

        private void HesapOlustur_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            EFUserDal eFUserDal = new EFUserDal();
            if(eFUserDal.checkIfEmail(textMail.Text))
            {
                var subscribeID = (comboBox1.SelectedIndex == 0) ? 1 : 2;
                eFUserDal.addUser(new users()
                {
                    name = textAd.Text,
                    surname = textSoyad.Text,
                    mail = textMail.Text,
                    password = textSifre.Text,
                    subscriberID = subscribeID,
                    countryID = 1
                });
                
            }

            else
            {
                MessageBox.Show("Bu mail adresiyle eşleşen hesap mevcut!","Spotify Clone",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            GenelGiris girisYap = new GenelGiris();
            girisYap.Show();
            this.Hide();



        }

    }
}
