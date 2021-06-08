using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMotelUser
{
    public partial class Viewinformation : Form
    {
        LoginMotelUser.Model.MotelManagerEntities4 db = new Model.MotelManagerEntities4();
        public Viewinformation( Boolean checkRole, String checkUsername)
        {
            InitializeComponent();
            this.loadListReninformation();
            comboBoxSearch.SelectedIndex = 0;
            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
            if (checkRole == false)
            {
                userToolStripMenuItem.Visible = false;
                userToolStripMenuItem1.Visible = false;
                roomToolStripMenuItem.Visible = false;
                roomToolStripMenuItem1.Visible = false;
                rankToolStripMenuItem.Visible = false;
                rankToolStripMenuItem1.Visible = false;
                rangeToolStripMenuItem.Visible = false;
                rangeToolStripMenuItem1.Visible = false;
                staffToolStripMenuItem.Visible = false;
                staffToolStripMenuItem1.Visible = false;
            }
        }
        public bool check;
        public bool checkRole { get; set; }
        public String checkUsername { get; set; }

        //public 
        public void loadListReninformation()
        {
            ListRein.Items.Clear();
            var query = from renin in db.REINTINFORs
                        select renin;
            int stt = 0;
            foreach(var Reinformation in query)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                ListRein.Items.Add(lvi);
                stt++;
            }
        }

        //======================================================================================================================================================================//
        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            New_User nU = new New_User(checkRole, checkUsername);
            nU.ShowDialog();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_User udU = new Update_User(checkRole, checkUsername);
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

        private void ListRein_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = ListRein.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                ListRein.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            ListRein.Sort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxSearch.SelectedIndex == 0)
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where rein.CUSTOMER.IDCard.Contains(textSearch.Text)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }
            else if(comboBoxSearch.SelectedIndex == 1)
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where rein.CUSTOMER.CustomerName.Contains(textSearch.Text)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }else if(comboBoxSearch.SelectedIndex == 2)
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where rein.MOTELROOM.RoomName.Contains(textSearch.Text)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }
        }       

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadListReninformation();
            if (comboBoxSearch.SelectedIndex == 3 || comboBoxSearch.SelectedIndex == 4)
            {
                dateTimemin.Visible = true;
                dateTimeMax.Visible = true;
                dateTimemin.Value = DateTime.Now;
                dateTimeMax.Value = DateTime.Now;
                labelTo.Visible = true;
                textSearch.Visible = false;
                
            }else
            {
                dateTimemin.Visible = false;
                dateTimeMax.Visible = false;
                labelTo.Visible = false;
                textSearch.Visible = true;
            }
        }

        private void dateTimeMax_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimeMax.Value.Date < dateTimemin.Value.Date)
            {
                MessageBox.Show("Date time " + dateTimeMax.Value.Date + " > " + dateTimemin.Value.Date);
                return;
            }
            if (comboBoxSearch.SelectedIndex == 3)
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where EntityFunctions.TruncateTime(rein.CheckOutDate) >= (dateTimemin.Value.Date)
                                 && EntityFunctions.TruncateTime(rein.CheckOutDate) <= (dateTimeMax.Value.Date)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }
            else
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where EntityFunctions.TruncateTime(rein.CheckInDate) >= (dateTimemin.Value.Date) 
                                 && EntityFunctions.TruncateTime(rein.CheckInDate) <= (dateTimeMax.Value.Date)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }
        }

        private void dateTimemin_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeMax.Value.Date < dateTimemin.Value.Date)
            {
                MessageBox.Show("Date time " + dateTimeMax.Value.Date + " > " + dateTimemin.Value.Date);
                return;
            }
            if (comboBoxSearch.SelectedIndex == 3)
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where EntityFunctions.TruncateTime(rein.CheckOutDate) >= (dateTimemin.Value.Date)
                                 && EntityFunctions.TruncateTime(rein.CheckOutDate) <= (dateTimeMax.Value.Date)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }
            else
            {
                ListRein.Items.Clear();
                var indentity = (from rein in db.REINTINFORs
                                 where EntityFunctions.TruncateTime(rein.CheckInDate) >= (dateTimemin.Value.Date)
                                 && EntityFunctions.TruncateTime(rein.CheckInDate) <= (dateTimeMax.Value.Date)
                                 select rein).ToList();
                int stt = 0;
                foreach (var Reinformation in indentity)
                {
                    ListViewItem lvi = new ListViewItem(stt.ToString());
                    lvi.SubItems.Add(Reinformation.CUSTOMER.IDCard);
                    lvi.SubItems.Add(Reinformation.CUSTOMER.CustomerName);
                    lvi.SubItems.Add(Reinformation.MOTELROOM.RoomName);
                    lvi.SubItems.Add(Reinformation.CheckInDate.ToString());
                    lvi.SubItems.Add(Reinformation.CheckOutDate.ToString());
                    ListRein.Items.Add(lvi);
                    stt++;
                }
            }
        }
    }
}
