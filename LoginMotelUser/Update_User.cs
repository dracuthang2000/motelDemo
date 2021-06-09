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
    public partial class Update_User : Form
    {
        private Boolean checkRole;
        public Update_User(Boolean checkRole,String checkUsername)
        {
            InitializeComponent();
            setColor();
            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
        }
        private bool checkClick = false;
        LoginMotelUser.Model.MotelManagerEntities4 us = new Model.MotelManagerEntities4();
        public String checkUsername { get; set; }
        private void Update_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motelManagerDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter1.Fill(this.motelManagerDataSet.ROLE);
            // TODO: This line of code loads data into the 'motelManagerDataSet.USER' table. You can move, or remove it, as needed.
            var users = (from u in us.USERs
                         select new { u.UserName, u.Password, u.ROLE.RoleName }).ToList();
            this.uSERBindingSource1.DataSource = users;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataUser.CurrentRow.Selected = true;
                textUsername.Text = dataUser.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textPassword.Text = dataUser.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                String i = dataUser.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                if (i.Equals("admin"))
                {
                    comboBoxRole.SelectedIndex = 0;
                }
                else if (i.Equals("staff"))
                {
                    comboBoxRole.SelectedIndex = 1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var users = (from u in us.USERs
                         where u.UserName.Contains(textBox1.Text)
                         select new { u.UserName, u.Password, u.ROLE.RoleName }).ToList();
            this.uSERBindingSource1.DataSource = users;
        }

        private void dataUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataUser.ContextMenuStrip = contextMenuStrip;
            }
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var users = (from u in us.USERs
                         where u.UserName.Equals(textUsername.Text)
                         select u).ToList();
            if (users.Count == 0)
            {
                MessageBox.Show("This account does not exist!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var user in users)
                {
                    if (user.UserName.Equals(checkUsername.ToLower()))
                    {
                        MessageBox.Show("This user name is running!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textPassword.Text = "";
                        textUsername.Text = "";
                        comboBoxRole.SelectedIndex = 0;
                    }
                    else
                    {
                        DialogResult d;
                        d = MessageBox.Show("Are you sure ?", "DELETE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            us.USERs.Remove(user);
                            us.SaveChanges();
                            textPassword.Text = "";
                            textUsername.Text = "";
                            comboBoxRole.SelectedIndex = 0;
                            this.Update_User_Load(sender, e);
                        }
                    }
                }

            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            var userName = (from u in us.USERs
                            where u.UserName.Equals(textUsername.Text)
                            select u).ToList();

            if (userName.Count == 0)
            {
                MessageBox.Show("This account does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult d = MessageBox.Show("Are you sure ?", "UPDATE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    var uN = textUsername.Text;
                    var user = us.USERs.Single(u => u.UserName.Equals(uN));
                    user.UserName = textUsername.Text.Replace(" ", string.Empty);
                    user.Password = textPassword.Text.Replace(" ", string.Empty);
                    user.IDRole = Int32.Parse(comboBoxRole.GetItemText(comboBoxRole.SelectedValue));
                    us.SaveChanges();
                    textPassword.Text = "";
                    textUsername.Text = "";
                    comboBoxRole.SelectedIndex = 0;
                    this.Update_User_Load(sender, e);
                }
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            var users = (from u in us.USERs
                         where u.UserName.Equals(textUsername.Text)
                         select u).ToList();
            if (users.Count == 0)
            {
                MessageBox.Show("This account does not exist!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var checkUser = (from user in us.USERs
                                  join staff in us.STAFFs on user.UserName equals staff.UserName
                                  where user.UserName.Equals(textUsername.Text)
                                  select user).ToList();
                if (checkUser.Count > 0)
                {
                    MessageBox.Show("The User is use on another place, you can't delete it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (var user in users)
                {
                    if (user.UserName.Equals(checkUsername.ToLower()))
                    {
                        MessageBox.Show("This user name is running!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textPassword.Text = "";
                        textUsername.Text = "";
                        comboBoxRole.SelectedIndex = 0;
                    }
                    else
                    {
                        DialogResult d;
                        d = MessageBox.Show("Are you sure ?", "DELETE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            us.USERs.Remove(user);
                            us.SaveChanges();
                            textPassword.Text = "";
                            textUsername.Text = "";
                            comboBoxRole.SelectedIndex = 0;
                            this.Update_User_Load(sender, e);
                        }
                    }
                }
            }
        }

        private void buttonCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.buttonCan.BackColor = System.Drawing.Color.Transparent;
        }


        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            New_User nU = new New_User(checkRole, checkUsername);
            nU.ShowDialog();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_User udU = new Update_User(checkRole,checkUsername);
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

        private void viewReninformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewinformation Fc = new Viewinformation(checkRole, checkUsername);
            Fc.ShowDialog();
        }
    }
}
