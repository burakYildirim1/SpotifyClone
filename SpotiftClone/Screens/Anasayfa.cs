using SpotiftClone.DataAccess;
using SpotiftClone.DataAccess.User;
using SpotiftClone.MenuForms;
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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
       // private void FormGetir(Form frm)
        //{
         //   panel5.Controls.Clear();
          //  frm.MdiParent = this;
           // frm.FormBorderStyle = FormBorderStyle.None;
            //panel5.Controls.Add(frm);
            //frm.Show();

//        }

        private void FormGetir2(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            FormGetir2(anasayfaForm);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            FormGetir2(anasayfaForm);
            
        }

        private void anasayfaUsername_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            playListForm playListForm = new playListForm();
            FormGetir2(playListForm);


        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            TakipEdilenForm takipEdilenForm = new TakipEdilenForm();
            FormGetir2(takipEdilenForm);
        }
    }
}
