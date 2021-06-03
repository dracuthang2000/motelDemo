using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMotelUser
{
    public partial class FormCustomer : Form
    {
        Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4();
        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
                goiHam();
        }
        Boolean check;
        private int IDcus;
        public FormCustomer(Boolean check)
        {
            InitializeComponent();
            setColor();
            if (check == true)
            {
                buttonUp.Visible = false;
            }
            this.check = check;
            datePickerCheckIn.Visible = false;
            datePickerCheckOut.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
        }
        public FormCustomer(String a, Boolean check)
        {
            InitializeComponent();
            setColor();
            if (check == true)
            {
                buttonUp.Visible = false;
            }
            this.check = check;
            this.textIDCus.Text = a;
            label1.Visible = false;
            label2.Visible = false;
            loadData(a);
        }
        public bool catchData()
        {
            textIDCus.Text = textIDCus.Text.Trim();
            textSDT.Text = textSDT.Text.Trim();
            Regex reg = new Regex(@"[0-9]{9}");
            Match result = reg.Match(textIDCus.Text);
            if (result.Length == 0 || textIDCus.Text.Length > 9)
            {
                MessageBox.Show("Please type ID is true!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //String re = "[0-9]{9}";
            reg = new Regex(@"0[0-9]{9}");
            result = reg.Match(textSDT.Text);
            if (result.Length == 0 || textSDT.Text.Length > 10)
            {
                MessageBox.Show("Please type phone number is true!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //format ho ten
            String temp = textHoTen.Text;
            temp = temp.Trim();
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " "); ;
            String[] change = temp.Split(' ');
            temp = "";
            for (int i = 0; i < change.Length; i++)
            {
                String a = change[i].Substring(0, 1);
                String b = change[i].Substring(1);

                a = a.ToUpper();

                b = b.ToLower();
                temp = temp + a + b + " ";
            }
            temp = temp.Trim();
            textHoTen.Text = temp;

            //format address
            temp = textAddress.Text;
            temp = temp.Trim();
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " ");
            change = temp.Split(',');
            temp = "";
            for (int i = 0; i < change.Length; i++)
            {
                if (change[i] != " ")
                {
                    change[i].Trim();
                    if (change[i].Substring(change[i].Length - 1).ToString() == " ")
                    {
                        change[i] = change[i].Substring(0, change[i].Length - 1);
                    }
                    if (change[i].Substring(0, 1).ToString() == " ")
                    {
                        change[i] = change[i].Substring(1);
                    }
                    temp = temp + change[i] + ", ";
                }


            }
            temp = temp.Substring(0, temp.Length - 2);


            change = temp.Split(' ');
            temp = "";
            for (int i = 0; i < change.Length; i++)
            {
                String a = change[i].Substring(0, 1);
                String b = change[i].Substring(1);

                a = a.ToUpper();

                b = b.ToLower();
                temp = temp + a + b + " ";
            }
            temp = temp.Trim();
            textAddress.Text = temp;

            return true;
        }
        public void loadData(String a)
        {
            var query = (from Cus in data.CUSTOMERs
                         where Cus.IDCard.Equals(a)
                         select Cus).ToList();
            int ID = 0;
            foreach (var id in query)
            {
                ID = id.ID;
            }
            this.IDcus = ID;
            Model.CUSTOMER c = data.CUSTOMERs.Find(ID);
            textHoTen.Text = c.CustomerName.ToString();
            textAddress.Text = c.Address.ToString();
            textSDT.Text = c.NumberPhone.ToString();
            comBoxSexual.Text = c.Sexual.ToString();
            datePickerBirth.Value = c.DateOfBirth.GetValueOrDefault();
            List<Model.REINTINFOR> list = (from b in data.REINTINFORs where b.IDCustomer == ID select b).ToList();
            if (list.Count > 0)
            {
                labIDRoomShow.Text = list[0].IDRoom.ToString();
                datePickerCheckIn.Value = list[0].CheckInDate.Date;
                if (list[0].CheckOutDate.GetValueOrDefault().Year == 0001) { datePickerCheckOut.Value = datePickerCheckOut.MinDate; }
                else
                {
                    datePickerCheckOut.Value = list[0].CheckOutDate.GetValueOrDefault();
                }
            }
            else
            {
                datePickerCheckIn.Visible = false;
                datePickerCheckOut.Visible = false;
            }



        }

        public void saveDate()
        {

            Model.CUSTOMER customer = new Model.CUSTOMER() { IDCard = textIDCus.Text, CustomerName = textHoTen.Text, DateOfBirth = datePickerBirth.Value, Address = textAddress.Text, NumberPhone = textSDT.Text, Sexual = comBoxSexual.Text };
            data.CUSTOMERs.Add(customer);
            data.SaveChanges();
        }
        public void updateData()
        {
            Model.CUSTOMER temp = data.CUSTOMERs.Single(Cus => Cus.IDCard == textIDCus.Text);
            temp.CustomerName = textHoTen.Text;
            temp.DateOfBirth = datePickerBirth.Value;
            temp.Address = textAddress.Text;
            temp.NumberPhone = textSDT.Text;
            temp.Sexual = comBoxSexual.Text;
            data.SaveChanges();

        }

        private void textIDCus_TextChanged(object sender, EventArgs e)
        {

            if (check == true)
            {
                if (textIDCus.Text.Length == 9)
                {
                    var query = (from Cus in data.CUSTOMERs
                                 join Rein in data.REINTINFORs on Cus.ID equals Rein.IDCustomer
                                 join Room in data.MOTELROOMs on Rein.IDRoom equals Room.ID
                                 where Cus.IDCard.Equals(textIDCus.Text)
                                 select new { Cus.CustomerName, Cus.IDCard, Cus.NumberPhone, Cus.Sexual, Cus.Address, Cus.DateOfBirth, Rein.CheckInDate, Rein.CheckOutDate, Room.RoomName }).ToList();
                    foreach (var Customer in query)
                    {
                        datePickerCheckIn.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                        datePickerCheckOut.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                        datePickerCheckIn.Visible = true;
                        textHoTen.Text = Customer.CustomerName;
                        textAddress.Text = Customer.Address;
                        textSDT.Text = Customer.NumberPhone;
                        datePickerBirth.Value = (DateTime)Customer.DateOfBirth;
                        comBoxSexual.Text = Customer.Sexual;
                        labIDRoomShow.Text = Customer.RoomName;
                        label1.Visible = false;
                        if (Customer.CheckOutDate != null)
                        {
                            label2.Visible = false;
                            datePickerCheckOut.Visible = true;
                            datePickerCheckOut.Value = (DateTime)Customer.CheckOutDate;
                        }
                        datePickerCheckIn.Value = (DateTime)Customer.CheckInDate;

                        textHoTen.Enabled = false;
                        textAddress.Enabled = false;
                        textSDT.Enabled = false;
                        datePickerBirth.Enabled = false;
                        comBoxSexual.Enabled = false;
                        datePickerCheckOut.Enabled = false;
                        datePickerCheckIn.Enabled = false;
                        buttonUp.Enabled = false;
                    }
                    if(query.Count == 0)
                    {
                        var cus = (from customer in data.CUSTOMERs
                                  where customer.IDCard == textIDCus.Text
                                  select customer).ToList();
                        foreach(var value in cus)
                        {
                            textAddress.Text = value.Address;
                            textHoTen.Text = value.CustomerName;
                            textSDT.Text = value.NumberPhone;
                            datePickerBirth.Value = value.DateOfBirth.Value.Date;
                            comBoxSexual.Text = value.Sexual;

                            textHoTen.Enabled = false;
                            textAddress.Enabled = false;
                            textSDT.Enabled = false;
                            datePickerBirth.Enabled = false;
                            comBoxSexual.Enabled = false;
                        }
                        if (cus.Count == 0)
                        {

                            textHoTen.Enabled = true;
                            textAddress.Enabled = true;
                            textSDT.Enabled = true;
                            datePickerBirth.Enabled = true;
                            comBoxSexual.Enabled = true;
                            buttonUp.Enabled = true;
                            buttonUp.Visible = true;
                        }
                    }
                   
                }
                else if (textIDCus.Text.Length < 9)
                {

                    textHoTen.Enabled = false;
                    textAddress.Enabled = false;
                    textSDT.Enabled = false;
                    datePickerBirth.Enabled = false;
                    comBoxSexual.Enabled = false;
                    buttonUp.Visible = false;

                    textHoTen.Text = "";
                    textAddress.Text = "";
                    textSDT.Text = "";
                    datePickerBirth.Text = "";
                    comBoxSexual.SelectedIndex = -1;

                    datePickerCheckOut.Visible = false;
                    datePickerCheckIn.Visible = false;
                    labIDRoomShow.Text = "Update...";
                    label1.Visible = true;
                    label2.Visible = true;
                }
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if(textHoTen.Text.Trim() == "")
            {
                MessageBox.Show("The name is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textSDT.Text.Trim() == "")
            {
                MessageBox.Show("The number phone is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("The Address is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((DateTime.Now.Year - datePickerBirth.Value.Year ) < 13)
            {
                MessageBox.Show("The Date of birth is incorrect( >12 year old)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comBoxSexual.Text.Trim().Equals(""))
            {
                MessageBox.Show("The Sexual is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (catchData() == false) return;
            if (check == true)
            {
                DialogResult result = MessageBox.Show("Are you save customer ID =" + textIDCus.Text + " ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { saveDate(); this.Close(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }
            }
            else
            {
                //int ID = int.Parse(la)
                var cus = (from Cus in data.CUSTOMERs
                           where Cus.IDCard.Equals(textIDCus.Text) && Cus.ID != this.IDcus
                           select Cus).ToList();
                // List<Model.CUSTOMER> list = (from b in data.CUSTOMERs where b.IDCard == textIDCus.Text select b).ToList();
                if (cus.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure update customer ID = " + textIDCus.Text + "  ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                                updateData(); this.Close(); break;
                                MessageBox.Show("COMPLETE!");

                            }
                        case DialogResult.No: return;

                        default:
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("ID Customer is exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.labDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.labCOD.BackColor = System.Drawing.Color.Transparent;
            this.labCID.BackColor = System.Drawing.Color.Transparent;
            this.labHoTen.BackColor = System.Drawing.Color.Transparent;
            this.labIDCus.BackColor = System.Drawing.Color.Transparent;
            this.labIDRoom.BackColor = System.Drawing.Color.Transparent;
            this.labIDRoomShow.BackColor = System.Drawing.Color.Transparent;
            //this.lvDanhSachKhachSC1.ForeColor = System.Drawing.Color.Transparent;
            this.labNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.labSDT.BackColor = System.Drawing.Color.Transparent;
            this.labSexual.BackColor = System.Drawing.Color.Transparent;
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
        }

        private void textIDCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

