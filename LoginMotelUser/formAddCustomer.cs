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
    public partial class formAddCustomer : Form
    {
        public formAddCustomer()
        {
            InitializeComponent();
        }
        Model.MotelManagerEntities2 db = new Model.MotelManagerEntities2();
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities2();
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
                    if (nroom.StateRoom == 1)
                    {
                        check = "Trống";
                    }
                    else if (nroom.StateRoom == 2)
                    {
                        check = "Còn chỗ";
                    }
                    else
                    {
                        check = "Hết chỗ";
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
                    if (nroom.StateRoom == 1)
                    {
                        check = "Trống";
                    }
                    else if (nroom.StateRoom == 2)
                    {
                        check = "Còn chỗ";
                    }
                    else
                    {
                        check = "Hết chỗ";
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
                    if (nroom.StateRoom == 1)
                    {
                        check = "Trống";
                    }
                    else if (nroom.StateRoom == 2)
                    {
                        check = "Còn chỗ";
                    }
                    else
                    {
                        check = "Hết chỗ";
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
                    if (nroom.StateRoom == 1)
                    {
                        check = "Trống";
                    }
                    else if (nroom.StateRoom == 2)
                    {
                        check = "Còn chỗ";
                    }
                    else
                    {
                        check = "Hết chỗ";
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
                ListViewItem lvi = lvDanhSachPhongSC3.SelectedItems[0];
                int IDRoom = int.Parse(lvi.Text);
                lbPhongSC3.Text = lvi.Text;
                var customers = (from rent in db.REINTINFORs
                                 join room in db.MOTELROOMs on rent.IDRoom equals room.ID
                                 join cus in db.CUSTOMERs on rent.IDCustomer equals cus.ID
                                 where room.ID == IDRoom
                                 select new
                                 {
                                     cus.ID,
                                     cus.IDCard,
                                     cus.CustomerName,
                                     cus.Sexual,
                                     cus.Address,
                                     room.StateRoom
                                 }).ToList();

                foreach (var c in customers)
                {
                    if (c.StateRoom == 3)
                    {
                        txtCMNDSC3.Enabled = false;
                        txtDiaChiSC3.Enabled = false;
                        txtSDTSC3.Enabled = false;
                        txtHoTenSC3.Enabled = false;
                        dtDateSC3.Enabled = false;
                        cbbGioiTinhSC3.Enabled = false;
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
                    ListViewItem lv = new ListViewItem(c.IDCard);
                    lv.SubItems.Add(c.CustomerName);
                    lv.SubItems.Add(c.Sexual);
                    lv.SubItems.Add(c.Address);
                    lvDanhSachKhachSC3.Items.Add(lv);
                }
            }
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

        private void btnXoaSC3_Click(object sender, EventArgs e)
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

        private void btnThemSC3_Click_1(object sender, EventArgs e)
        {
            string firstNumber = txtSDTSC3.Text;
            bool isOk = (txtCMNDSC3.TextLength == 9 || txtCMNDSC3.TextLength == 12)
                && (txtHoTenSC3.Text.Length > 0) && (txtDiaChiSC3.Text.Length > 0)
                && (txtSDTSC3.Text.Length == 10 && firstNumber[0].Equals('0')
                && cbbGioiTinhSC3.SelectedIndex != -1
                );
            DialogResult d = MessageBox.Show("DO YOU WANT ADD "+ txtCMNDSC3.Text+ " ?", "UPDATE MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isOk)
            {
                // Nếu IDRoom khác thì thêm bảng rent
                // Nếu IDRoom giống thì kiểm tra
                // Nếu như đã chưa ngày checkout thì báo: Khách hàng đã thuê phòng này
                // Nếu như đã có ngày checkout ?? Chỉnh sửa lại ngày hả?

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
                                     where ren.IDCustomer == ch
                                     select ren).ToList();
                    bool checkRen = false;
                    if (rentInfor.Count != 0)
                    {
                        foreach (var ren in rentInfor)
                        {
                            if (lbPhongSC3.Text.Equals(ren.IDRoom.ToString()))
                            {
                                if (ren.CheckOutDate != null) // có nghĩa đã trả phòng thì ta vẫn tạo hợp đồng mới                                                               // chứ sao có thể Edit hợp đồng đó được
                                {
                                    // Database phải thêm CheckInDate cũng là khóa chính
                                    var newRent = new Model.REINTINFOR();
                                    newRent.IDCustomer = check[0].ID;
                                    newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                                    newRent.CheckInDate = DateTime.Now;

                                    db.REINTINFORs.Add(newRent);
                                    db.SaveChanges();
                                }
                                else // chưa trả phòng mà thuê nữa thì không cho
                                {
                                    MessageBox.Show("Khách hiện đang ở phòng này, không thể đăng kí thêm!");
                                    checkRen = true;
                                    break;
                                }
                            }
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
                        db = new Model.MotelManagerEntities2();
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
                    int IDRoom = int.Parse(lbPhongSC3.Text);
                    var customer = from Room in db.MOTELROOMs
                                   join Ren in db.REINTINFORs on Room.ID equals Ren.IDRoom
                                   join Cus in db.CUSTOMERs on Ren.IDCustomer equals Cus.ID
                                   where Room.ID == IDRoom
                                   select Cus;
                    foreach (var c in customer)
                    {
                        ListViewItem lv = new ListViewItem(c.IDCard);
                        lv.SubItems.Add(c.CustomerName);
                        lv.SubItems.Add(c.Sexual);
                        lv.SubItems.Add(c.Address);
                        lvDanhSachKhachSC3.Items.Add(lv);
                    }
                    txtCMNDSC3.Text = "";
                    txtDiaChiSC3.Text = "";
                    txtSDTSC3.Text = "";
                    txtHoTenSC3.Text = "";
                    dtDateSC3.Value = DateTime.Now;
                    cbbGioiTinhSC3.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvDanhSachKhachSC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachKhachSC3.SelectedItems.Count > 0)
            {
                String IDcard = lvDanhSachKhachSC3.SelectedItems[0].Text;
                var customer = (from c in db.CUSTOMERs
                               where c.IDCard.Equals(IDcard)
                               select c).ToList();
                foreach(var cus in customer)
                {
                    txtCMNDSC3.Text = cus.IDCard;
                    txtHoTenSC3.Text = cus.CustomerName;
                    txtDiaChiSC3.Text = cus.Address;
                    txtSDTSC3.Text = cus.NumberPhone;
                    dtDateSC3.Value = (DateTime)cus.DateOfBirth;
                    cbbGioiTinhSC3.Text = cus.Sexual;
                }
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
    }
}
