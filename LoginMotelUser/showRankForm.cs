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
    public partial class showRankForm : Form
    {
        int soLuong = 2;
        int dem;
        int tong;
        int tinh;
        private Boolean check;
        private Boolean checkRole;
        private String checkUsername;
        public showRankForm(Boolean check, Boolean checkRole, String checkUsername)
        {
            InitializeComponent();
            if(check == true)
            {
                buttonUpdate.Text = "ADD";
            }
            else
            {
                buttonUpdate.Text = "UPDATE";
            }
            this.check = check;
            loadData(0, soLuong);
            dem = 0;
            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
        }
        public void loadData(int a, int b)
        {
            using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
            {
                listRank.Columns.Add("ID Rank", 100);
                listRank.Columns.Add("Rank name", 150);
                listRank.Columns.Add("Quantity", 100);
                listRank.Columns.Add("Price", 100);
                listRank.Columns.Add("Desposit", 200);
                listRank.Columns.Add("About", 100);

                var list = (from d in data.USP_PageRank(a, b) select d).ToList();


                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RankName);
                    item.SubItems.Add(c.Quantity.ToString());
                    item.SubItems.Add(c.Price.ToString());
                    item.SubItems.Add(c.Deposits.ToString());
                    item.SubItems.Add(c.About);

                    listRank.Items.Add(item);
                }
                var temp2 = (from c in data.USP_CountRank() select c).ToList();
                tong = int.Parse(temp2[0].ToString());
                if (tong % soLuong != 0)
                {
                    tinh = tong / soLuong + 1;
                }
                else
                {
                    tinh = tong / soLuong;
                }

                labPage.Text = "Page 1/" + tinh;
            }
        }
        private void loadList()
        {
            listRank.Clear();
            loadData(0, soLuong);
            dem = 0;
        }

        private void listRank_DoubleClick(object sender, EventArgs e)
        {
            String temp = listRank.FocusedItem.Text;


            rankFormSetting rOF = new rankFormSetting(temp,this.check);
            rOF.goiHam = loadList;
            rOF.ShowDialog();
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRank.Clear();
            labPage.Text = "Page 1/1";
            using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
            {
                String temp = textSearch.Text;
                List<Model.ROOMRANK> list = (from a in data.ROOMRANKs where a.RankName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                listRank.Columns.Add("ID Rank", 100);
                listRank.Columns.Add("Rank name", 150);
                listRank.Columns.Add("Quantity", 100);
                listRank.Columns.Add("Price", 100);
                listRank.Columns.Add("Desposit", 200);
                listRank.Columns.Add("About", 100);


                foreach (Model.ROOMRANK c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RankName);
                    item.SubItems.Add(c.Quantity.ToString());
                    item.SubItems.Add(c.Price.ToString());
                    item.SubItems.Add(c.Deposits.ToString());
                    item.SubItems.Add(c.About);

                    listRank.Items.Add(item);
                }

            }
        }

        private void butRight_Click(object sender, EventArgs e)
        {
            if (tong % soLuong != 0)
            {
                tinh = tong / soLuong + 1;
            }
            else
            {
                tinh = tong / soLuong;
            }

            if (dem + 1 < tinh)
            {
                dem = dem + 1;
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Page " + (dem + 1) + "/" + tinh;
        }

        private void butLeft_Click(object sender, EventArgs e)
        {
            if (tong % soLuong != 0)
            {
                tinh = tong / soLuong + 1;
            }
            else
            {
                tinh = tong / soLuong;
            }

            if (dem - 1 >= 0)
            {
                dem = dem - 1;
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Page " + (dem + 1) + "/" + tinh;
        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {
           if(check == true)
            {
                rankFormSetting rOF = new rankFormSetting(this.check);
                rOF.goiHam = loadList;
                rOF.ShowDialog();
            }
            else
            {
                if (listRank.SelectedItems.Count > 0)
                {
                    String temp = listRank.FocusedItem.Text;

                    rankFormSetting rOF = new rankFormSetting(temp, this.check);
                    rOF.goiHam = loadList;
                    rOF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Let's choice Rank need to update", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            if (listRank.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
                {
                    var checkRank = (from rank in data.ROOMRANKs
                                      join room in data.MOTELROOMs on rank.ID equals room.IDRoomRank
                                      where rank.ID.ToString().Equals(listRank.FocusedItem.Text)
                                      select rank).ToList();
                    if (checkRank.Count > 0)
                    {
                        MessageBox.Show("The rank is use on another place, you can't delete it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Are you sure delete rank ID = " + listRank.FocusedItem.Text + " ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {

                                Model.ROOMRANK temp = data.ROOMRANKs.Find(int.Parse(listRank.FocusedItem.Text));
                                data.ROOMRANKs.Remove(temp);
                                data.SaveChanges();
                                listRank.Clear();
                                loadData(0, soLuong);
                                dem = 0;
                                MessageBox.Show("DELETE IS COMPLETE!");
                                break;
                            }
                        case DialogResult.No: return;

                        default:
                            break;

                    }
                }
            }
            else
            {
                MessageBox.Show("Let's choices Rank need to delete!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void setColor()
        {
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labSearch.BackColor = System.Drawing.Color.Transparent;
            this.labPage.BackColor = System.Drawing.Color.Transparent;
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
    }
}
