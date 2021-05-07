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
    public partial class chooseUserName : Form
    {
        public chooseUserName()
        {
            InitializeComponent();
            loadListUsers();
        }
        private  String saveOldPass="";
        private Boolean check = false;
        Model.MotelManagerEntities3 data = new Model.MotelManagerEntities3();
        public void loadListUsers()
        {
            var query = (from users in data.USERs
                        join staff in data.STAFFs on users.UserName equals staff.UserName
                        where users.IDRole == 2
                        select users).ToList();

            var user = from users in data.USERs
                       where users.IDRole == 2
                       select users;

            if (query.Count == 0)
            {
   
                foreach(var users in user) {
                    ListViewItem listView = new ListViewItem(users.UserName);
                    listView.SubItems.Add(users.Password);
                    listUsers.Items.Add(listView);
                }
            }
            else
            {
                foreach(var users in user)
                {
                    Boolean check = false;
                    String userName = users.UserName;
                    foreach(var checkusers in query)
                    {
                        if (userName.Equals(checkusers.UserName))
                        {
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        ListViewItem listView = new ListViewItem(userName);
                        listView.SubItems.Add(users.Password);
                        listUsers.Items.Add(listView);
                    }
                }
            }
        }
        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count > 0)
            {
                textUserName.Text = listUsers.SelectedItems[0].Text;
                textPassword.Text = listUsers.SelectedItems[0].SubItems[1].Text;
                saveOldPass = listUsers.SelectedItems[0].SubItems[1].Text;
            }
        }

        public String userName()
        {
            return textUserName.Text;
        }
        private void chooseUserName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(this.check == false)
                {
                    textUserName.Text = "";
                }
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            check = true;
            if (saveOldPass.Equals(textPassword.Text))
            {
                MessageBox.Show("Choose " + textUserName.Text + " is complete!", "COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                DialogResult d = MessageBox.Show("Are you sure change password?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    var user = data.USERs.Single(users => users.UserName.Equals(textUserName.Text));
                    user.Password = textPassword.Text;
                    data.SaveChanges();
                    MessageBox.Show("Choose " + textUserName.Text + " is complete!", "COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
