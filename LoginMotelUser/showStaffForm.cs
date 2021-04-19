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
    public partial class showStaffForm : Form
    {
        public showStaffForm()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
            {
                listStaff.Columns.Add("ID Card", 100);
                listStaff.Columns.Add("Họ Tên", 150);
                listStaff.Columns.Add("Ngày Sinh", 100);
                listStaff.Columns.Add("Địa Chỉ", 200);
                listStaff.Columns.Add("Số điện thoại", 100);
                listStaff.Columns.Add("Tên User", 100);
                listStaff.Columns.Add("Giới Tính", 70);
                List<Model.STAFF> list = data.STAFFs.ToList();

                foreach (Model.STAFF c in list)
                {
                    ListViewItem item = new ListViewItem(c.IDCard.ToString());
                    item.SubItems.Add(c.StaffName);
                    String[] temp = c.DateOfBirth.ToString().Split(' ');
                    item.SubItems.Add(temp[0]);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.NumberPhone.ToString());
                    item.SubItems.Add(c.UserName);
                    item.SubItems.Add(c.Sexual.ToString());
                    listStaff.Items.Add(item);
                }
            }
        }
        private void loadList()
        {
            listStaff.Clear();
            loadData();
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            createStaffForm sOF = new createStaffForm();
            sOF.goiHam = loadList;
            sOF.ShowDialog();


        }


        private void butSua_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                String temp = listStaff.FocusedItem.Text;


                createStaffForm sOF = new createStaffForm(temp);
                sOF.goiHam = loadList;
                sOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon quan ly can sua tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listStaff_DoubleClick(object sender, EventArgs e)
        {
            String temp = listStaff.FocusedItem.Text;


            createStaffForm createStaff = new createStaffForm(temp);
            createStaff.goiHam = loadList;
            createStaff.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
                {
                    DialogResult result = MessageBox.Show("Ban co chac xoa quan ly co ID = " + listStaff.FocusedItem.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                                Model.STAFF temp = data.STAFFs.Find(listStaff.FocusedItem.Text);
                                data.STAFFs.Remove(temp);
                                data.SaveChanges();
                                listStaff.Clear();
                                loadData();
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
                MessageBox.Show("Hay chon quan ly can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void butUser_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                createStaffForm pOF = new createStaffForm(listStaff.FocusedItem.Text);
                pOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon quan ly can dat mat khau danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
