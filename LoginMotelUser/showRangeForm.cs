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
    public partial class showRangeForm : Form
    {
        int soLuong = 15;
        int dem;
        int tong;
        int tinh;
        private Boolean check;
        private Boolean checkRole;
        private String checkUsername;
        Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4();
        public showRangeForm(Boolean check, Boolean checkRole, String checkUsername)
        {
            InitializeComponent();
            setColor();
            loadData(0, soLuong);
            dem = 0;
            if(check == true)
            {
                buttonUp.Enabled = false;
                textSearch.Visible = false;
                labSearch.Visible = false;
                OldName.Visible = false;
                NewName.Visible = false;
                textNewName.Visible = false;
                labRangeName.Visible = true;
                buttonUp.Text = "ADD";
            }
            else
            {
                OldName.Visible = true;
                NewName.Visible = true;
                labRangeName.Visible = false;
                buttonUp.Text = "UPDATE";
            }
            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
            this.check = check;
        }
        public void loadData(int b, int e)
        {
            var list = (from d in data.USP_PageRange(b, e) select d).ToList();
            listRange.Columns.Add("ID Range", 100);
            listRange.Columns.Add("Range name", 140);
            foreach (var a in list)
            {
                ListViewItem item = new ListViewItem(a.ID.ToString());
                item.SubItems.Add(a.RangeName);
                listRange.Items.Add(item);
            }
            var temp2 = (from c in data.USP_CountRange() select c).ToList();
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

        private void listRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            textIDRange.Text = listRange.FocusedItem.Text;
            int a = int.Parse(textIDRange.Text);
            Model.ROOMRANGE b = data.ROOMRANGEs.Find(a);
            textRangeName.Text = b.RangeName;
        }
        public void saveData()
        {
            Model.ROOMRANGE temp = new Model.ROOMRANGE() { RangeName = textRangeName.Text };
            data.ROOMRANGEs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            Model.ROOMRANGE a = data.ROOMRANGEs.Find(int.Parse(textIDRange.Text));
            a.RangeName = textNewName.Text;
            data.SaveChanges();
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRange.Clear();
            labPage.Text = "Page 1/1";
            using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
            {
                String temp = textSearch.Text;
                List<Model.ROOMRANGE> list = (from a in data.ROOMRANGEs where a.RangeName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                listRange.Columns.Add("ID Range", 100);
                listRange.Columns.Add("Range name", 140);
                foreach (Model.ROOMRANGE a in list)
                {
                    ListViewItem item = new ListViewItem(a.ID.ToString());
                    item.SubItems.Add(a.RangeName);
                    listRange.Items.Add(item);
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
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listRange.Clear();
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
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Page " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                listRange.Clear();
                labPage.Text = "Page 1/1";
                using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
                {
                    String temp = textSearch.Text;
                    List<Model.ROOMRANGE> list = (from a in data.ROOMRANGEs where a.RangeName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                    listRange.Columns.Add("ID Range", 100);
                    listRange.Columns.Add("Range name", 140);
                    foreach (Model.ROOMRANGE a in list)
                    {
                        ListViewItem item = new ListViewItem(a.ID.ToString());
                        item.SubItems.Add(a.RangeName);
                        listRange.Items.Add(item);
                    }

                }
            }
        }
        private void textRangeName_TextChanged(object sender, EventArgs e)
        {
            var query = (from range in data.ROOMRANGEs
                         where range.RangeName.Equals(textRangeName.Text)
                         select range).ToList();
            if (check == true)
            {
                textSearch.Text = textRangeName.Text;
                if (query.Count == 0 && !textRangeName.Text.Trim().Equals(""))
                {
                    buttonUp.Enabled = true;
                    textIDRange.Text = "";
                }
                else
                {
                    buttonUp.Enabled = false;
                    if(textRangeName.Text.Trim().Equals(""))
                        textIDRange.Text = "";
                    foreach (var range in query)
                        textIDRange.Text = range.ID.ToString();
                }
            }
            else
            {
                if (textRangeName.Text.Trim().Equals(""))
                    textIDRange.Text = "";
                foreach (var range in query)
                    textIDRange.Text = range.ID.ToString();
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (textRangeName.Text == "")
                {
                    MessageBox.Show("Let'type Old Range Name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (textIDRange.Text.Equals(""))
                {
                    MessageBox.Show("ID is not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textNewName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Let'type New Range Name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var query = (from range in data.ROOMRANGEs
                                 where range.RangeName.Equals(textNewName.Text)
                                 select range).ToList();
                    DialogResult result = MessageBox.Show("Are you sure update Range Name " + textRangeName.Text + " ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (query.Count == 0)
                    {
                        switch (result)
                        {
                            case DialogResult.Yes:
                                {
                                    updateData(); listRange.Clear();
                                    loadData(0, soLuong);
                                    dem = 0;
                                    break;
                                }
                            case DialogResult.No: return;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Range Name is exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure insert this Range?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            saveData(); listRange.Clear();
                            loadData(0, soLuong);
                            dem = 0;
                            break;
                        }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textIDRange.Text == "")
            {
                MessageBox.Show("Let's choices ID need to delete!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var checkRange = (from range in data.ROOMRANGEs
                              join room in data.MOTELROOMs on range.ID equals room.IDRoomRange
                              where range.ID.ToString().Equals(textIDRange.Text)
                              select range).ToList();
            if (checkRange.Count > 0)
            {
                MessageBox.Show("The rank is use on another place, you can't delete it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure delete Range ID = " + textIDRange.Text + " ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Model.ROOMRANGE temp = data.ROOMRANGEs.Find(int.Parse(textIDRange.Text));
                        data.ROOMRANGEs.Remove(temp);
                        data.SaveChanges();
                        listRange.Clear();
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textIDRange.Text = "";
            textRangeName.Text = "";
            textNewName.Text = "";
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labSearch.BackColor = System.Drawing.Color.Transparent;
            this.labPage.BackColor = System.Drawing.Color.Transparent;
            this.labRangeName.BackColor = System.Drawing.Color.Transparent;
            this.labID.BackColor = System.Drawing.Color.Transparent;
            this.OldName.BackColor = System.Drawing.Color.Transparent;
            this.NewName.BackColor = System.Drawing.Color.Transparent;
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
