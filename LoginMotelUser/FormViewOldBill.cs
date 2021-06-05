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
    public partial class FormViewOldBill : Form
    {
        private Boolean checkRole;
        private String checkUsername;
        public FormViewOldBill(Boolean checkRole, String checkUsername)
        {
            InitializeComponent();
            setColor();
            this.checkRole = checkRole;
            this.checkUsername = checkUsername;
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
        private void frmCollect_Load(object sender, EventArgs e)
        {
            db = new Model.MotelManagerEntities4();

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
                         where b.TotalMoney != null && b.Paid == true
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
                         where b.MOTELROOM.RoomName.Contains(txtIDPhongSC5.Text) && b.Paid == true && b.MOTELROOM.ROOMRANGE.RangeName.Contains(cbbDaySC5.Text) &&  b.TotalMoney!=null
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
                             where b.TotalMoney !=null && b.Paid == true
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
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            if (lvDanhSachHoaDonSC5.SelectedItems.Count > 0)
            {
                DialogResult d = MessageBox.Show("Are you Print bill ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    ListViewItem lvi = lvDanhSachHoaDonSC5.SelectedItems[0];
                    int idBill = int.Parse(lvi.SubItems[0].Text);
                    printBill(idBill);
                    lvChiTietHoaDonSC5.Items.Clear();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.label128.BackColor = System.Drawing.Color.Transparent;
            this.label134.BackColor = System.Drawing.Color.Transparent;
            this.label141.BackColor = System.Drawing.Color.Transparent;
            this.label142.BackColor = System.Drawing.Color.Transparent;
            this.label150.BackColor = System.Drawing.Color.Transparent;

        }
        private void printBill(int id)
        {
            int so = id;

            var list1 = (from bill in db.BILLs
                         where bill.ID == so
                         select bill).ToList();
            //Create Table           
            Document doc = new Document();
            Paragraph p1 = doc.AddSection().AddParagraph();
            TextRange text = p1.AppendText("HÓA ĐƠN\n");
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
            String[] b = { "Tổng Tiền", "", list1[0].TotalMoney.ToString() };
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
            p5.AppendText("\t             Tình Trạng: Đã Thanh Toán");



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
