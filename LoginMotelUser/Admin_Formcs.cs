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
        LoginMotelUser.Model.motel_manager_demoEntities1 us = new Model.motel_manager_demoEntities1();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            isClose = true;
        }

        private void Admin_Formcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motel_manager_demoDataSet1.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.motel_manager_demoDataSet1.ROLE);
            var a = us.USERs.Join(us.ROLEs, u => u.idRole, r => r.id, (u, r) => new { u, r }).Where(ur => ur.r.id == ur.u.idRole)
                .Select(ur => new { ur.u.userName,ur.u.password,ur.r.Name}).ToList();
            this.motelmanagerdemoDataSet1BindingSource.DataSource = a;
            if (this.checkRole == false)
            {
                newUserToolStripMenuItem.Enabled = false;
                updateUserToolStripMenuItem.Enabled = false;
            }
            else
            {
                newUserToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var a = us.USERs.Join(us.ROLEs, u => u.idRole, r => r.id, (u, r) => new { u, r })
                .Where(ur => ur.r.id == ur.u.idRole && ur.u.userName.Contains(Search_admin.Text)|| ur.r.Name.Contains(Search_admin.Text))
             .Select(ur => new { ur.u.userName, ur.u.password, ur.r.Name }).ToList();
            this.motelmanagerdemoDataSet1BindingSource.DataSource = a;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            String uN = passWordText.Text;
            uN.Trim();

            us.USERs.Add(new Model.USER
            {
                userName = userName_text.Text.Trim(),
                password = passWordText.Text.Trim(),
                idRole = Int32.Parse(roleCombobox.GetItemText(roleCombobox.SelectedValue).Trim())
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
                       where u.userName.Equals(userName_text.Text)
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
            var user = us.USERs.Single(u => u.userName.Equals(uN));
            user.userName = userName_text.Text.Trim();
            user.password = passWordText.Text.Trim();
            user.idRole = Int32.Parse(roleCombobox.GetItemText(roleCombobox.SelectedValue));
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

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_User nU = new New_User();
            nU.ShowDialog();
            this.Admin_Formcs_Load(sender, e);
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_User udU = new Update_User();
            udU.checkUsername = this.checkUsername;
            udU.ShowDialog();
            this.Admin_Formcs_Load(sender,e);
        }
    }
}
