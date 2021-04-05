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
    public partial class forgetpassword : Form
    {
        Form opener;
        public forgetpassword()
        {
            InitializeComponent();
            opener = ParentForm;
        }
        LoginMotelUser.Model.motel_manager_demoEntities stf = new Model.motel_manager_demoEntities();
        private void createpassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uN = (from s in stf.STAFFs
                      where s.userName.Equals(textUsername.Text)
                      select s).ToList();
            if (uN.Count == 0)
            {
                checkUsername.Visible = true;
            }
            else
            {
                checkUsername.Visible = false;
                foreach(var st in uN)
                {
                    //String date = st.dateOfBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    String date = st.dateOfBirth.Value.ToString("dd/MM/yyyy");
                 
                    if (!(st.idStaff.Trim().Equals(text_idCard.Text))||!(st.dateOfBirth.Value.ToString("dd/MM/yyyy").Equals(textdate.Text)))
                    {
                        checkIdanddate.Visible = true;
                    }
                    else
                    {
                        checkIdanddate.Visible = false;
                        panelPassword.Visible = true;
                        panel1.Visible = false;
                    }
                }
            }
           // panelPassword.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (textVerifyPassword.PasswordChar == '*')
            {
                textVerifyPassword.PasswordChar = '\0';
                eyesVerifypass.Visible= true;
                panel3.Visible = false;
            }
        }

        private void eyesVerifypass_Click(object sender, EventArgs e)
        {
            if (textVerifyPassword.PasswordChar == '\0')
            {
                textVerifyPassword.PasswordChar = '*';
                panel3.Visible = true;
                eyesVerifypass.Visible = false;
            }
        }

        private void eyeNewpassword_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '\0')
            {
                textPassword.PasswordChar = '*';
                noteyesnewpass.Visible = true;
                eyeNewpassword.Visible = false;
            }
        }

        private void noteyesnewpass_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                textPassword.PasswordChar = '\0';
                noteyesnewpass.Visible = false;
                eyeNewpassword.Visible = true;
            }
        }

        private void textVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            if (!(textPassword.Text.Equals(textVerifyPassword.Text)))
            {
                incorrectPass.Visible = true;
                correctPass.Visible = false;
                buttonOk.Enabled = false;
            }
            else
            {
                if (!textVerifyPassword.Text.Equals(""))
                {
                    correctPass.Visible = true;
                    incorrectPass.Visible = false;
                    buttonOk.Enabled = true;
                }
                else
                {
                    correctPass.Visible = false;
                    incorrectPass.Visible = false;
                }
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (!textVerifyPassword.Text.Equals(""))
            {
                if (!(textPassword.Text.Equals(textVerifyPassword.Text)))
                {
                    incorrectPass.Visible = true;
                    correctPass.Visible = false;
                    buttonOk.Enabled = false;
                }
                else
                {
                    correctPass.Visible = true;
                    incorrectPass.Visible = false;
                    buttonOk.Enabled = true;
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure ?", "UPDATE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Model.motel_manager_demoEntities us = new Model.motel_manager_demoEntities();
                var user = us.USERs.Single(u => u.userName.Equals(textUsername.Text));
                user.password = textPassword.Text.Trim();
                us.SaveChanges();
                this.Close();
            }
        }
    }
}
