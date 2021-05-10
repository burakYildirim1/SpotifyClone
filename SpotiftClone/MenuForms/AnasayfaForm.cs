using SpotiftClone.DataAccess.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
