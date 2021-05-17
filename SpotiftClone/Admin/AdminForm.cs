using SpotiftClone.Admin.islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiftClone.Admin
{
    public partial class AdminForm : Form
    {

        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }

            public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            EklemeForm eklemeForm = new EklemeForm();
            FormGetir(eklemeForm);
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            GuncellemeForm guncellemeForm = new GuncellemeForm();
            FormGetir(guncellemeForm);
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            SilmeForm silmeForm = new SilmeForm();
            FormGetir(silmeForm);
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            VeritabaniForm veritabaniForm = new VeritabaniForm();
            FormGetir(veritabaniForm);
        }
    }
}
