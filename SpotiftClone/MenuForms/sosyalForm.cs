using SpotiftClone.DataAccess.User;
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

namespace SpotiftClone.MenuForms
{
    public partial class sosyalForm : Form
    {

        public sosyalForm()
        {
            InitializeComponent();
        }

        private void sosyalForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var userID = User.user.ID;

            var query = from type in Connection.spotifydb.subscriber_type
                        join item in Connection.spotifydb.users
                        on type.ID equals item.subscriberID
                        where item.ID != userID
                        select new
                        {
                            
                            item.name,
                            item.surname,
                            type.type,
                            item.ID,
                            item.subscriberID
                        };


            dataGridView1.DataSource = query.ToList();

            dataGridView1.Columns[0].HeaderText = "Ad";
            dataGridView1.Columns[1].HeaderText = "Soyad";
            dataGridView1.Columns[2].HeaderText = "Üyelik Türü";
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userID = User.user.ID;
            var ID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            var subscriberID = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            var follower = Connection.spotifydb.users.FirstOrDefault(c=> c.ID == ID );


            var type = Connection.spotifydb.subscriber_type.SingleOrDefault(c => c.type == "Premium").ID;

            var followList = Connection.spotifydb.user_follows.FirstOrDefault(c => c.followingID == follower.ID && c.userID == userID);

            if(followList == null)
            {
                if (subscriberID == type)
                {
                    Connection.spotifydb.user_follows.Add(new user_follows() { userID = userID, followingID = follower.ID });
                    Connection.spotifydb.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Sadece premium kullanıcılar takip edebilir!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı zaten takip ediliyor!", "Spotify Clone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
            
               
        }
    }
}
