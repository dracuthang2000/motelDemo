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
        LoginMotelUser.Model.motel_manager_demoEntities1 stf = new Model.motel_manager_demoEntities1();
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
                    if (!(st.idStaff.Equals(text_idCard)))
                    {

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
    }
}
