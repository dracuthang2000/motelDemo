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
    /// <summary>
    ///  adadadadadad
    /// </summary>
    public partial class Admin_Formcs : Form
    {
        LoginMotelUser.Model.MotelManagerEntities db;
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


        private void Admin_Formcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'motelManagerDataSet.USER' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'motel_manager_demoDataSet1.ROLE' table. You can move, or remove it, as needed.
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities();
            loadListRoom();

            cbbDaySC1.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC1.DisplayMember = "RangeName";
            cbbDaySC1.SelectedIndex = -1;
        }
        private void loadListRoom()
        {
            var dsRanges = db.ROOMRANGEs.ToList();

            // Thêm Root cây
            List<TreeNode> treeNodes = new List<TreeNode>();
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
                txtTrangThaiSC1.Text = room[0].StateRoom == true ? "Đã cho thuê" : "Trống";

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
                    ListViewItem lvi = new ListViewItem(customer.ID);
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
                    foreach (var room in rooms)
                    {
                        if (room.StateRoom == true) daThue++;
                        else trong++;
                    }
                    lbPhongTrongSC1.Text = trong.ToString() + "     phòng";
                    lbPhongDaThueSC1.Text = daThue.ToString() + "     phòng";
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
    }
}
