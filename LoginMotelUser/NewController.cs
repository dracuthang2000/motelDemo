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
    public partial class NewController : Form
    {
        Boolean checkRole;
        Boolean checkControll;
        public NewController(Boolean checkRole, Boolean checkControll)
        {
            InitializeComponent();
            if(checkRole == true)
            {
                User.Visible = true;
                ROOM.Visible = true;
                Range.Visible = true;
                Staff.Visible = true;
                Rank.Visible = true;
            }
            else
            {
                User.Visible = false;
                ROOM.Visible = false;
                Range.Visible = false;
                Staff.Visible = false;
                Rank.Visible = false;
            }
            this.checkControll = checkControll;
        }
        private void button_WOC8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (checkControll == true)
            {
                New_User Nuser = new New_User();
                Nuser.ShowDialog();
            }
            else
            {
                Update_User UpUser = new Update_User();
                UpUser.ShowDialog();
            }
            this.Close();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ShowCustomerForm gf = new ShowCustomerForm(checkControll);
            gf.ShowDialog();
            this.Close();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRoomForm sFR = new showRoomForm(checkControll);
            sFR.ShowDialog();
            this.Close();
        }

        private void buttonReinfor_Click(object sender, EventArgs e)
        {

        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRangeForm rF = new showRangeForm(checkControll);
            rF.ShowDialog();
            this.Close();
        }

        private void buttonRank_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRankForm rF = new showRankForm(checkControll);
            rF.ShowDialog();
            this.Close();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            serviceForm sF = new serviceForm(checkControll);
            sF.ShowDialog();
            this.Close();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showStaffForm staff = new showStaffForm(checkControll);
            staff.ShowDialog();
            this.Close();
        }
    }
}
