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
    public partial class UpdateCusForm : Form
    {
        int soLuong = 16;
        int dem;
        int tong;
        int tinh;
        public UpdateCusForm()
        {
            InitializeComponent();
            loadCustomer(0, soLuong);
            dem = 0;
        }

        public void loadCustomer(int a, int b)
        {
            using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
            {
                listKhach.Columns.Add("ID", 100);
                listKhach.Columns.Add("Họ Tên", 150);
                listKhach.Columns.Add("Ngày Sinh", 100);
                listKhach.Columns.Add("Địa Chỉ", 200);
                listKhach.Columns.Add("Số điện thoại", 100);
                listKhach.Columns.Add("Giới Tính", 70);
                var list = (from d in data.USP_PageCustomer(a, b) select d).ToList();


                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.IDCard.ToString());
                    item.SubItems.Add(c.CustomerName);
                    String[] temp = c.DateOfBirth.ToString().Split(' ');
                    item.SubItems.Add(temp[0]);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.NumberPhone.ToString());
                    item.SubItems.Add(c.Sexual.ToString());
                    listKhach.Items.Add(item);
                }
                var temp2 = (from c in data.USP_CountCustomer() select c).ToList();
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
            listKhach.Clear();
            loadCustomer(0, soLuong);
            dem = 0;
        }
        private void butSua_Click(object sender, EventArgs e)
        {
            if (listKhach.SelectedItems.Count > 0)
            {
                String temp = listKhach.FocusedItem.Text;


                FormCustomer gOF = new FormCustomer(temp,false);
                gOF.goiHam = loadList;
                gOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon khach can sua tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listKhach_DoubleClick(object sender, EventArgs e)
        {
            String temp = listKhach.FocusedItem.Text;


            FormCustomer gOF = new FormCustomer(temp,false);
            gOF.goiHam = loadList;
            gOF.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (listKhach.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
                {
                    DialogResult result = MessageBox.Show("Ban co chac xoa khach co ID = " + listKhach.FocusedItem.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                                Model.CUSTOMER temp = data.CUSTOMERs.Find(listKhach.FocusedItem.Text);
                                data.CUSTOMERs.Remove(temp);
                                data.SaveChanges();
                                listKhach.Clear();
                                loadCustomer(0, soLuong);
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
                MessageBox.Show("Hay chon khach can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listKhach.Clear();
            labPage.Text = "Trang 1/1";
            using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
            {
                String temp = textSearch.Text;
                List<Model.CUSTOMER> list = (from a in data.CUSTOMERs where a.CustomerName.Contains(temp) || a.ID.ToString().Contains(temp) || a.NumberPhone.Contains(temp) select a).ToList();
                listKhach.Clear();
                listKhach.Columns.Add("ID", 100);
                listKhach.Columns.Add("Họ Tên", 150);
                listKhach.Columns.Add("Ngày Sinh", 100);
                listKhach.Columns.Add("Địa Chỉ", 200);
                listKhach.Columns.Add("Số điện thoại", 100);
                listKhach.Columns.Add("Giới Tính", 70);
                foreach (Model.CUSTOMER c in list)
                {
                    ListViewItem item = new ListViewItem(c.IDCard.ToString());
                    item.SubItems.Add(c.CustomerName);
                    String[] temp1 = c.DateOfBirth.ToString().Split(' ');
                    item.SubItems.Add(temp1[0]);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.NumberPhone.ToString());
                    item.SubItems.Add(c.Sexual.ToString());
                    listKhach.Items.Add(item);
                }

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
                listKhach.Clear();
                loadCustomer(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listKhach.Clear();
                loadCustomer(dem * soLuong, soLuong);
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
                listKhach.Clear();
                loadCustomer(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listKhach.Clear();
                loadCustomer(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                listKhach.Clear();
                labPage.Text = "Trang 1/1";
                using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
                {
                    String temp = textSearch.Text;
                    List<Model.CUSTOMER> list = (from a in data.CUSTOMERs where a.CustomerName.Contains(temp) || a.ID.ToString().Contains(temp) || a.NumberPhone.Contains(temp) select a).ToList();
                    listKhach.Clear();
                    listKhach.Columns.Add("ID", 100);
                    listKhach.Columns.Add("Họ Tên", 150);
                    listKhach.Columns.Add("Ngày Sinh", 100);
                    listKhach.Columns.Add("Địa Chỉ", 200);
                    listKhach.Columns.Add("Số điện thoại", 100);
                    listKhach.Columns.Add("Giới Tính", 70);
                    foreach (Model.CUSTOMER c in list)
                    {
                        ListViewItem item = new ListViewItem(c.ID.ToString());
                        item.SubItems.Add(c.CustomerName);
                        String[] temp1 = c.DateOfBirth.ToString().Split(' ');
                        item.SubItems.Add(temp1[0]);
                        item.SubItems.Add(c.Address);
                        item.SubItems.Add(c.NumberPhone.ToString());
                        item.SubItems.Add(c.Sexual.ToString());
                        listKhach.Items.Add(item);
                    }

                }
            }
        }

        private void listKhach_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = listKhach.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listKhach.ListViewItemSorter = sorter;
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
            listKhach.Sort();
        }

        private void listKhach_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                listKhach.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = listKhach.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(listKhach.Items[0].Index);
                sorter.Order = SortOrder.Ascending;
                listKhach.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (listKhach.Items[0].Index == sorter.Column)
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
                sorter.Column = listKhach.Items[0].Index;
                sorter.Order = SortOrder.Ascending;
            }
            listKhach.Sort();
            nameToolStripMenuItem.Checked = false;
            dateToolStripMenuItem.Checked = false;
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = listKhach.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(listKhach.Items[1].Index);
                sorter.Order = SortOrder.Ascending;
                listKhach.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (listKhach.Items[1].Index == sorter.Column)
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
                sorter.Column = listKhach.Items[1].Index;
                sorter.Order = SortOrder.Ascending;
            }
            listKhach.Sort();
            dateToolStripMenuItem.Checked = false;
            iDToolStripMenuItem.Checked = false;
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = listKhach.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(listKhach.Items[3].Index);
                sorter.Order = SortOrder.Ascending;
                listKhach.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (listKhach.Items[4].Index == sorter.Column)
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
                sorter.Column = listKhach.Items[3].Index;
                sorter.Order = SortOrder.Ascending;
            }
            listKhach.Sort();
            nameToolStripMenuItem.Checked = false;
            iDToolStripMenuItem.Checked = false;
        }
    }
}
