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
        public showStaffForm(Boolean checkUpdate)
        {
            InitializeComponent();
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            loadData();
            this.checkUpdate = checkUpdate;
            if(checkUpdate == true)
            {
                buttonUp.Text = "ADD";
            }
            else
            {
                buttonUp.Text = "UPDATE";
            }
        }
        private Boolean checkUpdate;
        public void loadData()
        {
            using (Model.MotelManagerEntities3 data = new Model.MotelManagerEntities3())
            {
                listStaff.Columns.Add("ID Card", 100);
                listStaff.Columns.Add("Full name", 150);
                listStaff.Columns.Add("Birthday", 100);
                listStaff.Columns.Add("Address", 200);
                listStaff.Columns.Add("Number Phone", 100);
                listStaff.Columns.Add("Username", 100);
                listStaff.Columns.Add("Sexual", 70);
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
        private void listStaff_DoubleClick(object sender, EventArgs e)
        {
            String temp = listStaff.FocusedItem.Text;


            createStaffForm createStaff = new createStaffForm(temp,checkUpdate);
            createStaff.goiHam = loadList;
            createStaff.ShowDialog();
        }

        private void listStaff_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = listStaff.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listStaff.ListViewItemSorter = sorter;
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
            listStaff.Sort();
        }

        private void listStaff_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                listStaff.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = listStaff.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(listStaff.Items[0].Index);
                sorter.Order = SortOrder.Ascending;
                listStaff.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (listStaff.Items[0].Index == sorter.Column)
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
                sorter.Column = listStaff.Items[0].Index;
                sorter.Order = SortOrder.Ascending;
            }
            listStaff.Sort();
            nameToolStripMenuItem.Checked = false;
            dateToolStripMenuItem.Checked = false;
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = listStaff.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(listStaff.Items[1].Index);
                sorter.Order = SortOrder.Ascending;
                listStaff.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (listStaff.Items[1].Index == sorter.Column)
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
                sorter.Column = listStaff.Items[1].Index;
                sorter.Order = SortOrder.Ascending;
            }
            listStaff.Sort();
            dateToolStripMenuItem.Checked = false;
            iDToolStripMenuItem.Checked = false;
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemComparer sorter = listStaff.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(listStaff.Items[3].Index);
                sorter.Order = SortOrder.Ascending;
                listStaff.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (listStaff.Items[4].Index == sorter.Column)
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
                sorter.Column = listStaff.Items[3].Index;
                sorter.Order = SortOrder.Ascending;
            }
            listStaff.Sort();
            nameToolStripMenuItem.Checked = false;
            iDToolStripMenuItem.Checked = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities3 data = new Model.MotelManagerEntities3())
                {
                    DialogResult result = MessageBox.Show("Are you sure DELETE ID CARD = " + listStaff.FocusedItem.Text + " ? (ALL data will be delete!)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                var temp = from staff in data.STAFFs
                                           where staff.IDCard.Equals(listStaff.FocusedItem.Text)
                                           select staff;
                                foreach (var staff in temp)
                                {
                                    data.STAFFs.Remove(staff);
                                }
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
                MessageBox.Show("You need to choose ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (checkUpdate == true)
            {
                createStaffForm sOF = new createStaffForm(checkUpdate);
                sOF.goiHam = loadList;
                sOF.ShowDialog();
            }
            else
            {
                if (listStaff.SelectedItems.Count > 0)
                {
                    String temp = listStaff.FocusedItem.Text;


                    createStaffForm sOF = new createStaffForm(temp, checkUpdate);
                    sOF.goiHam = loadList;
                    sOF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hay chon quan ly can sua tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                using (Model.MotelManagerEntities3 data = new Model.MotelManagerEntities3())
                {
                    DialogResult result = MessageBox.Show("Are you sure DELETE ID CARD = " + listStaff.FocusedItem.Text + " ? (ALL data will be delete!)", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                var temp = from staff in data.STAFFs
                                           where staff.IDCard.Equals(listStaff.FocusedItem.Text)
                                           select staff;
                                foreach (var staff in temp)
                                {
                                    data.STAFFs.Remove(staff);
                                }
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
                MessageBox.Show("You need to choose ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
