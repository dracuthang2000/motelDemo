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
    public partial class FormPrices : Form
    {
        string userName;
        public FormPrices(String userName)
        {
            InitializeComponent();
            setColor();
            this.userName = userName;
        }

        Model.MotelManagerEntities2 db;
        private void frmPrice_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities2();
            cbbDaySC4.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC4.DisplayMember = "RangeName";
            cbbDaySC4.SelectedIndex = -1;

            cbbLoaiPhongSC4.DataSource = db.ROOMRANKs.ToList();
            cbbLoaiPhongSC4.DisplayMember = "RankName";
            cbbLoaiPhongSC4.SelectedIndex = -1;

            cbbDaySC4.Enabled = true;
            cbbLoaiPhongSC4.Enabled = false;
            lbIDPhongSC4.Text = "";
            listService.Items.Clear();
        }

        private void showListRoomTheoDayVaLoaiPhong(string rangeName, string rankName)
        {
            lvDanhSachPhongSC4.Items.Clear();
            var rooms = from rent in db.REINTINFORs
                        group rent by rent.IDRoom into g
                        select new
                        {
                            ID = g.Key,
                            SL = g.Count(),
                        };
            if (!rangeName.Equals("") && !rankName.Equals(""))
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              where room.Paid == false
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);
                    lvi.SubItems.Add(nroom.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
            else if (!rangeName.Equals(""))
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              where room.Paid == false
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank,
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var room in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(room.ID.ToString());
                    lvi.SubItems.Add(room.RoomName);
                    lvi.SubItems.Add(room.RangeName);
                    lvi.SubItems.Add(room.RankName);
                    lvi.SubItems.Add(room.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
            else if (!rankName.Equals(""))
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              where room.Paid == false
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var room in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(room.ID.ToString());
                    lvi.SubItems.Add(room.RoomName);
                    lvi.SubItems.Add(room.RangeName);
                    lvi.SubItems.Add(room.RankName);
                    lvi.SubItems.Add(room.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
            else
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              where room.Paid == false
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var room in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(room.ID.ToString());
                    lvi.SubItems.Add(room.RoomName);
                    lvi.SubItems.Add(room.RangeName);
                    lvi.SubItems.Add(room.RankName);
                    lvi.SubItems.Add(room.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
        }
        private void cbbDaySC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            cbbLoaiPhongSC4.Enabled = true;
            showListRoomTheoDayVaLoaiPhong(cbbDaySC4.Text, cbbLoaiPhongSC4.Text);
        }

        private void cbbLoaiPhongSC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            showListRoomTheoDayVaLoaiPhong(cbbDaySC4.Text, cbbLoaiPhongSC4.Text);
        }

        public void clear()
        {
            cbbCMNDSC4.Text="";
            txtHoTenSC4.Text = "";
            txtSDTSC4.Text = "";
            txtQueQuanSC4.Text = "";
            txtGioiTinhSC4.Text = "";
            txtTongTien.Text = "";
            cbbCMNDSC4.Enabled = false;
        }
        private void lvDanhSachPhongSC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachPhongSC4.SelectedItems.Count > 0)
            {
                cbbCMNDSC4.Enabled = true;
                // sau Khi click vào 1 List View Item thì ta cần truy vấn 
                // được customer, sau đó đổ thông tin vào các textBox
                ListViewItem lvi = lvDanhSachPhongSC4.SelectedItems[0];
                lbIDPhongSC4.Text = lvi.Text;
                // IDRoom chính là lvi.Text
                int IDRoom = int.Parse(lvi.Text);

                var customers = (from rent in db.REINTINFORs
                                 join cus in db.CUSTOMERs on rent.IDCustomer equals cus.ID
                                 where rent.IDRoom == IDRoom
                                 select new
                                 {
                                     cus.IDCard,
                                 }).ToList();

                cbbCMNDSC4.DataSource = customers;
                cbbCMNDSC4.DisplayMember = "IDCard";

                var rankRooms = (from m in db.MOTELROOMs
                                 join r in db.ROOMRANKs on m.IDRoomRank equals r.ID
                                 where m.ID.Equals(IDRoom)
                                 select new
                                 {
                                     r.Price,
                                 }).ToList();
                lbTienPhong.Text = String.Format("{0,0:0,0}", rankRooms[0].Price);
            }
        }

        private void cbbCMNDSC4_SelectedValueChanged(object sender, EventArgs e)
        {
            var customers = (from cus in db.CUSTOMERs
                             where cus.IDCard.Equals(cbbCMNDSC4.Text)
                             select new
                             {
                                 cus.IDCard,
                                 cus.CustomerName,
                                 cus.NumberPhone,
                                 cus.Address,
                                 cus.Sexual,
                             }).ToList();
            if (customers.Count > 0)
            {
                txtHoTenSC4.Text = customers[0].CustomerName;
                txtSDTSC4.Text = customers[0].NumberPhone;
                txtQueQuanSC4.Text = customers[0].Address;
                txtGioiTinhSC4.Text = customers[0].Sexual;
            }
        }       // Bắt đầu xử lý tiền điện

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            decimal TotalSer = 0;
            foreach (ListViewItem list in listService.Items)
            {
                TotalSer = TotalSer + decimal.Parse(list.SubItems[4].Text);
            }
            decimal Total = decimal.Parse(lbTienPhong.Text) + TotalSer;
            txtTongTien.Text = (Total).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lbIDPhongSC4.Text.Trim().Equals(""))
            {
                AddParticularServiceForm f;
                if (listService.Items.Count == 0)
                {
                    f = new AddParticularServiceForm(lbIDPhongSC4.Text);
                    f.ShowDialog();
                    listService.Items.Clear();
                }
                else
                {
                    f = new AddParticularServiceForm(listService, lbIDPhongSC4.Text);
                    f.ShowDialog();
                    listService.Items.Clear();
                }
                foreach (ListViewItem l in f.listServiceChoose().Items)
                {
                    ListViewItem list = new ListViewItem(l.SubItems[0].Text);
                    list.SubItems.Add(l.SubItems[1].Text);
                    list.SubItems.Add(l.SubItems[2].Text);
                    list.SubItems.Add(l.SubItems[3].Text);
                    list.SubItems.Add(l.SubItems[4].Text);
                    listService.Items.Add(list);
                }
                txtTongTien.Text = "";
            }
            else
            {
                MessageBox.Show("Let's choose Room", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (listService.Items.Count != 0)
            {
                cbbDaySC4.Enabled = false;
                cbbLoaiPhongSC4.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Are you saving this?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtTongTien.Text.Trim().Equals(""))
            {
                MessageBox.Show("TotalBill is null", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (d == DialogResult.Yes)
                {
                    int ID = int.Parse(lbIDPhongSC4.Text);

                    var IDStaff = (from staff in db.STAFFs
                                   where staff.UserName == userName
                                   select staff).ToList();
                    if (IDStaff.Count == 0)
                    {
                        db.BILLs.Add(new Model.BILL
                        {
                            IDRoom = ID,
                            Date = DateTime.Now,
                            TotalMoney = Decimal.Parse(txtTongTien.Text),
                            Paid = false
                        });
                    }
                    else
                    {
                        foreach (var staff in IDStaff)
                        {
                            db.BILLs.Add(new Model.BILL
                            {
                                IDRoom = ID,
                                Date = DateTime.Now,
                                TotalMoney = Decimal.Parse(txtTongTien.Text),
                                IDStaff = staff.ID,
                                Paid = false
                            });
                        }
                    }
                    db.SaveChanges();
                    var maxDate = db.getMaxdate(ID);
                    foreach (var id in maxDate)
                    {
                        foreach (ListViewItem l in listService.Items)
                        {
                            var parS = new Model.PARTICULARSERVICE();
                            parS.IDBill = id.Value;
                            parS.IDService = int.Parse(l.SubItems[0].Text);
                            parS.NewIndex = int.Parse(l.SubItems[2].Text);
                            parS.OldIndex = int.Parse(l.SubItems[3].Text);
                            parS.Total = Decimal.Parse(l.SubItems[4].Text);
                            db.PARTICULARSERVICEs.Add(parS);
                        }
                    }
                    var paid = db.MOTELROOMs.Single(room => room.ID.Equals(ID));
                    paid.Paid = true;
                    db.SaveChanges();
                    clear();
                    frmPrice_Load(sender, e);
                }
            }
        }

        private void buttonCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.lbIDPhongSC4.BackColor = System.Drawing.Color.Transparent;
            this.lbTienPhong.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
