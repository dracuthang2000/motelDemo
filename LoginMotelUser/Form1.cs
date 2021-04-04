using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LoginMotelUser
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox =false;
        }

        LoginMotelUser.Model.motel_manager_demoEntities1 us = new Model.motel_manager_demoEntities1();
        public bool isLoggedIn { get; set; }
        public bool checkRole { get; set; }
        public String checkUsername { get; set; }

        public static Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passWord.PasswordChar == '\0')
            {
                passWord.PasswordChar = '*';
                button2.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passWord.PasswordChar == '*')
            {
                passWord.PasswordChar = '\0';
                button1.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var users = (from u in us.USERs
                        where u.userName==userName.Text
                        select u).ToList();
;
            foreach(var u in users)
            {
                if (userName.Text.Equals("") || passWord.Text.Equals("") || !(u.password.Equals(passWord.Text)))
                {
                    MessageBox.Show("Pass word or User Name is incorrect");
                }
                else
                {
                    checkUsername = userName.Text;
                    if (u.ROLE.Name.Equals("admin"))
                    {
                        checkRole = true;
                    } else
                    {
                        checkRole = false;
                    }
                    isLoggedIn = true;
                    this.Close();
                }
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword fg = new forgetpassword();
            fg.ShowDialog();
        }
        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

    }
}
