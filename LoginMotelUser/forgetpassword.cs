using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        LoginMotelUser.Model.MotelManagerEntities4 stf = new Model.MotelManagerEntities4();
        private void createpassword_Load(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uN = (from s in stf.STAFFs
                      where s.UserName.Equals(textUsername.Text)
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
                    String date = st.DateOfBirth.Value.ToString("MM/dd/yyyy");
                    Regex reg = new Regex(@"[0-9]{9}");
                    Match result = reg.Match(text_idCard.Text);
                    if (result.Length == 0||text_idCard.Text.Length>9)
                    {
                        MessageBox.Show("IDcard is incorrect", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!(st.IDCard.Trim().Equals(text_idCard.Text)) || !(dateTimePicker.Value.Date == st.DateOfBirth.Value.Date))
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
                Model.MotelManagerEntities4 us = new Model.MotelManagerEntities4();
                var user = us.USERs.Single(u => u.UserName.Equals(textUsername.Text));
                user.Password = textPassword.Text.Trim();
                us.SaveChanges();
                this.Close();
            }
        }
    }
}
