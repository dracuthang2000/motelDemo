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
    public partial class createStaffForm : Form
    {
        Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2();
        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
                goiHam();
        }
        public createStaffForm()
        {
            InitializeComponent();
        }

        public createStaffForm(String a)
        {
            InitializeComponent();
            this.textIDStaff.Text = a;
            loadData(a);
        }
        public bool catchData()
        {
            textIDStaff.Text = textIDStaff.Text.Trim();
            textSDT.Text = textSDT.Text.Trim();
            Regex reg = new Regex(@"[0-9]{9}");
            Match result = reg.Match(textIDStaff.Text);
            if (result.Length == 0 || textSDT.Text.Length > 10)
            {
                MessageBox.Show("Nhap dung ID!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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


            temp = textUserName.Text;
            temp = temp.Trim();
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " "); ;
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
            textUserName.Text = temp;

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
            var Tempstaff = from staff in data.STAFFs
                            where staff.IDCard.Equals(a)
                            select staff;
            foreach (var staff in Tempstaff)
            {
                textIDStaff.Text = staff.IDCard;
                textHoTen.Text = staff.StaffName;
                textAddress.Text = staff.Address;
                textSDT.Text = staff.NumberPhone.ToString();
                textUserName.Text = staff.UserName.ToString();
                comBoxSexual.Text = staff.Sexual.ToString();
                datePickerBirth.Value = staff.DateOfBirth.GetValueOrDefault();
            }
        }

        public void saveDate()
        {

            //Model.STAFF staff = new Model.STAFF() { ID = textIDStaff.Text, StaffName = textHoTen.Text, DateOfBirth = datePickerBirth.Value, Address = textAddress.Text, NumberPhone = textSDT.Text,UserName=textUserName.Text, Sexual = comBoxSexual.Text };
            //data.STAFFs.Add(staff);
            //data.SaveChanges();
            ////Model.USER user = new Model.USER() { UserName = textUserName.Text, Password = "",IDRole=2};
            //data.USERs.Add(user);
            //data.SaveChanges();

        }
        public void updateData()
        {
            Model.STAFF temp = data.STAFFs.Find(textIDStaff.Text);
            temp.StaffName = textHoTen.Text;
            temp.DateOfBirth = datePickerBirth.Value;
            temp.Address = textAddress.Text;
            temp.NumberPhone = textSDT.Text;
            temp.UserName = textUserName.Text;
            temp.Sexual = comBoxSexual.Text;
            data.SaveChanges();

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            //if (catchData() == false) return;
            //List<Model.STAFF> list = (from b in data.STAFFs where b.ID == textIDStaff.Text select b).ToList();
            //if (list.Count > 0)
            //{
            //    DialogResult result = MessageBox.Show("Ban co chac chinh sua quan ly co ID = " + textIDStaff.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //    switch (result)
            //    {
            //        case DialogResult.Cancel: return;
            //        case DialogResult.Yes: { updateData(); this.Close(); break; }
            //        case DialogResult.No: return;

            //        default:
            //            break;

            //    }

            //}
            //else
            //{
            //    DialogResult result = MessageBox.Show("Ban co chac them quan ly co ID =" + textIDStaff.Text + " khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //    switch (result)
            //    {
            //        case DialogResult.Cancel: return;
            //        case DialogResult.Yes: { saveDate(); this.Close(); break; }
            //        case DialogResult.No: return;

            //        default:
            //            break;

            //    }

            //}
            //this.Close();

        }



        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
