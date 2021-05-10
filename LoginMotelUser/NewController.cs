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
        private String checkUsername;
        public NewController(Boolean checkRole, Boolean checkControll,String checkUsername,Byte checkControl)
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
            if(checkControl == 1)
            {
                ControllerBill.Visible = false;
                ControllRent.Visible = false;
            }else if(checkControl == 2)
            {
                ControllerEN.Visible = false;
                ControllRent.Visible = false;
            }
            else
            {
                ControllerBill.Visible = false;
                ControllerEN.Visible = false;
            }
            this.checkControll = checkControll;
            this.checkUsername = checkUsername;
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
                New_User Nuser = new New_User(checkRole,checkUsername);
                Nuser.ShowDialog();
            }
            else
            {
                Update_User UpUser = new Update_User(checkRole);
                UpUser.ShowDialog();
            }
            this.Close();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ShowCustomerForm gf = new ShowCustomerForm(checkControll,checkRole,checkUsername);
            gf.ShowDialog();
            this.Close();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRoomForm sFR = new showRoomForm(checkControll,checkRole,checkUsername);
            sFR.ShowDialog();
            this.Close();
        }

        private void buttonReinfor_Click(object sender, EventArgs e)
        {

        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRangeForm rF = new showRangeForm(checkControll,checkRole,checkUsername);
            rF.ShowDialog();
            this.Close();
        }

        private void buttonRank_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showRankForm rF = new showRankForm(checkControll,checkRole,checkUsername);
            rF.ShowDialog();
            this.Close();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            serviceForm sF = new serviceForm(checkControll,checkRole,checkUsername);
            sF.ShowDialog();
            this.Close();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            showStaffForm staff = new showStaffForm(checkControll,checkRole,checkUsername);
            staff.ShowDialog();
            this.Close();
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            FormPrices FP = new FormPrices(checkUsername, checkRole);
            FP.ShowDialog();
            this.Close();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCollection Fc = new FormCollection(checkRole, checkUsername);
            Fc.ShowDialog();
            this.Close();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormViewOldBill ViewBill = new FormViewOldBill(checkRole, checkUsername);
            ViewBill.ShowDialog();
            this.Close();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formAddCustomer AC = new formAddCustomer(true, checkUsername, checkRole);
            AC.ShowDialog();
            this.Close();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formAddCustomer AC = new formAddCustomer(false, checkUsername, checkRole);
            AC.ShowDialog();
            this.Close();
        }
    }
}
