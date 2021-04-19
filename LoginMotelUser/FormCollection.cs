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
    public partial class FormCollection : Form
    {
        public FormCollection()
        {
            InitializeComponent();
        }
        Model.MotelManagerEntities2 db;
        private void frmCollect_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities2();

            cbbDaySC5.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC5.DisplayMember = "RangeName";
            cbbDaySC5.SelectedIndex = -1;

            // Tại đây hóa đơn có vấn về
            lvDanhSachHoaDonSC5.Items.Clear();
            loadListViewDanhSachHoaDon();
        }
        void loadListViewDanhSachHoaDon()
        {
            lvDanhSachHoaDonSC5.Items.Clear();
            var bills = (from b in db.BILLs
                         where b.Paid == false
                         select b).ToList();
            foreach (var bill in bills)
            {
                ListViewItem lvi = new ListViewItem(bill.ID.ToString());
                lvi.SubItems.Add(bill.MOTELROOM.RoomName);
                lvi.SubItems.Add(String.Format("{0:d}", bill.Date));
                // Chưa có đăng nhập
                if (bill.IDStaff == null)
                {
                    lvi.SubItems.Add("Admin");
                }
                else
                {
                    lvi.SubItems.Add(bill.STAFF.IDCard);
                }
                lvi.SubItems.Add(String.Format("{0:0,0}", bill.TotalMoney));

                lvDanhSachHoaDonSC5.Items.Add(lvi);
            }
        }

        private void txtIDPhongSC5_TextChanged(object sender, EventArgs e)
        {
            lvDanhSachHoaDonSC5.Items.Clear();
            var bills = (from b in db.BILLs
                        where b.MOTELROOM.RoomName.Contains(txtIDPhongSC5.Text) && b.Paid == false && b.MOTELROOM.ROOMRANGE.RangeName.Contains(cbbDaySC5.Text)
                        select b).ToList();

            foreach (var bill in bills)
            {
                ListViewItem lvi = new ListViewItem(bill.ID.ToString());
                lvi.SubItems.Add(bill.MOTELROOM.RoomName);
                lvi.SubItems.Add(String.Format("{0:d}", bill.Date));
                // Chưa có đăng nhập
                if (bill.IDStaff == null)
                {
                    lvi.SubItems.Add("Admin");
                }
                else
                {
                    lvi.SubItems.Add(bill.STAFF.IDCard);
                }
                lvi.SubItems.Add(String.Format("{0:0,0}", bill.TotalMoney));

                lvDanhSachHoaDonSC5.Items.Add(lvi);
            }
        }

        private void cbbDaySC5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDaySC5.SelectedIndex > -1)
            {
                lvDanhSachHoaDonSC5.Items.Clear();
                var Rooms = from ra in db.ROOMRANGEs
                            join r in db.MOTELROOMs on ra.ID equals r.IDRoomRange
                            where ra.RangeName.Equals(cbbDaySC5.Text)
                            select r;
                var bills = (from b in db.BILLs
                             join r in Rooms on b.IDRoom equals r.ID
                             where b.Paid == false
                             select b).ToList();
                if (bills.Count > 0)
                {
                    lvChiTietHoaDonSC5.Items.Clear();
                    foreach (var bill in bills)
                    {
                        ListViewItem lvi = new ListViewItem(bill.ID.ToString());
                        lvi.SubItems.Add(bill.MOTELROOM.RoomName);
                        lvi.SubItems.Add(String.Format("{0:d}", bill.Date));
                        // Chưa có đăng nhập
                        // lvi.SubItems.Add(bill.IDStaff);
                        lvi.SubItems.Add("Admin");
                        lvi.SubItems.Add(String.Format("{0:0,0}", bill.TotalMoney));
                        lvDanhSachHoaDonSC5.Items.Add(lvi);
                    }
                }


            }
        }

        private void lvDanhSachHoaDonSC5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachHoaDonSC5.SelectedItems.Count > 0)
            {
                lvChiTietHoaDonSC5.Items.Clear();
                ListViewItem lvi = lvDanhSachHoaDonSC5.SelectedItems[0];
                string id = lvi.SubItems[0].Text;

                var services = (from p in db.PARTICULARSERVICEs
                                join s in db.SERVICEs on p.IDService equals s.ID
                                join b in db.BILLs on p.IDBill equals b.ID
                                where p.IDBill.ToString().Equals(id)
                                select new
                                {
                                    s.ServiceName,
                                    p.OldIndex,
                                    p.NewIndex,
                                    p.Total,
                                }).ToList();
                if (services.Count() > 0)
                {
                    foreach (var s in services)
                    {
                        ListViewItem lvi1 = new ListViewItem(s.ServiceName);
                        lvi1.SubItems.Add(s.OldIndex.ToString());
                        lvi1.SubItems.Add(s.NewIndex.ToString());
                        lvi1.SubItems.Add(String.Format("{0:0,0}", s.Total));
                        lvChiTietHoaDonSC5.Items.Add(lvi1);
                    }
                }
            }
        }

        private void btnXacNhanDaDong_Click(object sender, EventArgs e)
        {
            if (lvDanhSachHoaDonSC5.SelectedItems.Count > 0)
            {
                DialogResult d = MessageBox.Show("Are you sure ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    ListViewItem lvi = lvDanhSachHoaDonSC5.SelectedItems[0];
                    int idBill = int.Parse(lvi.SubItems[0].Text);
                    var bill = (from b in db.BILLs
                                where b.ID == idBill
                                select b).ToList();
                    bill[0].Paid = true;
                    db.SaveChanges();
                    loadListViewDanhSachHoaDon();
                    MessageBox.Show("Update complete!");
                    lvChiTietHoaDonSC5.Items.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                int id = int.Parse(lvDanhSachHoaDonSC5.SelectedItems[0].Text);
                var idBill = (from bill in db.BILLs
                              where bill.ID == id
                              select bill).ToList();
                foreach (var bill in idBill)
                {
                    db.BILLs.Remove(bill);
                }
                db.SaveChanges();
                MessageBox.Show("Delete complete!");

            }
        }
    }
}
