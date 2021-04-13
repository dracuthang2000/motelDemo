﻿using System;
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
        Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2();
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
            this.check = check;
            datePickerCheckIn.Visible = false;
            datePickerCheckOut.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
        }
        public FormCustomer(String a,Boolean check)
        {
            InitializeComponent();
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
                MessageBox.Show("Nhap dung ID!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //String re = "[0-9]{9}";
            reg = new Regex(@"0[0-9]{9}");
            result = reg.Match(textSDT.Text);
            if (result.Length == 0 || textSDT.Text.Length > 10)
            {
                MessageBox.Show("Nhap dung so dien thoai!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if(check == false)
            {
                butUpdate.Text = "Update";
            }
            else
            {
                butUpdate.Text = "ADD";
            }
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
                datePickerCheckIn.Value = list[0].CheckInDate.GetValueOrDefault();
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
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                DialogResult result = MessageBox.Show("Ban co chac them khach co ID =" + textIDCus.Text + " khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
                if (catchData() == false) return;
                //int ID = int.Parse(la)
                var cus = (from Cus in data.CUSTOMERs
                           where Cus.IDCard.Equals(textIDCus.Text) && Cus.ID != this.IDcus
                           select Cus).ToList();
               // List<Model.CUSTOMER> list = (from b in data.CUSTOMERs where b.IDCard == textIDCus.Text select b).ToList();
                if (cus.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Ban co chac chinh sua khach co ID = " + textIDCus.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes: { updateData(); this.Close(); break; }
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
                    }
                    if (query.Count == 0)
                    {
                        var cus = (from Cus in data.CUSTOMERs
                                   where Cus.IDCard.Equals(textIDCus.Text)
                                   select Cus).ToList();
                        foreach (var Customer in cus)
                        {
                            textHoTen.Text = Customer.CustomerName;
                            textAddress.Text = Customer.Address;
                            textSDT.Text = Customer.NumberPhone;
                            datePickerBirth.Value = (DateTime)Customer.DateOfBirth;
                            comBoxSexual.Text = Customer.Sexual;


                            textHoTen.Enabled = false;
                            textAddress.Enabled = false;
                            textSDT.Enabled = false;
                            datePickerBirth.Enabled = false;
                            comBoxSexual.Enabled = false;
                        }
                    }
                }
                else if (textIDCus.Text.Length < 9)
                {

                    textHoTen.Enabled = true;
                    textAddress.Enabled = true;
                    textSDT.Enabled = true;
                    datePickerBirth.Enabled = true;
                    comBoxSexual.Enabled = true;

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

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

