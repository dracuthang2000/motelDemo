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
