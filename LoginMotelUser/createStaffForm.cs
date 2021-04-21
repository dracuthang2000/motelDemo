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
        private int IDStaff;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
                goiHam();
        }
        private Boolean checkUpdate;
        public createStaffForm(Boolean checkUpdate)
        {
            InitializeComponent();
            setColor();
            this.checkUpdate = checkUpdate;
            this.checkEdit(checkUpdate);
        }

        public void checkEdit(Boolean check)
        {
            if (check == true)
            {
                textHoTen.Enabled = false;
                textSDT.Enabled = false;
                buttonChoose.Enabled = false;
                textAddress.Enabled = false;
                datePickerBirth.Enabled = false;
                comBoxSexual.Enabled = false;
                buttonSave.Enabled = false;

            }
            else
            {
                textHoTen.Enabled = true;
                textSDT.Enabled = true;
                buttonChoose.Enabled = true;
                textAddress.Enabled = true;
                datePickerBirth.Enabled = true;
                comBoxSexual.Enabled = true;
                buttonSave.Enabled = true;
            }
        }

        public createStaffForm(String a, Boolean checkUpdate)
        {
            InitializeComponent();
            setColor();
            this.textIDStaff.Text = a;
            loadData(a);
            this.checkEdit(checkUpdate);
            this.checkUpdate = checkUpdate;
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
                IDStaff = staff.ID;
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

            Model.STAFF staff = new Model.STAFF() { IDCard = textIDStaff.Text, StaffName = textHoTen.Text, DateOfBirth = datePickerBirth.Value, Address = textAddress.Text, NumberPhone = textSDT.Text, UserName = textUserName.Text, Sexual = comBoxSexual.Text };
            data.STAFFs.Add(staff);
            data.SaveChanges();
            ////Model.USER user = new Model.USER() { UserName = textUserName.Text, Password = "",IDRole=2};
            //data.USERs.Add(user);
            //data.SaveChanges();

        }
        public void updateData()
        {
            Model.STAFF temp = data.STAFFs.Find(IDStaff);
            temp.IDCard = textIDStaff.Text;
            temp.StaffName = textHoTen.Text;
            temp.DateOfBirth = datePickerBirth.Value;
            temp.Address = textAddress.Text;
            temp.NumberPhone = textSDT.Text;
            temp.UserName = textUserName.Text;
            temp.Sexual = comBoxSexual.Text;
            data.SaveChanges();

        }
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            chooseUserName ChooseUser = new chooseUserName();
            ChooseUser.ShowDialog();
            if (!ChooseUser.userName().Equals(""))
                textUserName.Text = ChooseUser.userName();
        }

        private void textIndex_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textIDStaff_KeyPress(object sender, KeyPressEventArgs e)
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

        public void clear()
        {
            textHoTen.Text = "";
            textSDT.Text = "";
            textUserName.Text = "";
            textAddress.Text = "";
            datePickerBirth.Value = DateTime.Now;
            comBoxSexual.Text = "";
        }
        private void textIDStaff_TextChanged(object sender, EventArgs e)
        {
            if (checkUpdate == true)
            {
                var staff = (from staffs in data.STAFFs
                             where staffs.IDCard.Equals(textIDStaff.Text)
                             select staffs).ToList();
                if (staff.Count == 0 && textIDStaff.Text.Length == 9)
                {
                    this.checkEdit(false);
                }
                else
                {
                    this.checkEdit(true);
                    if (textIDStaff.Text.Length == 9)
                    {
                        foreach (var Staffs in staff)
                        {
                            textHoTen.Text = Staffs.StaffName;
                            textSDT.Text = Staffs.NumberPhone;
                            textUserName.Text = Staffs.UserName;
                            textAddress.Text = Staffs.Address;
                            datePickerBirth.Value = Staffs.DateOfBirth.Value.Date;
                            comBoxSexual.Text = Staffs.Sexual;
                        }
                    }
                    else
                    {
                        this.clear();
                    }
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (catchData() == false) return;
            List<Model.STAFF> list = (from b in data.STAFFs where b.ID == IDStaff select b).ToList();
            if (checkUpdate == true)
            {
                DialogResult result = MessageBox.Show("Are you sure SAVE IDCard =" + textIDStaff.Text + "?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Yes: { saveDate(); this.Close(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }
            }
            else
            {
                if (list.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure SAVE IDCard = " + textIDStaff.Text + " ? (All date will be change!)", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Yes: { updateData(); this.Close(); break; }
                        case DialogResult.No: return;

                        default:
                            break;

                    }

                }
                else
                {

                }
            }
            this.Close();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.labNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.labHoTen.BackColor = System.Drawing.Color.Transparent;
            this.labDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.labIDStaff.BackColor = System.Drawing.Color.Transparent;
            this.labSDT.BackColor = System.Drawing.Color.Transparent;
            this.labSexual.BackColor = System.Drawing.Color.Transparent;
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labUserName.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
