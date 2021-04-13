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
        public showRoomForm(Boolean check)
        {
            InitializeComponent();
            this.check = check;
            loadRoom(0, soLuong);
            dem = 0;
            if (this.check == true)
                butThem.Text = "ADD";
            else
                butSua.Text = "Update";
        }
        public void loadRoom(int e, int f)
        {
            using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
            {
                listRoom.Columns.Add("ID Phòng", 100);
                listRoom.Columns.Add("Tên Phòng", 150);
                listRoom.Columns.Add("Trạng Thái", 120);
                listRoom.Columns.Add("Loại phòng", 140);
                listRoom.Columns.Add("Tên Khu Vực ", 200);

                var list = (from d in data.USP_PageRoom(e, f) select d).ToList();

                foreach (var c in list)
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
                    else
                    {
                        item.SubItems.Add("hết chỗ");
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

                labPage.Text = "Trang 1/" + tinh;
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
                    AddRoomcs rOF = new AddRoomcs(temp,false);
                    rOF.goiHam = loadList;
                    rOF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("hay chon phong tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void butSua_Click(object sender, EventArgs e)
        {
            if (listRoom.SelectedItems.Count > 0)
            {
                String temp = listRoom.FocusedItem.Text;
                AddRoomcs rOF = new AddRoomcs(temp,false);
                rOF.goiHam = loadList;
                rOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("hay chon phong tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listRoom_DoubleClick(object sender, EventArgs e)
        {
            String temp = listRoom.FocusedItem.Text;
            AddRoomcs rOF = new AddRoomcs(temp,this.check);
            rOF.goiHam = loadList;
            rOF.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (listRoom.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
                {
                    DialogResult result = MessageBox.Show("Ban co chac xoa phong co ID = " + listRoom.FocusedItem.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                                Model.MOTELROOM temp = data.MOTELROOMs.Find(int.Parse(listRoom.FocusedItem.Text));
                                data.MOTELROOMs.Remove(temp);
                                data.SaveChanges();
                                listRoom.Clear();
                                loadRoom(0, soLuong);
                                dem = 0;
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
                MessageBox.Show("hay chon phong tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRoom.Clear();

            using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
            {
                String temp = textSearch.Text;
                List<Model.MOTELROOM> list = (from a in data.MOTELROOMs where a.RoomName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                listRoom.Columns.Add("ID Phòng", 100);
                listRoom.Columns.Add("Tên Phòng", 150);
                listRoom.Columns.Add("Trạng Thái", 120);
                listRoom.Columns.Add("Loại phòng", 140);
                listRoom.Columns.Add("Tên Khu Vực ", 200);

                foreach (Model.MOTELROOM c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RoomName);
                    if (c.StateRoom.Value == 1)
                    {
                        item.SubItems.Add("Phòng Trống");
                    }
                    else if(c.StateRoom.Value == 2)
                    {
                        item.SubItems.Add("còn chỗ");
                    }
                    else
                    {
                        item.SubItems.Add("hết chỗ");
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
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                listRoom.Clear();

                using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
                {
                    String temp = textSearch.Text;
                    List<Model.MOTELROOM> list = (from a in data.MOTELROOMs where a.RoomName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                    listRoom.Columns.Add("ID Phòng", 100);
                    listRoom.Columns.Add("Tên Phòng", 150);
                    listRoom.Columns.Add("Trạng Thái", 120);
                    listRoom.Columns.Add("Loại phòng", 140);
                    listRoom.Columns.Add("Tên Khu Vực ", 200);

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
                        else
                        {
                            item.SubItems.Add("hết chỗ");
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
        }
    }
}
