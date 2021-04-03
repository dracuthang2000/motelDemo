using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMotelUser
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }
        LoginMotelUser.Model.motel_manager_demoEntities1 us = new Model.motel_manager_demoEntities1();
        private void New_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motel_manager_demoDataSet1.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.motel_manager_demoDataSet1.ROLE);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var users = (from u in us.USERs
                         where u.userName == textUsername.Text
                         select u).ToList();
            if (users.Count != 0)
            {
                MessageBox.Show("This account is exist!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                us.USERs.Add(new Model.USER
                {
                    userName = textUsername.Text.Trim().ToLower(),
                    password = textPassword.Text.Trim(),
                    idRole = Int32.Parse(roleComboBox.GetItemText(roleComboBox.SelectedValue).Trim())
                });
                DialogResult d = MessageBox.Show("Are you sure ?", "INSERT MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    us.SaveChanges();
                    this.Close();
                }
            }
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
