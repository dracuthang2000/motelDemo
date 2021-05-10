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
        private Boolean checkRole;
        private String checkUsername;
        public New_User(Boolean checkRole,String checkUsername)
        {
            InitializeComponent();
            setColor();
            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
        }
        private bool checkClick = false;
        LoginMotelUser.Model.MotelManagerEntities4 us = new Model.MotelManagerEntities4();
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
                    MessageBox.Show("COMPLETE!");
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

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            New_User nU = new New_User(checkRole,checkUsername);
            nU.ShowDialog();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_User udU = new Update_User(checkRole);
            udU.checkUsername = this.checkUsername;
            udU.ShowDialog();
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            ShowCustomerForm gf = new ShowCustomerForm(true, checkRole, checkUsername);
            gf.ShowDialog();
        }

        private void customerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            ShowCustomerForm uC = new ShowCustomerForm(false, checkRole, checkUsername);
            uC.ShowDialog();
        }

        private void viewOldBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormViewOldBill ViewBill = new FormViewOldBill(checkRole, checkUsername);
            ViewBill.ShowDialog();
        }

        private void checOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formAddCustomer AC = new formAddCustomer(false, checkUsername, checkRole);
            AC.ShowDialog();
        }

        private void checkInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            formAddCustomer AC = new formAddCustomer(true, checkUsername, checkRole);
            AC.ShowDialog();
        }

        private void staffToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showStaffForm staff = new showStaffForm(false, checkRole, checkUsername);
            staff.ShowDialog();
        }

        private void staffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showStaffForm staff = new showStaffForm(true, checkRole, checkUsername);
            staff.ShowDialog();
        }

        private void serviceToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            serviceForm sF = new serviceForm(false, checkRole, checkUsername);
            sF.ShowDialog();
        }

        private void serviceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            serviceForm sF = new serviceForm(true, checkRole, checkUsername);
            sF.ShowDialog();
        }

        private void rangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRangeForm rF = new showRangeForm(false, checkRole, checkUsername);
            rF.ShowDialog();
        }

        private void rangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showRangeForm rF = new showRangeForm(true, checkRole, checkUsername);
            rF.ShowDialog();
        }

        private void rankToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showRankForm rF = new showRankForm(false, checkRole, checkUsername);
            rF.ShowDialog();
        }

        private void rankToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showRankForm rF = new showRankForm(true, checkRole, checkUsername);
            rF.ShowDialog();
        }

        private void roomToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showRoomForm sFR = new showRoomForm(false, checkRole, checkUsername);
            sFR.ShowDialog();
        }

        private void roomToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            showRoomForm sFR = new showRoomForm(true, checkRole, checkUsername);
            sFR.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormPrices FP = new FormPrices(checkUsername, checkRole);
            FP.ShowDialog();
        }

        private void recieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCollection Fc = new FormCollection(checkRole, checkUsername);
            Fc.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
