﻿using System;
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
    /// <summary>
    ///  adadadadadad
    /// </summary>
    public partial class Admin_Formcs : Form
    {
        LoginMotelUser.Model.MotelManagerEntities2 db;
        public Admin_Formcs()
        {
            InitializeComponent();
            this.FormClosed += Admin_Formcs_Close;
        }
        public bool isClose { get; set; }
        public bool checkRole { get; set; }
        public String checkUsername { get; set; }

        //public 
        private void Admin_Formcs_Close(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                isClose = true;
                return;
            }
        }



     
        private void insertUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_User nU = new New_User();
            nU.ShowDialog();
        }

        private void inserCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAddCustomer AC = new formAddCustomer();
            AC.ShowDialog();
            this.frmHome_Load(sender,e);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_User udU = new Update_User();
            udU.checkUsername = this.checkUsername;
            udU.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            isClose = true;
        }
        public void setColor()
        {
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            //this.lvDanhSachKhachSC1.ForeColor = System.Drawing.Color.Transparent;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.lbPhongDaThueSC1.BackColor = System.Drawing.Color.Transparent;
            this.lbPhongTrongSC1.BackColor = System.Drawing.Color.Transparent;
            this.labelHetCho.BackColor = System.Drawing.Color.Transparent;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label36.BackColor = System.Drawing.Color.Transparent;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.setColor();
            tvDanhSachPhongSC1.Nodes.Clear();
            db = new Model.MotelManagerEntities2();
            loadListRoom();
            var IDroom = from m in db.MOTELROOMs
                        select m;
            foreach(var id in IDroom)
            {
                var count = db.REINTINFORs.Count(r => r.IDRoom == id.ID);
                if(count == id.ROOMRANK.Quantity)
                {
                    var up = db.MOTELROOMs.Single(r => r.ID == id.ID);
                    up.StateRoom = 3;
                }else if (count > 0)
                {
                    var up = db.MOTELROOMs.Single(r => r.ID == id.ID);
                    up.StateRoom = 2;
                }else
                {
                    var up = db.MOTELROOMs.Single(r => r.ID == id.ID);
                    up.StateRoom = 1;
                }
            }
            db.SaveChanges();
            cbbDaySC1.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC1.DisplayMember = "RangeName";
            cbbDaySC1.SelectedIndex = -1;
            if (checkRole==true)
            {
                newtUserMenuItem.Visible = true;
                updateuserMenuItem.Visible = true;
            }
            else
            {
                newtUserMenuItem.Visible = false;
                updateuserMenuItem.Visible = false;
            }
        }
        private void loadListRoom()
        {
            var dsRanges = db.ROOMRANGEs.ToList();
            // Thêm Root cây
            List<TreeNode> treeNodes = new List<TreeNode>();
            treeNodes.Clear();
            foreach (var range in dsRanges)
            {
                // Position của ID tương ứng với position của Node 
                TreeNode node = new TreeNode()
                {
                    Text = range.RangeName,
                    //Name = range.ID.ToString(),
                };
                treeNodes.Add(node);
                tvDanhSachPhongSC1.Nodes.Add(range.RangeName);
            }
            // Thêm subTree 
            var rooms = (from a in db.MOTELROOMs
                         join b in db.ROOMRANGEs on a.IDRoomRange equals b.ID
                         join c in db.ROOMRANKs on a.IDRoomRank equals c.ID
                         select new
                         {
                             a.ID,
                             a.IDRoomRange,
                             a.RoomName,
                             b.RangeName,
                             c.RankName,
                             c.Price,
                             c.Deposits,
                             a.StateRoom
                         }).ToList();
            foreach (var room in rooms)
            {
                for (int i = 0; i < dsRanges.Count; i++)
                {
                    if (room.IDRoomRange == dsRanges[i].ID)
                    {
                        TreeNode node = new TreeNode()
                        {
                            Text = room.RoomName,
                            Name = room.ID.ToString(),
                        };
                        tvDanhSachPhongSC1.Nodes[i].Nodes.Add(node);
                    }
                }
            }
        }
        private void tvDanhSachPhongSC1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            // Ý tưởng sau khi click vào tên phòng thì 
            // ta sẽ cho các txtBox hiện các thông tin của phòng 
            // gồm
            // ID phòng
            // Tên Dãy
            // Tên Loại
            // Giá phòng
            // Tiền đặt cọc
            // Trạng thái

            //tvDanhSachPhongSC1.SelectedNode.Nodes.Count 
            //dùng để đếm sl node con của node đã chọn

            // Giải pháp hiện thời ta sẽ dùng Name Of Node để lưu ID Room

            // Đoạn này sau khi có được ID room ta muốn duyệt danh sách phòng  
            // Để tìm ra phòng rồi sau đó gán thông tin
            //tvDanhSachPhongSC1.Nodes.Clear();
            if (!tvDanhSachPhongSC1.SelectedNode.Name.Equals(""))
            {
                // Đoạn này ta chỉ mới field các textView Bên trái
                int id = int.Parse(tvDanhSachPhongSC1.SelectedNode.Name);
                var room = (from a in db.MOTELROOMs
                            join b in db.ROOMRANGEs on a.IDRoomRange equals b.ID
                            join c in db.ROOMRANKs on a.IDRoomRank equals c.ID
                            where id == a.ID
                            select new
                            {
                                a.ID,
                                a.IDRoomRange,
                                a.RoomName,
                                b.RangeName,
                                c.RankName,
                                c.Price,
                                c.Deposits,
                                a.StateRoom
                            }).ToList();
                txtMaPhongSC1.Text = room[0].ID.ToString();
                txtDaySC1.Text = room[0].RangeName;
                txtLoaiPhongSC1.Text = room[0].RankName;
                txtGiaPhongSC1.Text = String.Format("{0,0:0,0}", room[0].Price);
                txtTienCocSC1.Text = String.Format("{0,0:0,0}", room[0].Deposits);
                String check;
                if (room[0].StateRoom == 1)
                {
                    check = "Trống";
                }
                else if (room[0].StateRoom == 2)
                {
                    check = "Còn Chỗ";
                }
                else
                {
                    check = "Hết chỗ";
                }
                txtTrangThaiSC1.Text = check;

                // Khi có ID phòng thì
                // thực hiện join 2 bảng ReintInfor và Customer 
                // với ràng buộc ID phòng = reintInfor.ID và CustomerID = reintInfor.ID
                // Ta lấy danh sách customer

                var customers = (from rent in db.REINTINFORs
                                 join cus in db.CUSTOMERs on rent.IDCustomer equals cus.ID
                                 where rent.IDRoom == id
                                 select cus).ToList();
                // Sau đó chạy vòng For add lần lượt customer vào thôi 
                // Quá dễ 
                lvDanhSachKhachSC1.Items.Clear();
                foreach (var customer in customers)
                {
                    ListViewItem lvi = new ListViewItem(customer.IDCard);
                    lvi.SubItems.Add(customer.CustomerName);
                    string date = String.Format("{0:d}", customer.DateOfBirth);
                    lvi.SubItems.Add(date);
                    lvi.SubItems.Add(customer.Address);
                    lvi.SubItems.Add(customer.NumberPhone);
                    lvi.SubItems.Add(customer.Sexual);

                    lvDanhSachKhachSC1.Items.Add(lvi);
                }
            }
        }

        private void cbbDaySC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Even này đưa ta đi sử lý combobox
            if (cbbDaySC1.SelectedIndex != -1)
            {

                // ta cần join table MOTELROOM với ROOMRANGE
                try
                {
                    var rooms = (from r in db.MOTELROOMs
                                 join ra in db.ROOMRANGEs on r.IDRoomRange equals ra.ID
                                 where ra.RangeName.Equals(cbbDaySC1.Text)
                                 select new
                                 {
                                     r.StateRoom,
                                 }).ToList();
                    if (rooms == null) return;
                    int trong = 0;
                    int daThue = 0;
                    int hetcho = 0;
                    foreach (var room in rooms)
                    {
                        if (room.StateRoom == 2) daThue++;
                        else if (room.StateRoom == 3) hetcho++;
                        else trong++;
                    }
                    lbPhongTrongSC1.Text = trong.ToString() + "     phòng";
                    lbPhongDaThueSC1.Text = daThue.ToString() + "     phòng";
                    labelHetCho.Text = hetcho.ToString() + "     phòng";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                lbPhongTrongSC1.Text = "...     phòng";
                lbPhongDaThueSC1.Text = "...    phòng";
                labelHetCho.Text = "...    phòng";
            }
        }

        private void collectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection Fc = new FormCollection();
            Fc.ShowDialog();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrices FP = new FormPrices();
            FP.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCustomerForm gf = new ShowCustomerForm(true);
            gf.ShowDialog();
            this.frmHome_Load(sender,e);
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowCustomerForm uC = new ShowCustomerForm(false);
            uC.ShowDialog();
            this.frmHome_Load(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRoomForm sFR = new showRoomForm(true);
            sFR.ShowDialog();
            this.frmHome_Load(sender, e);
        }

        private void roomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showRoomForm sFR = new showRoomForm(false);
            sFR.ShowDialog();
            this.frmHome_Load(sender, e);
        }

        private void rankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRankForm rF = new showRankForm(true);
            rF.ShowDialog();
            this.frmHome_Load(sender, e);
        }

        private void rankToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showRankForm rF = new showRankForm(false);
            rF.ShowDialog();
            this.frmHome_Load(sender, e);
        }

        private void rangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRangeForm rF = new showRangeForm(true);
            rF.ShowDialog();
            this.frmHome_Load(sender, e);
        }

        private void rageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRangeForm rF = new showRangeForm(false);
            rF.ShowDialog();
            this.frmHome_Load(sender, e);
        }
    }
}
