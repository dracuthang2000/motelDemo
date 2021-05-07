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
            setColor();
        }
        private bool checkClick = false;
        LoginMotelUser.Model.MotelManagerEntities3 us = new Model.MotelManagerEntities3();
        private void New_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motelManagerDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter1.Fill(this.motelManagerDataSet.ROLE);
            this.uSERTableAdapter1.Fill(this.motelManagerDataSet.USER);
            var query = (from u in us.USERs
                         orderby u.UserName
                     select new { u.UserName, u.Password, u.ROLE.RoleName }).ToList();
            this.uSERBindingSource1.DataSource = query;
        }
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkClick == false)
            {
                var users = (from u in us.USERs
                             orderby u.UserName descending
                             select new { u.UserName, u.Password, u.ROLE.RoleName }).ToList();
                this.uSERBindingSource1.DataSource = users;
                checkClick = true;
            }
            else
            {
                var users = (from u in us.USERs
                             orderby u.UserName ascending
                             select new { u.UserName, u.Password, u.ROLE.RoleName }).ToList();
                this.uSERBindingSource1.DataSource = users;
                checkClick = false;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                dataGridView1.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            var users = (from u in us.USERs
                         where u.UserName == textUsername.Text
                         select u).ToList();
            if (users.Count != 0)
            {
                MessageBox.Show("This account is exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("UserName is not null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Password is not null", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d = MessageBox.Show("Are you sure ?", "INSERT MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    us.USERs.Add(new Model.USER
                    {
                        UserName = textUsername.Text.Trim().ToLower(),
                        Password = textPassword.Text.Trim(),
                        IDRole = Int32.Parse(roleComboBox.GetItemText(roleComboBox.SelectedValue).Trim())
                    });
                    us.SaveChanges();
                    this.New_User_Load(sender, e);
                    textPassword.Text = "";
                    textUsername.Text = "";
                    roleComboBox.SelectedIndex = 0;
                }
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            //this.panel.BackColor = System.Drawing.Color.Transparent;
        }

    }
}
