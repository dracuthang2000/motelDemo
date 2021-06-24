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
    public partial class showRoomForm : Form
    {
        int soLuong = 15;
        int dem;
        int tong;
        int tinh;
        private Boolean check;
        private Boolean checkRole;
        private String checkUsername;
        public showRoomForm(Boolean check,Boolean checkRole, String checkUsername)
        {
            InitializeComponent();
            this.check = check;
            setColor();
            loadRoom(0, soLuong);
            dem = 0;
            if (this.check == true)
                buttonUp.Text = "ADD";
            else
                buttonUp.Text = "UPDATE";

            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
        }

        private void AutoSizeColumnList(ListView listView)
        {
            //Prevents flickering
            listView.BeginUpdate();

            Dictionary<int, int> columnSize = new Dictionary<int, int>();

            //Auto size using header
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Grab column size based on header
            foreach (ColumnHeader colHeader in listView.Columns)
                columnSize.Add(colHeader.Index, colHeader.Width);

            //Auto size using data
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            //Grab comumn size based on data and set max width
            foreach (ColumnHeader colHeader in listView.Columns)
            {
                int nColWidth;
                if (columnSize.TryGetValue(colHeader.Index, out nColWidth))
                    colHeader.Width = Math.Max(nColWidth, colHeader.Width);
                else
                    //Default to 50
                    colHeader.Width = Math.Max(50, colHeader.Width);
            }

            listView.EndUpdate();
        }
        public void loadRoom(int e, int f)
        {
            using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
            {
                listRoom.Columns.Add("ID Room", 100);
                listRoom.Columns.Add("Room name", 150);
                listRoom.Columns.Add("State", 120);
                listRoom.Columns.Add("Rank", 140);
                listRoom.Columns.Add("Range Name", 200);
                var list = (from d in data.USP_PageRoom(e, f) select d).ToList();

                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RoomName);
                    if (c.StateRoom.Value == 1)
                    {
                        item.SubItems.Add("phòng trống");
                    }
                    else if (c.StateRoom.Value == 2)
                    {
                        item.SubItems.Add("còn chỗ");
                    }
                    else if (c.StateRoom == 3)
                    {
                        item.SubItems.Add("hết chỗ");
                    }
                    else
                    {
                        item.SubItems.Add("Bảo trì");
                    }
                    Model.ROOMRANK a = data.ROOMRANKs.Find(c.IDRoomRank);
                    item.SubItems.Add(a.RankName.ToString());
                    Model.ROOMRANGE b = data.ROOMRANGEs.Find(c.IDRoomRange);
                    item.SubItems.Add(b.RangeName.ToString());
                    listRoom.Items.Add(item);
                }
                var temp2 = (from c in data.USP_CountRoom() select c).ToList();
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
            listRoom.Clear();
            loadRoom(0, soLuong);
            dem = 0;
        }
        private void butThem_Click(object sender, EventArgs e)
        {
        }

        private void listRoom_DoubleClick(object sender, EventArgs e)
        {
            String temp = listRoom.FocusedItem.Text;
            AddRoomcs rOF = new AddRoomcs(temp,this.check);
            rOF.goiHam = loadList;
            rOF.ShowDialog();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRoom.Clear();

            using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
            {
                String temp = textSearch.Text;
                List<Model.MOTELROOM> list = (from a in data.MOTELROOMs where a.RoomName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                listRoom.Columns.Add("ID Room", 100);
                listRoom.Columns.Add("Room name", 150);
                listRoom.Columns.Add("State", 120);
                listRoom.Columns.Add("Rank", 140);
                listRoom.Columns.Add("Room state ", 200);

                foreach (Model.MOTELROOM c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RoomName);
                    if (c.StateRoom.Value == 1)
                    {
                        item.SubItems.Add("phòng trống");
                    }
                    else if (c.StateRoom.Value == 2)
                    {
                        item.SubItems.Add("còn chỗ");
                    }
                    else if (c.StateRoom == 3)
                    {
                        item.SubItems.Add("hết chỗ");
                    }
                    else
                    {
                        item.SubItems.Add("Bảo trì");
                    }
                    Model.ROOMRANK a = data.ROOMRANKs.Find(c.IDRoomRank);
                    item.SubItems.Add(a.RankName.ToString());
                    Model.ROOMRANGE b = data.ROOMRANGEs.Find(c.IDRoomRange);
                    item.SubItems.Add(b.RangeName.ToString());
                    listRoom.Items.Add(item);
                }
                labPage.Text = "Trang 1/1";
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
                listRoom.Clear();
                loadRoom(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listRoom.Clear();
                loadRoom(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
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
                listRoom.Clear();
                loadRoom(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listRoom.Clear();
                loadRoom(dem * soLuong, soLuong);
            }
            labPage.Text = "Page " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                listRoom.Clear();

                using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
                {
                    String temp = textSearch.Text;
                    List<Model.MOTELROOM> list = (from a in data.MOTELROOMs where a.RoomName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                    listRoom.Columns.Add("ID Room", 100);
                    listRoom.Columns.Add("Room name", 150);
                    listRoom.Columns.Add("State", 120);
                    listRoom.Columns.Add("Rank", 140);
                    listRoom.Columns.Add("Range name", 200);

                    foreach (Model.MOTELROOM c in list)
                    {
                        ListViewItem item = new ListViewItem(c.ID.ToString());
                        item.SubItems.Add(c.RoomName);
                        if (c.StateRoom.Value == 1)
                        {
                            item.SubItems.Add("phòng trống");
                        }
                        else if(c.StateRoom.Value == 2)
                        {
                            item.SubItems.Add("còn chỗ");
                        }
                        else if(c.StateRoom == 3)
                        {
                            item.SubItems.Add("hết chỗ");
                        }
                        else
                        {
                            item.SubItems.Add("Bảo trì");
                        }
                        Model.ROOMRANK a = data.ROOMRANKs.Find(c.IDRoomRank);
                        item.SubItems.Add(a.RankName.ToString());
                        Model.ROOMRANGE b = data.ROOMRANGEs.Find(c.IDRoomRange);
                        item.SubItems.Add(b.RangeName.ToString());
                        listRoom.Items.Add(item);
                    }
                    labPage.Text = "Page 1/1";
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.check == true)
            {
                AddRoomcs rOF = new AddRoomcs(true);
                rOF.goiHam = loadList;
                rOF.ShowDialog();
            }
            else
            {
                if (listRoom.SelectedItems.Count > 0)
                {
                    String temp = listRoom.FocusedItem.Text;
                    AddRoomcs rOF = new AddRoomcs(temp, false);
                    rOF.goiHam = loadList;
                    rOF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Let's choices Room on list!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listRoom.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
                {
                    var checkRoom = (from room in data.MOTELROOMs
                                     join rent in data.REINTINFORs on room.ID equals rent.IDRoom
                                     where room.ID.ToString().Equals(listRoom.FocusedItem.Text)
                                     select room).ToList();
                    if (checkRoom.Count > 0)
                    {
                        MessageBox.Show("The room is use on another place, you can't delete it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Are you sure delete room ID = " + listRoom.FocusedItem.Text + " ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                Model.MOTELROOM temp = data.MOTELROOMs.Find(int.Parse(listRoom.FocusedItem.Text));
                                data.MOTELROOMs.Remove(temp);
                                data.SaveChanges();
                                listRoom.Clear();
                                loadRoom(0, soLuong);
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
                MessageBox.Show("Let's Choices Room on list!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void setColor()
        {
            this.labPage.BackColor = System.Drawing.Color.Transparent;
            this.labSearch.BackColor = System.Drawing.Color.Transparent;
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.buttonUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancle.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showRoomForm_MaximumSizeChanged(object sender, EventArgs e)
        {
            AutoSizeColumnList(listRoom);
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

        private void viewReninformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Visible = false;
                Viewinformation Fc = new Viewinformation(checkRole, checkUsername);
                Fc.ShowDialog();
        }

        private void listRoom_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = listRoom.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listRoom.ListViewItemSorter = sorter;
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
            listRoom.Sort();
        }
    }
}
