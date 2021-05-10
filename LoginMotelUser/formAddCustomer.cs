using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMotelUser
{
    public partial class formAddCustomer : Form
    {
        String checkUsername;
        private Boolean checkRole;
        private Boolean checkControll;
        public formAddCustomer(Boolean check, String userName, Boolean checkRole)
        {
            InitializeComponent();
            if (check == true)
            {
                buttonADD.Visible = true;
                buttonCheckOut.Visible = false;
            }
            else
            {
                buttonADD.Visible = false;
                buttonCheckOut.Visible = true;
            }
            this.checkUsername = userName;
            this.checkRole = checkRole;
            this.checkControll = check;
            setColor();
        }
        Model.MotelManagerEntities4 db = new Model.MotelManagerEntities4();
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities4();
            cbbDaySC3.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC3.DisplayMember = "RangeName";
            cbbDaySC3.SelectedIndex = 0;

            cbbLoaiPhongSC3.DataSource = db.ROOMRANKs.ToList();
            cbbLoaiPhongSC3.DisplayMember = "RankName";
            cbbLoaiPhongSC3.SelectedIndex = 0;

            dtDateSC3.Format = DateTimePickerFormat.Custom;
            dtDateSC3.CustomFormat = "dd-MM-yyyy";

            txtCMNDSC3.Enabled = false;
            txtDiaChiSC3.Enabled = false;
            txtSDTSC3.Enabled = false;
            txtHoTenSC3.Enabled = false;
            dtDateSC3.Enabled = false;
            cbbGioiTinhSC3.Enabled = false;
            lvDanhSachKhachSC3.Items.Clear();

        }
        private void showListRoomTheoDayVaLoaiPhong(string rangeName, string rankName)
        {
            lvDanhSachPhongSC3.Items.Clear();
            if (!rangeName.Equals("") && !rankName.Equals(""))
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    String check;
                    if (nroom.StateRoom.Value == 1)
                    {
                        check = "phòng trống";
                    }
                    else if (nroom.StateRoom.Value == 2)
                    {
                        check = "còn chỗ";
                    }
                    else if (nroom.StateRoom == 3)
                    {
                        check = "hết chỗ";
                    }
                    else
                    {
                        check = "Bảo trì";
                    }
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(check);
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
            else if (!rangeName.Equals(""))
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    String check;
                    if (nroom.StateRoom.Value == 1)
                    {
                        check = "phòng trống";
                    }
                    else if (nroom.StateRoom.Value == 2)
                    {
                        check = "còn chỗ";
                    }
                    else if (nroom.StateRoom == 3)
                    {
                        check = "hết chỗ";
                    }
                    else
                    {
                        check = "Bảo trì";
                    }
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(check);
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
            else if (!rankName.Equals(""))
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    String check;
                    if (nroom.StateRoom.Value == 1)
                    {
                        check = "phòng trống";
                    }
                    else if (nroom.StateRoom.Value == 2)
                    {
                        check = "còn chỗ";
                    }
                    else if (nroom.StateRoom == 3)
                    {
                        check = "hết chỗ";
                    }
                    else
                    {
                        check = "Bảo trì";
                    }
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(check);
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
            else
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    String check;
                    if (nroom.StateRoom.Value == 1)
                    {
                        check = "phòng trống";
                    }
                    else if (nroom.StateRoom.Value == 2)
                    {
                        check = "còn chỗ";
                    }
                    else if (nroom.StateRoom == 3)
                    {
                        check = "hết chỗ";
                    }
                    else
                    {
                        check = "Bảo trì";
                    }
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(check);
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
        }


        private void cbbDaySC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDaySC3.SelectedIndex != -1)
            {
                showListRoomTheoDayVaLoaiPhong(cbbDaySC3.Text, cbbLoaiPhongSC3.Text);
            }
        }

        private void cbbLoaiPhongSC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiPhongSC3.SelectedIndex != -1)
            {
                showListRoomTheoDayVaLoaiPhong(cbbDaySC3.Text, cbbLoaiPhongSC3.Text);
            }
        }

        private void lvDanhSachPhongSC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDanhSachKhachSC3.Items.Clear();
            if (lvDanhSachPhongSC3.SelectedItems.Count > 0)
            {
                Clear();
                ListViewItem lvi = lvDanhSachPhongSC3.SelectedItems[0];
                int IDRoom = int.Parse(lvi.Text);
                lbPhongSC3.Text = lvi.Text;
                var stateRoom = db.MOTELROOMs.Where(room => room.ID == IDRoom).ToList();
                if (stateRoom[0].StateRoom != 4)
                {

                    var customers = (from rent in db.REINTINFORs
                                     join room in db.MOTELROOMs on rent.IDRoom equals room.ID
                                     join cus in db.CUSTOMERs on rent.IDCustomer equals cus.ID
                                     where room.ID == IDRoom && rent.CheckOutDate == null
                                     select new
                                     {
                                         cus.ID,
                                         cus.IDCard,
                                         cus.CustomerName,
                                         cus.Sexual,
                                         cus.Address,
                                         room.StateRoom
                                     }).ToList();

                    if (customers.Count == 0 && checkControll == true)
                    {
                        txtCMNDSC3.Enabled = true;
                        txtDiaChiSC3.Enabled = true;
                        txtSDTSC3.Enabled = true;
                        txtHoTenSC3.Enabled = true;
                        dtDateSC3.Enabled = true;
                        cbbGioiTinhSC3.Enabled = true;
                    }
                    else
                    {
                        if (checkControll == true)
                        {
                            if (stateRoom[0].StateRoom == 3)
                            {
                                txtCMNDSC3.Enabled = false;
                                txtDiaChiSC3.Enabled = false;
                                txtSDTSC3.Enabled = false;
                                txtHoTenSC3.Enabled = false;
                                dtDateSC3.Enabled = false;
                                cbbGioiTinhSC3.Enabled = false;
                                MessageBox.Show("The room is full slot!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                txtCMNDSC3.Enabled = true;
                                txtDiaChiSC3.Enabled = true;
                                txtSDTSC3.Enabled = true;
                                txtHoTenSC3.Enabled = true;
                                dtDateSC3.Enabled = true;
                                cbbGioiTinhSC3.Enabled = true;
                            }
                        }
                        foreach (var c in customers)
                        {
                            ListViewItem lv = new ListViewItem(c.IDCard);
                            lv.SubItems.Add(c.CustomerName);
                            lv.SubItems.Add(c.Sexual);
                            lv.SubItems.Add(c.Address);
                            lvDanhSachKhachSC3.Items.Add(lv);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("The room maintance!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMNDSC3.Enabled = false;
                    txtDiaChiSC3.Enabled = false;
                    txtSDTSC3.Enabled = false;
                    txtHoTenSC3.Enabled = false;
                    dtDateSC3.Enabled = false;
                    cbbGioiTinhSC3.Enabled = false;
                }
            }
        }

        public void Clear()
        {
            txtCMNDSC3.Text = "";
            txtDiaChiSC3.Text = "";
            txtSDTSC3.Text = "";
            txtHoTenSC3.Text = "";
            dtDateSC3.Value = DateTime.Now;
            cbbGioiTinhSC3.SelectedIndex = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtCMNDSC3.TextLength == 9 || txtCMNDSC3.TextLength == 12)
            {
                var customer = (from cus in db.CUSTOMERs
                                where cus.IDCard.Equals(txtCMNDSC3.Text)
                                select cus);
                foreach (var cus in customer)
                {
                    txtHoTenSC3.Text = cus.CustomerName;
                    txtHoTenSC3.ReadOnly = true;

                    txtSDTSC3.Text = cus.NumberPhone;
                    //txtSDTSC3.ReadOnly = true;

                    txtDiaChiSC3.Text = cus.Address;
                    txtDiaChiSC3.ReadOnly = true;

                    cbbGioiTinhSC3.Text = cus.Sexual;

                    dtDateSC3.Value = (DateTime)cus.DateOfBirth;
                }
            }
            else
            {
                txtHoTenSC3.ReadOnly = false;
                txtDiaChiSC3.ReadOnly = false;
                dtDateSC3.Value = DateTime.Now;
                cbbGioiTinhSC3.SelectedIndex = -1;

                txtHoTenSC3.Text = "";
                txtSDTSC3.Text = "";
                txtDiaChiSC3.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDTSC3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void clear()
        {
            txtHoTenSC3.ReadOnly = false;
            txtDiaChiSC3.ReadOnly = false;
            dtDateSC3.Value = DateTime.Now;
            cbbGioiTinhSC3.SelectedIndex = -1;

            txtCMNDSC3.Text = "";
            txtHoTenSC3.Text = "";
            txtSDTSC3.Text = "";
            txtDiaChiSC3.Text = "";
        }

        private void lvDanhSachKhachSC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachKhachSC3.SelectedItems.Count > 0)
            {
                String IDcard = lvDanhSachKhachSC3.SelectedItems[0].Text;
                var customer = (from c in db.CUSTOMERs
                                where c.IDCard.Equals(IDcard)
                                select c).ToList();
                foreach (var cus in customer)
                {
                    txtCMNDSC3.Text = cus.IDCard;
                    txtHoTenSC3.Text = cus.CustomerName;
                    txtDiaChiSC3.Text = cus.Address;
                    txtSDTSC3.Text = cus.NumberPhone;
                    dtDateSC3.Value = (DateTime)cus.DateOfBirth;
                    cbbGioiTinhSC3.Text = cus.Sexual;
                }

                //txtCMNDSC3.Enabled = false;
                txtDiaChiSC3.Enabled = false;
                txtSDTSC3.Enabled = false;
                txtHoTenSC3.Enabled = false;
                dtDateSC3.Enabled = false;
                cbbGioiTinhSC3.Enabled = false;

            }
        }

        private void lvDanhSachKhachSC3_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvDanhSachKhachSC3.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    lvDanhSachKhachSC3.ContextMenuStrip = contextMenuListcus;
                }
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = lvDanhSachKhachSC3.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(lvDanhSachKhachSC3.Columns.IndexOf(columnHeader6));
                sorter.Order = SortOrder.Ascending;
                lvDanhSachKhachSC3.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (lvDanhSachKhachSC3.Columns.IndexOf(columnHeader6) == sorter.Column)
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
                sorter.Column = lvDanhSachKhachSC3.Columns.IndexOf(columnHeader6);
                sorter.Order = SortOrder.Ascending;
            }
            lvDanhSachKhachSC3.Sort();
        }

        private void iDCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = lvDanhSachKhachSC3.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(lvDanhSachKhachSC3.Columns.IndexOf(columnHeader5));
                sorter.Order = SortOrder.Ascending;
                lvDanhSachKhachSC3.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (lvDanhSachKhachSC3.Columns.IndexOf(columnHeader6) == sorter.Column)
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
                sorter.Column = lvDanhSachKhachSC3.Columns.IndexOf(columnHeader5);
                sorter.Order = SortOrder.Ascending;
            }
            lvDanhSachKhachSC3.Sort();
        }

        private void lvDanhSachKhachSC3_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            ItemComparer sorter = lvDanhSachKhachSC3.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                lvDanhSachKhachSC3.ListViewItemSorter = sorter;
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
            lvDanhSachKhachSC3.Sort();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int IDRoom = int.Parse(lbPhongSC3.Text);
            string firstNumber = txtSDTSC3.Text;
            bool isOk = (txtCMNDSC3.TextLength == 9 || txtCMNDSC3.TextLength == 12)
                && (txtHoTenSC3.Text.Length > 0) && (txtDiaChiSC3.Text.Length > 0)
                && (txtSDTSC3.Text.Length == 10 && firstNumber[0].Equals('0')
                && cbbGioiTinhSC3.SelectedIndex != -1
                );
            if (isOk)
            {
                DialogResult d = MessageBox.Show("DO YOU WANT ADD " + txtCMNDSC3.Text + " ?", "UPDATE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    var check = (from c in db.CUSTOMERs
                                 where c.IDCard.Equals(txtCMNDSC3.Text)
                                 select c).ToList();
                    int ch = 0;
                    if (check.Count != 0)
                    {
                        ch = check[0].ID;
                    }
                    var rentInfor = (from ren in db.REINTINFORs
                                     where ren.IDCustomer == ch && ren.IDRoom == IDRoom
                                     select ren).ToList();
                    bool checkRen = false;
                    if (rentInfor.Count != 0)
                    {
                        var checkID = db.REINTINFORs.Where(r => r.IDRoom == IDRoom && r.IDCustomer == ch && r.CheckOutDate == null).Select(r => r.CheckInDate).Max();
                        if (checkID == null)
                        {
                            // Database phải thêm CheckInDate cũng là khóa chính
                            var newRent = new Model.REINTINFOR();
                            newRent.IDCustomer = check[0].ID;
                            newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                            newRent.CheckInDate = DateTime.Now;
                            db.REINTINFORs.Add(newRent);
                            db.SaveChanges();
                            checkRen = true;
                        }
                        else // chưa trả phòng mà thuê nữa thì không cho
                        {
                            MessageBox.Show("Customer is living here!");
                            checkRen = true;
                        }

                        if (checkRen == false)
                        {
                            var newRent = new Model.REINTINFOR();
                            newRent.IDCustomer = check[0].ID;
                            newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                            newRent.CheckInDate = DateTime.Now;
                            db.REINTINFORs.Add(newRent);
                            db.SaveChanges();
                        }
                    }
                    else // thêm
                    {
                        // Thêm customer
                        db = new Model.MotelManagerEntities4();
                        var check1 = db.CUSTOMERs.Where(u => u.ID.Equals(ch)).ToList();
                        if (check1.Count == 0)
                        {
                            db.CUSTOMERs.Add(new Model.CUSTOMER
                            {
                                IDCard = txtCMNDSC3.Text,
                                CustomerName = txtHoTenSC3.Text,
                                NumberPhone = txtSDTSC3.Text,
                                Sexual = cbbGioiTinhSC3.Text,
                                Address = txtDiaChiSC3.Text,
                                DateOfBirth = dtDateSC3.Value,
                            });
                            db.SaveChanges();
                        }
                        else
                        {
                            var query = db.CUSTOMERs.Single(u => u.ID.Equals(ch));
                            query.IDCard = txtCMNDSC3.Text;
                            query.CustomerName = txtHoTenSC3.Text;
                            query.NumberPhone = txtSDTSC3.Text;
                            query.Sexual = cbbGioiTinhSC3.Text;
                            query.Address = txtDiaChiSC3.Text;
                            query.DateOfBirth = dtDateSC3.Value;
                            db.SaveChanges();
                            // this.frmAddCustomer_Load(sender, e);
                        }
                        // Thêm rent_info
                        var getID = db.CUSTOMERs.Where(u => u.IDCard.Equals(txtCMNDSC3.Text)).ToList();
                        var newRent = new Model.REINTINFOR();
                        newRent.IDCustomer = getID[0].ID;
                        newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                        newRent.CheckInDate = DateTime.Now;
                        db.REINTINFORs.Add(newRent);
                        db.SaveChanges();
                        //frmAddCustomer_Load(sender, e);
                    }
                    lvDanhSachKhachSC3.Items.Clear();

                    var customer = (from Room in db.MOTELROOMs
                                    join Ren in db.REINTINFORs on Room.ID equals Ren.IDRoom
                                    join Cus in db.CUSTOMERs on Ren.IDCustomer equals Cus.ID
                                    where Room.ID == IDRoom && Ren.CheckOutDate == null
                                    select Cus).ToList();
                    var Quantity = (from Room in db.MOTELROOMs
                                    where IDRoom == Room.ID
                                    select Room).ToList();
                    if (customer.Count == Quantity[0].ROOMRANK.Quantity)
                    {
                        var temp = db.MOTELROOMs.Single(room => room.ID == IDRoom);
                        temp.StateRoom = 3;
                        db.SaveChanges();
                        frmAddCustomer_Load(sender, e);
                    }
                    else
                    {
                        var temp = db.MOTELROOMs.Single(room => room.ID == IDRoom);
                        temp.StateRoom = 2;
                        db.SaveChanges();
                        frmAddCustomer_Load(sender, e);
                    }
                    foreach (var c in customer)
                    {
                        ListViewItem lv = new ListViewItem(c.IDCard);
                        lv.SubItems.Add(c.CustomerName);
                        lv.SubItems.Add(c.Sexual);
                        lv.SubItems.Add(c.Address);
                        lvDanhSachKhachSC3.Items.Add(lv);
                    }
                    Clear();
                    if (customer.Count == 1)
                    {
                        var IDStaff = (from staff in db.STAFFs
                                       where staff.UserName == checkUsername
                                       select staff).ToList();
                        if (IDStaff.Count == 0)
                        {
                            db.createNewBill(IDRoom, null);
                        }
                        else
                        {
                            foreach (var staff in IDStaff)
                            {
                                db.createNewBill(IDRoom, staff.ID);
                            }
                        }
                    }
                    MessageBox.Show("COMPLETE!");
                }
            }
            else
            {
                MessageBox.Show("Let's type information correct!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("ARE YOU SURE CHECK OUT " + txtCMNDSC3.Text + " ?", "DELETE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                var idCus = from cus in db.CUSTOMERs
                            where cus.IDCard == txtCMNDSC3.Text
                            select cus;
                int IDroom = int.Parse(lbPhongSC3.Text);
                foreach (var cus in idCus)
                {
                    var temp = db.REINTINFORs.Single(rein => rein.IDCustomer == cus.ID && rein.IDRoom == IDroom);
                    temp.CheckOutDate = DateTime.Now;
                }
                db.SaveChanges();
                clear();
            }

            lvDanhSachKhachSC3.Items.Clear();
            int IDRoom = int.Parse(lbPhongSC3.Text);
            var customer = (from Room in db.MOTELROOMs
                            join Ren in db.REINTINFORs on Room.ID equals Ren.IDRoom
                            join Cus in db.CUSTOMERs on Ren.IDCustomer equals Cus.ID
                            where Room.ID == IDRoom && Ren.CheckOutDate == null
                            select Cus).ToList();
            var Quantity = (from Room in db.MOTELROOMs
                            where IDRoom == Room.ID
                            select Room).ToList();
            if (customer.Count == 0)
            {
                var temp = db.MOTELROOMs.Single(room => room.ID == IDRoom);
                temp.StateRoom = 1;
                db.SaveChanges();
                frmAddCustomer_Load(sender, e);
            }
            else if (customer.Count == Quantity[0].ROOMRANK.Quantity)
            {
                var temp = db.MOTELROOMs.Single(room => room.ID == IDRoom);
                temp.StateRoom = 3;
                db.SaveChanges();
                frmAddCustomer_Load(sender, e);
            }
            foreach (var c in customer)
            {
                ListViewItem lv = new ListViewItem(c.IDCard);
                lv.SubItems.Add(c.CustomerName);
                lv.SubItems.Add(c.Sexual);
                lv.SubItems.Add(c.Address);
                lvDanhSachKhachSC3.Items.Add(lv);
            }
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label110.BackColor = System.Drawing.Color.Transparent;
            this.label111.BackColor = System.Drawing.Color.Transparent;
            this.label113.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            //this.lvDanhSachKhachSC1.ForeColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.lbPhongSC3.BackColor = System.Drawing.Color.Transparent;

        }

        private void ButtonDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("ARE YOU SURE DELETE " + txtCMNDSC3.Text + " ?", "DELETE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                var idCus = from cus in db.CUSTOMERs
                            where cus.IDCard == txtCMNDSC3.Text
                            select cus;
                int IDroom = int.Parse(lbPhongSC3.Text);
                foreach (var cus in idCus)
                {
                    var date = db.REINTINFORs.Where(rein => rein.IDCustomer == cus.ID && rein.IDRoom == IDroom && rein.CheckOutDate == null).Select(rein => rein.CheckInDate).Max().Date;
                    Model.REINTINFOR temp = db.REINTINFORs.Where(rein => rein.IDCustomer == cus.ID && rein.IDRoom == IDroom && EntityFunctions.TruncateTime(rein.CheckInDate) == date).FirstOrDefault();
                    //foreach (var rein in temp)
                    //{
                    //    db.REINTINFORs.Attach(rein);
                    //    db.REINTINFORs.Remove(rein);
                    //}
                    db.Entry(temp).State = EntityState.Deleted;
                }
                db.SaveChanges();
                clear();
                MessageBox.Show("COMPLETE", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            lvDanhSachKhachSC3.Items.Clear();
            int IDRoom = int.Parse(lbPhongSC3.Text);
            var customer = (from Room in db.MOTELROOMs
                            join Ren in db.REINTINFORs on Room.ID equals Ren.IDRoom
                            join Cus in db.CUSTOMERs on Ren.IDCustomer equals Cus.ID
                            where Room.ID == IDRoom && Ren.CheckOutDate == null
                            select Cus).ToList();
            var Quantity = (from Room in db.MOTELROOMs
                            where IDRoom == Room.ID
                            select Room).ToList();
            if (customer.Count == 0)
            {
                var temp = db.MOTELROOMs.Single(room => room.ID == IDRoom);
                temp.StateRoom = 1;
                db.SaveChanges();
                frmAddCustomer_Load(sender, e);
            }
            else if (customer.Count == Quantity[0].ROOMRANK.Quantity)
            {
                var temp = db.MOTELROOMs.Single(room => room.ID == IDRoom);
                temp.StateRoom = 3;
                db.SaveChanges();
                frmAddCustomer_Load(sender, e);
            }
            foreach (var c in customer)
            {
                ListViewItem lv = new ListViewItem(c.IDCard);
                lv.SubItems.Add(c.CustomerName);
                lv.SubItems.Add(c.Sexual);
                lv.SubItems.Add(c.Address);
                lvDanhSachKhachSC3.Items.Add(lv);
            }
            Clear();
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
