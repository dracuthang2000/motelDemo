using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace LoginMotelUser
{
    public partial class FormPrices : Form
    {
        string checkUsername;
        private Boolean checkRole;
        public FormPrices(String userName, Boolean checkRole)
        {
            InitializeComponent();
            setColor();
            this.checkUsername = userName;
            this.checkRole = checkRole;
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

        Model.MotelManagerEntities4 db;
        private void frmPrice_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities4();
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
            if(lbIDPhongSC4.Text == "")
            {
                MessageBox.Show("Let's Choices ID Room! ","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int idRoom = int.Parse(lbIDPhongSC4.Text);
            var date = db.getMaxdate(idRoom).ToList();
            int idBill = date[0].Value;
            var getDate = (from Date in db.BILLs
                          where idBill == Date.ID
                          select Date).ToList();
            DateTime dateMax = getDate[0].Date.Value.Date;
            double dateTotal = -(dateMax - DateTime.Now.Date).TotalDays;
            String Price = lbTienPhong.Text.Replace(",", "");
            Double total = (Double.Parse(Price) * dateTotal) / 30;
            String RoomPrice = total.ToString();
            decimal TotalSer = 0;
            foreach (ListViewItem list in listService.Items)
            {
                TotalSer = TotalSer + decimal.Parse(list.SubItems[4].Text);
            }
            decimal Total = decimal.Parse(RoomPrice) + TotalSer;
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

           
            if (txtTongTien.Text.Trim().Equals("")|| txtTongTien.Text.Trim().Equals("0"))
            {
                MessageBox.Show("TotalBill is null", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult d = MessageBox.Show("Are you saving this?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    int ID = int.Parse(lbIDPhongSC4.Text);

                    var IDStaff = (from staff in db.STAFFs
                                   where staff.UserName == checkUsername
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
                    int idBill=0;
                    foreach (var id in maxDate)
                    {
                        idBill = id.Value;
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
                    printBill(idBill);
                    MessageBox.Show("COMPLETE!");
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

        private void printBill(int id)
        {
            int so = id;

            var list1 =(from bill in db.BILLs
                        where bill.ID == so
                        select bill).ToList();
            //Create Table           
            Document doc = new Document();
            Paragraph p1 = doc.AddSection().AddParagraph();
            TextRange text = p1.AppendText("Phiếu Thu Tiền Trọ\n");
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            text.CharacterFormat.FontName = "Calibri";
            text.CharacterFormat.FontSize = 22;
            text.CharacterFormat.TextColor = Color.Red;
            p1.Format.TextAlignment = TextAlignment.Center;
            p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            foreach (var bill in list1)
            {
                String[] xuLy = bill.Date.ToString().Split(' ');

                p1.AppendText("Ngày: " + xuLy[0] + "\n");
                Paragraph p2 = doc.Sections[0].AddParagraph();
                p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                p2.Format.TextAlignment = TextAlignment.Baseline;
                if (bill.IDStaff == null)
                {
                    p2.AppendText("Tên Quản Lý: " + "Admin" + "\n");
                }
                else
                {
                    p2.AppendText("Tên Quản Lý: " + bill.STAFF.StaffName + "\n");
                }
                p2.AppendText("Tên Phòng: " + bill.MOTELROOM.RoomName + "\n");
                p2.AppendText("\n");
            }

            Table table = doc.Sections[0].AddTable(true);
            //Create Header and Data
            String[] Header = { "STT", "Tên Dịch Vụ", "Chỉ Số Đầu", "Chỉ Số Cuối", "Đơn Giá", "Thành Tiền" };

            var services = (from p in db.PARTICULARSERVICEs
                            join s in db.SERVICEs on p.IDService equals s.ID
                            join bill in db.BILLs on p.IDBill equals bill.ID
                            where p.IDBill.Equals(id)
                            select new
                            {
                                s.ServiceName,
                                p.OldIndex,
                                p.NewIndex,
                                s.Price,
                                p.Total,
                            }).ToList();
            String[][] data = new String[services.Count + 1][];
            int j = 0;
            foreach (var temp in services)
            {
                String[] a = { (j + 1).ToString(), temp.ServiceName, temp.OldIndex.ToString(), temp.NewIndex.ToString(), temp.Price.ToString(), temp.Total.ToString() };

                data[j] = a;
                j++;
            }
            String[] b = { "Tổng tiền", "", list1[0].TotalMoney.ToString() };
            data[services.Count] = b;
            //Add Cells
            table.ResetCells(data.Length + 1, Header.Length);

            //Header Row

            TableRow FRow = table.Rows[0];

            FRow.IsHeader = true;

            //Row Height

            FRow.Height = 23;

            //Header Format

            FRow.RowFormat.BackColor = Color.AliceBlue;

            for (int i = 0; i < Header.Length; i++)

            {

                //Cell Alignment

                Paragraph p3 = FRow.Cells[i].AddParagraph();

                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                p3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                //Data Format

                TextRange TR = p3.AppendText(Header[i]);

                TR.CharacterFormat.FontName = "Calibri";

                TR.CharacterFormat.FontSize = 14;

                TR.CharacterFormat.TextColor = Color.Teal;

                TR.CharacterFormat.Bold = true;

            }
            //Data Row
            for (int r = 0; r < data.Length; r++)

            {
                TableRow DataRow = table.Rows[r + 1];
                //Row Height
                DataRow.Height = 20;

                //C Represents Column.

                for (int c = 0; c < data[r].Length; c++)

                {
                    doc.Sections[0].Tables[0].Rows[r + 1].Cells[c].Width = 200;

                    //Cell Alignment

                    DataRow.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    //Fill Data in Rows

                    Paragraph p4 = DataRow.Cells[c].AddParagraph();

                    TextRange TR2 = p4.AppendText(data[r][c]);

                    //Format Cells

                    p4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    TR2.CharacterFormat.FontName = "Calibri";

                    TR2.CharacterFormat.FontSize = 12;

                    TR2.CharacterFormat.TextColor = Color.Brown;

                }

            }
            table.ApplyHorizontalMerge(services.Count + 1, 0, 1);
            table.ApplyHorizontalMerge(services.Count + 1, 2, 5);
            Paragraph p5 = doc.Sections[0].AddParagraph();
            p5.Format.Tabs.AddTab(20).Justification = TabJustification.Right;
            p5.Format.Tabs.AddTab(300).Justification = TabJustification.Left;
            p5.AppendText("\n");
            Spire.Doc.Fields.TextRange text3 = p5.AppendText("\t Đại diện bên thuê\t Đại diện bên cho thuê\n");
            text3.CharacterFormat.FontName = "Century Gothic";
            text3.CharacterFormat.FontSize = 18;
            p5.AppendText("\t             Kí xác nhận\t                Kí ghi rõ họ tên");



            //Save and Launch

            doc.SaveToFile(@"C:\Users\nguye\Documents\word.docx");
            doc.Close();
            System.Diagnostics.Process.Start(@"C:\Users\nguye\Documents\word.docx");
        }


        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            New_User nU = new New_User(checkRole,checkUsername);
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
