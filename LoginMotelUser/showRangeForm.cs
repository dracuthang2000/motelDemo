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
    public partial class showRangeForm : Form
    {
        int soLuong = 15;
        int dem;
        int tong;
        int tinh;
        private Boolean check;
        Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2();
        public showRangeForm(Boolean check)
        {
            InitializeComponent();
            loadData(0, soLuong);
            dem = 0;
            if(check == true)
            {
                buttUpdate.Enabled = false;
                textSearch.Visible = false;
                labSearch.Visible = false;
                OldName.Visible = false;
                NewName.Visible = false;
                textNewName.Visible = false;
                labRangeName.Visible = true;
                buttUpdate.Text = "ADD";
            }
            else
            {
                OldName.Visible = true;
                NewName.Visible = true;
                labRangeName.Visible = false;
                buttUpdate.Text = "UPDATE";
            }
            this.check = check;
        }
        public void loadData(int b, int e)
        {
            var list = (from d in data.USP_PageRange(b, e) select d).ToList();
            listRange.Columns.Add("ID Khu vực", 100);
            listRange.Columns.Add("Tên Khu Vực", 140);
            foreach (var a in list)
            {
                ListViewItem item = new ListViewItem(a.ID.ToString());
                item.SubItems.Add(a.RangeName);
                listRange.Items.Add(item);
            }
            var temp2 = (from c in data.USP_CountRange() select c).ToList();
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

        private void listRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            textIDRange.Text = listRange.FocusedItem.Text;
            int a = int.Parse(textIDRange.Text);
            Model.ROOMRANGE b = data.ROOMRANGEs.Find(a);
            textRangeName.Text = b.RangeName;
        }
        public void saveData()
        {
            Model.ROOMRANGE temp = new Model.ROOMRANGE() { RangeName = textRangeName.Text };
            data.ROOMRANGEs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            Model.ROOMRANGE a = data.ROOMRANGEs.Find(int.Parse(textIDRange.Text));
            a.RangeName = textNewName.Text;
            data.SaveChanges();
        }

        private void buttUpdate_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (textRangeName.Text == "")
                {
                    MessageBox.Show("Let'type Old Range Name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if(textIDRange.Text.Equals(""))
                {
                    MessageBox.Show("ID is not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(textNewName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Let'type New Range Name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var query = (from range in data.ROOMRANGEs
                                 where range.RangeName.Equals(textNewName.Text)
                                 select range).ToList();
                    DialogResult result = MessageBox.Show("Are you sure Range Name " + textRangeName.Text + " ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (query.Count == 0)
                    {
                        switch (result)
                        {
                            case DialogResult.Yes:
                                {
                                    updateData(); listRange.Clear();
                                    loadData(0, soLuong);
                                    dem = 0;
                                    break;
                                }
                            case DialogResult.No: return;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Range Name is exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure insert this Range?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            saveData(); listRange.Clear();
                            loadData(0, soLuong);
                            dem = 0;
                            break;
                        }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (textIDRange.Text == "")
            {
                MessageBox.Show("Hay chon id can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Ban co chac xoa khu vuc co ID = " + textIDRange.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Cancel: return;
                case DialogResult.Yes:
                    {
                        Model.ROOMRANGE temp = data.ROOMRANGEs.Find(int.Parse(textIDRange.Text));
                        data.ROOMRANGEs.Remove(temp);
                        data.SaveChanges();
                        listRange.Clear();
                        loadData(0, soLuong);
                        dem = 0;
                        break;
                    }
                case DialogResult.No: return;

                default:
                    break;

            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textIDRange.Text = "";
            textRangeName.Text = "";
            textNewName.Text = "";
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRange.Clear();
            labPage.Text = "Trang 1/1";
            using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
            {
                String temp = textSearch.Text;
                List<Model.ROOMRANGE> list = (from a in data.ROOMRANGEs where a.RangeName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                listRange.Columns.Add("ID Khu vực", 100);
                listRange.Columns.Add("Tên Khu Vực", 140);
                foreach (Model.ROOMRANGE a in list)
                {
                    ListViewItem item = new ListViewItem(a.ID.ToString());
                    item.SubItems.Add(a.RangeName);
                    listRange.Items.Add(item);
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
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
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
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                listRange.Clear();
                labPage.Text = "Trang 1/1";
                using (Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2())
                {
                    String temp = textSearch.Text;
                    List<Model.ROOMRANGE> list = (from a in data.ROOMRANGEs where a.RangeName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                    listRange.Columns.Add("ID Khu vực", 100);
                    listRange.Columns.Add("Tên Khu Vực", 140);
                    foreach (Model.ROOMRANGE a in list)
                    {
                        ListViewItem item = new ListViewItem(a.ID.ToString());
                        item.SubItems.Add(a.RangeName);
                        listRange.Items.Add(item);
                    }

                }
            }
        }
        private void textRangeName_TextChanged(object sender, EventArgs e)
        {
            var query = (from range in data.ROOMRANGEs
                         where range.RangeName.Equals(textRangeName.Text)
                         select range).ToList();
            if (check == true)
            {
                textSearch.Text = textRangeName.Text;
                if (query.Count == 0 && !textRangeName.Text.Trim().Equals(""))
                {
                    buttUpdate.Enabled = true;
                    textIDRange.Text = "";
                }
                else
                {
                    buttUpdate.Enabled = false;
                    if(textRangeName.Text.Trim().Equals(""))
                        textIDRange.Text = "";
                    foreach (var range in query)
                        textIDRange.Text = range.ID.ToString();
                }
            }
            else
            {
                if (textRangeName.Text.Trim().Equals(""))
                    textIDRange.Text = "";
                foreach (var range in query)
                    textIDRange.Text = range.ID.ToString();
            }
        }
    }
}
