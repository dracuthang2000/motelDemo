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
        public Update_User()
        {
            InitializeComponent();
        }
        LoginMotelUser.Model.motel_manager_demoEntities1 us = new Model.motel_manager_demoEntities1();
        public String checkUsername { get; set; }
        private void Update_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motel_manager_demoDataSet1.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.motel_manager_demoDataSet1.ROLE);
            var a = us.USERs.Join(us.ROLEs, u => u.idRole, r => r.id, (u, r) => new { u, r }).Where(ur => ur.r.id == ur.u.idRole)
    .Select(ur => new { ur.u.userName, ur.u.password, ur.r.Name }).ToList();
            this.uSERBindingSource.DataSource = a;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var userName = (from u in us.USERs
                            where u.userName.Equals(textUsername.Text)
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
                    var user = us.USERs.Single(u => u.userName.Equals(uN));
                    user.userName = textUsername.Text.Trim();
                    user.password = textPassword.Text.Trim();
                    user.idRole = Int32.Parse(comboBoxRole.GetItemText(comboBoxRole.SelectedValue));
                    us.SaveChanges();
                    textPassword.Text = "";
                    textUsername.Text = "";
                    comboBoxRole.SelectedIndex = 0;
                    this.Update_User_Load(sender, e);
                }
            }
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var a = us.USERs.Join(us.ROLEs, u => u.idRole, r => r.id, (u, r) => new { u, r })
         .Where(ur => ur.r.id == ur.u.idRole && ur.u.userName.Contains(textBox1.Text) || ur.r.Name.Contains(textBox1.Text))
         .Select(ur => new { ur.u.userName, ur.u.password, ur.r.Name }).ToList();
            this.uSERBindingSource.DataSource = a;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var users = (from u in us.USERs
                         where u.userName.Equals(textUsername.Text)
                         select u).ToList();
            if (users.Count == 0)
            {
                MessageBox.Show("This account does not exist!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var user in users)
                {
                    if (user.userName.Equals(checkUsername.ToLower()))
                    {
                        MessageBox.Show("This user name is active!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
