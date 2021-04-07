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
    /// <summary>
    ///  adadadadadad
    /// </summary>
    public partial class Admin_Formcs : Form
    {
        LoginMotelUser.Model.MotelManagerEntities us = new Model.MotelManagerEntities();
        public Admin_Formcs()
        {
            InitializeComponent();
            this.FormClosed += Admin_Formcs_Close;
        }
        public bool isClose { get; set; }
        public bool checkRole { get; set; }
        public String checkUsername { get; set; }

        //public 
        private void Admin_Formcs_Close(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                isClose = true;
                return;
            }
        }


        private void Admin_Formcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motelManagerDataSet.USER' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'motel_manager_demoDataSet1.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.motel_manager_demoDataSet1.ROLE);
            var query = (from u in us.USERs
                         select new { u.UserName, u.Password, u.ROLE.RoleName }).ToList();
            this.uSERBindingSource2.DataSource = query;
            if (this.checkRole == false)
            {
                newtUserMenuItem.Enabled = false;
                updateuserMenuItem.Enabled = false;
            }
            else
            {
                newtUserMenuItem.Enabled = true;
                updateMenuItem.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var a = us.USERs.Join(us.ROLEs, u => u.IDRole, r => r.ID, (u, r) => new { u, r })
                .Where(ur => ur.r.ID == ur.u.IDRole && ur.u.UserName.Contains(Search_admin.Text)|| ur.r.RoleName.Contains(Search_admin.Text))
             .Select(ur => new { ur.u.UserName, ur.u.Password, ur.r.RoleName }).ToList();
            this.uSERBindingSource2.DataSource = a;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            String uN = passWordText.Text;
            uN.Trim();

            us.USERs.Add(new Model.USER
            {
                UserName = userName_text.Text.Trim(),
                Password = passWordText.Text.Trim(),
                IDRole = Int32.Parse(roleCombobox.GetItemText(roleCombobox.SelectedValue).Trim())
            });
            DialogResult d = MessageBox.Show("Are you sure ?", "INSERT MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d== DialogResult.Yes)
            {
                us.SaveChanges();
            }
            Admin_Formcs_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                dataUserName.CurrentRow.Selected = true;
                userName_text.Text = dataUserName.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                passWordText.Text = dataUserName.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                String i = dataUserName.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                if (i.Equals("admin"))
                {
                    roleCombobox.SelectedIndex=0;
                }else if (i.Equals("staff"))
                {
                    roleCombobox.SelectedIndex = 1;
                }
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            var users = from u in us.USERs
                       where u.UserName.Equals(userName_text.Text)
                       select u;
            foreach( var user in users)
            {
                us.USERs.Remove(user);
            }
            DialogResult d;
            d= MessageBox.Show("Are you sure ?", "DELETE MESSAGE", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                us.SaveChanges();
            }
            userName_text.Text = "";
            passWordText.Text = "";
            roleCombobox.SelectedIndex = 0;
            this.Admin_Formcs_Load(sender, e);
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            var uN = userName_text.Text;
            var user = us.USERs.Single(u => u.UserName.Equals(uN));
            user.UserName = userName_text.Text.Trim();
            user.Password = passWordText.Text.Trim();
            user.IDRole = Int32.Parse(roleCombobox.GetItemText(roleCombobox.SelectedValue));
            DialogResult d = MessageBox.Show("Are you sure ?", "UPDATE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                us.SaveChanges();
            }
            this.Admin_Formcs_Load(sender, e);
        }
        private void exitUpdateUser_Click(object sender, EventArgs e)
        {
            updateUser.Enabled = false;
            updateUser.Visible = false;
            exitUpdateUser.Visible = false;
            userName_text.Enabled = true;
            deleteUser.Visible = true;
            addUser.Visible = true;
        }

        private void insertUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_User nU = new New_User();
            nU.ShowDialog();
        }

        private void inserCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAddCustomer AC = new formAddCustomer();
            AC.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_User udU = new Update_User();
            udU.checkUsername = this.checkUsername;
            udU.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            isClose = true;
        }
    }
}
