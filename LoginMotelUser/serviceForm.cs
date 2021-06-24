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
    public partial class serviceForm : Form
    {
        int soLuong = 15;
        int dem;
        int tong;
        int tinh;
        Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4();
        private Boolean check;
        private Boolean checkRole;
        private String checkUsername;
        public serviceForm(Boolean check, Boolean checkRole, String checkUsername)
        {
            InitializeComponent();
            this.check = check;
            if (check == true)
            {
                buttonSave.Text = "SAVE";
                buttonSave.Visible = false;
            }
            else
            {
                buttonSave.Text = "UPDATE";
                buttonSave.Visible = false;
            }
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
            loadData(0, soLuong);
            dem = 0;
            this.checkRole = checkRole;
            this.checkUsername = checkUsername; 
        }
        public void loadData(int b, int e)
        {
            var list = (from d in data.USP_PageService(b, e) select d).ToList();
            listService.Columns.Add("ID Service", 100);
            listService.Columns.Add("Service name", 140);
            listService.Columns.Add("Price", 140);
            listService.Columns.Add("Unit", 100);
            foreach (var a in list)
            {
                Double priceSer = Double.Parse(a.Price.ToString().Replace(",", ""));
                ListViewItem item = new ListViewItem(a.ID.ToString());
                item.SubItems.Add(a.ServiceName);
                item.SubItems.Add(priceSer.ToString());
                item.SubItems.Add(a.Unit);
                listService.Items.Add(item);
            }
            var temp2 = (from c in data.USP_CountService() select c).ToList();
            tong = int.Parse(temp2[0].ToString());
            if (tong == 0) tong = 1;
            if (tong % soLuong != 0)
            {
                tinh = tong / soLuong + 1;
            }
            else
            {
                tinh = tong / soLuong;
            }

            labPage.Text = "Page 1/" + tinh;

        }

        private void listService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listService.SelectedItems.Count > 0)
            {
                textIDService.Text = listService.FocusedItem.Text;
                int a = int.Parse(textIDService.Text);
                Model.SERVICE b = data.SERVICEs.Find(a);
                Double priceSer = Double.Parse(b.Price.ToString().Replace(",", ""));
                textServiceName.Text = b.ServiceName;
                textPrice.Text = priceSer.ToString();
                comboBoxUnit.Text = b.Unit;
            }
        }
        public void saveData()
        {
            decimal a = decimal.Parse(textPrice.Text);
            Model.SERVICE temp = new Model.SERVICE() { ServiceName = textServiceName.Text, Price = a, Unit = comboBoxUnit.Text};
            data.SERVICEs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            var checkServiceName = (from ser in data.SERVICEs
                                    where ser.ID.ToString() != textIDService.Text && ser.ServiceName == textServiceName.Text
                                    select ser).ToList();
            if(checkServiceName.Count != 0)
            {
                MessageBox.Show("The new service name is exists!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Model.SERVICE a = data.SERVICEs.Find(int.Parse(textIDService.Text));     
            decimal b = decimal.Parse(textPrice.Text);
            a.ServiceName = textServiceName.Text;
            a.Price = b;
            a.Unit=comboBoxUnit.Text;
            data.SaveChanges();
        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listService.Clear();
            labPage.Text = "Trang 1/1";
            using (Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4())
            {
                String temp = textSearch.Text;
                List<Model.SERVICE> list = (from a in data.SERVICEs where a.ServiceName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                listService.Columns.Add("ID service", 100);
                listService.Columns.Add("Service name", 140);
                listService.Columns.Add("Price", 140);
                listService.Columns.Add("Unit", 100);
                if(check == true )
                {
                    if(list.Count == 0)
                    {
                        buttonSave.Visible = true;
                    }
                    else
                    {
                        buttonSave.Visible = false;
                    }
                }
                foreach (Model.SERVICE a in list)
                {
                    Double priceSer = Double.Parse(a.Price.ToString().Replace(",", ""));
                    ListViewItem item = new ListViewItem(a.ID.ToString());
                    item.SubItems.Add(a.ServiceName);
                    item.SubItems.Add(priceSer.ToString());
                    item.SubItems.Add(a.Unit);
                    listService.Items.Add(item);
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
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Page " + (dem + 1) + "/" + tinh;
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
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Page " + (dem + 1) + "/" + tinh;
        }


        private void textServiceName_TextChanged(object sender, EventArgs e)
        {
            var query = (from service in data.SERVICEs
                        where service.ServiceName.Equals(textServiceName.Text)
                        select service).ToList();
            if (check == true)
            {
                if(query.Count != 0)
                {
                    textPrice.Text = query[0].Price.ToString();
                    comboBoxUnit.Text = query[0].Unit;
                    buttonSave.Visible = false;
                }
                else
                {
                    buttonSave.Visible = true;
                    textPrice.Text = "";
                    comboBoxUnit.Text = "";
                }

            }
            else
            {
                if(listService.SelectedItems.Count <0)
               textSearch.Text = textServiceName.Text; 
                foreach(var ser in query)
                {
                    Double priceSer = Double.Parse(ser.Price.ToString().Replace(",", ""));
                    textIDService.Text = ser.ID.ToString();
                    textPrice.Text = priceSer.ToString();
                    comboBoxUnit.Text = ser.Unit;
                }
                if(query.Count == 0)
                {
                    textIDService.Text = "";
                    textPrice.Text = "";
                    comboBoxUnit.SelectedIndex = -1;
                    buttonSave.Visible = false;
                }
                else
                {
                    buttonSave.Visible = true;
                }
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textPrice.Text.Trim().Equals(""))
            {
                MessageBox.Show("The price is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxUnit.Text.Trim().Equals(""))
            {
                MessageBox.Show("The Unit phone is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (check == true)
            {
                if (textServiceName.Text.Trim() == "")
                {
                    MessageBox.Show("let's type service name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var checkServiceName = (from service in data.SERVICEs
                                        where textServiceName.Text.Equals(service.ServiceName)
                                        select service).ToList();
                if (checkServiceName.Count != 0)
                {
                    MessageBox.Show("The new service name is exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure insert?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            saveData(); listService.Clear();
                            loadData(0, soLuong);
                            dem = 0;
                            MessageBox.Show("COMPLETE!");
                            break;
                        }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textPrice.Text, "[^0-9.]"))
                {
                    MessageBox.Show("Chi nhap so vao don gia!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textPrice.Text = "";
                    return;
                }
                if (textIDService.Text != "")
                {
                        DialogResult result = MessageBox.Show("Are you sure fix Data The service have ID = " + textIDService.Text + "? ", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        switch (result)
                        {
                            case DialogResult.Cancel: return;
                            case DialogResult.Yes:
                                {
                                    updateData(); listService.Clear();
                                    loadData(0, soLuong);
                                    dem = 0;
                                MessageBox.Show("Complete!");
                                    break;
                                }
                            case DialogResult.No: return;

                            default:
                                break;

                        }
                }else
                {
                    MessageBox.Show("Type incorrect!");
                }
            }

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (textIDService.Text == "")
            {
                MessageBox.Show("Let's choices id you want to delete!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idser = int.Parse(textIDService.Text);
            var checkService = (from service in data.SERVICEs
                                join par in data.PARTICULARSERVICEs on service.ID equals par.IDService
                                where service.ID == idser
                                select service).ToList();
            if(checkService.Count > 0)
            {
                MessageBox.Show("The service is user another!", "WANRING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure delete ID sercvice = " + textIDService.Text + " ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Cancel: return;
                case DialogResult.Yes:
                    {
                        Model.SERVICE temp = data.SERVICEs.Find(int.Parse(textIDService.Text));
                        data.SERVICEs.Remove(temp);
                        data.SaveChanges();
                        listService.Clear();
                        loadData(0, soLuong);
                        dem = 0;
                        MessageBox.Show("DELETE IS COMPELTE!");
                        break;
                    }
                case DialogResult.No: return;

                default:
                    break;

            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            textIDService.Text = "";
            textServiceName.Text = "";
            textPrice.Text = "";
            comboBoxUnit.SelectedIndex = -1;
            textSearch.Text = "";
        }

        public void setColor()
        {
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labSearch.BackColor = System.Drawing.Color.Transparent;
            this.labPage.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labID.BackColor = System.Drawing.Color.Transparent;
            this.labServiceName.BackColor = System.Drawing.Color.Transparent;
            this.labID.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            New_User nU = new New_User(checkRole, checkUsername);
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

        private void viewReninformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Viewinformation Fc = new Viewinformation(checkRole, checkUsername);
            Fc.ShowDialog();
        }
    }
}
