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
    public delegate void callFunction();
    public partial class AddRoomcs : Form
    {

        Model.MotelManagerEntities2 data = new Model.MotelManagerEntities2();
        private Boolean check;
        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
            {
                goiHam();
            }
        }
        public AddRoomcs(Boolean check)
        {
            InitializeComponent();
            this.check = check;
            loadComboBox();
            butUpdate.Text = "ADD";
            butUpdate.Enabled = false;
        }
        public AddRoomcs(String a, Boolean check)
        {
            InitializeComponent();
            this.check = check;
            loadComboBox();
            loadData(a);
            if (this.check == false)
            {

                butUpdate.Text = "Update";
                comBoxIDRange.Enabled = true;
                comBoxIDRank.Enabled = true;
            }
            else
            {
                butUpdate.Text = "ADD";
                comBoxIDRange.Enabled = false;
                comBoxIDRank.Enabled = false;
                butUpdate.Enabled = false;
            }
        }
        public bool catchData()
        {

            if (textRoomName.Text == "")
            {
                MessageBox.Show("Hay nhap ten phong!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comBoxIDRank.Text == "")
            {
                MessageBox.Show("Hay chon id loai!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comBoxIDRange.Text == "")
            {
                MessageBox.Show("Hay chon id khu vuc!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void loadComboBox()
        {
            List<Model.ROOMRANK> list1 = (from a in data.ROOMRANKs select a).ToList();
            List<Model.ROOMRANGE> list2 = (from b in data.ROOMRANGEs select b).ToList();
            comBoxIDRank.DataSource = list1;
            comBoxIDRank.DisplayMember = "RankName";
            comBoxIDRank.ValueMember = "ID";

            comBoxIDRange.DataSource = list2;
            comBoxIDRange.DisplayMember = "RangeName";
            comBoxIDRange.ValueMember = "ID";
        }
        public void loadData(String a)
        {
            Model.MOTELROOM c = data.MOTELROOMs.Find(int.Parse(a));
            labIDRoomShow.Text = c.ID.ToString();
            textRoomName.Text = c.RoomName;
            if (c.StateRoom.Value == 1)
            {
                labStateShow.Text = "phòng trống";
            }
            else if (c.StateRoom.Value == 2)
            {
                labStateShow.Text = "Còn chỗ";
            }
            else
            {
                labStateShow.Text = "Hết chỗ";
            }
            Model.ROOMRANK d = data.ROOMRANKs.Find(c.IDRoomRank);
            comBoxIDRank.Text = d.RankName;
            Model.ROOMRANGE b = data.ROOMRANGEs.Find(c.IDRoomRange);
            comBoxIDRange.Text = b.RangeName;
        }

        public void saveDate()
        {

            Model.MOTELROOM room = new Model.MOTELROOM() { RoomName = textRoomName.Text, StateRoom = 1, IDRoomRank = int.Parse(comBoxIDRank.SelectedValue.ToString()), IDRoomRange = int.Parse(comBoxIDRange.SelectedValue.ToString()) };
            data.MOTELROOMs.Add(room);
            data.SaveChanges();
        }
        public void updateData()
        {
            Model.MOTELROOM temp = data.MOTELROOMs.Find(int.Parse(labIDRoomShow.Text));
            temp.RoomName = textRoomName.Text;
            temp.IDRoomRank = int.Parse(comBoxIDRank.SelectedValue.ToString());
            temp.IDRoomRange = int.Parse(comBoxIDRange.SelectedValue.ToString());
            data.SaveChanges();

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                DialogResult result = MessageBox.Show("Ban co chac them phong co ID =" + labIDRoomShow.Text + " khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { saveDate(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }
            }
            else
            {
                if (catchData() == false) return;
                int ID = int.Parse(labIDRoomShow.Text);
                var query = (from room in data.MOTELROOMs
                             where room.RoomName.Equals(textRoomName.Text) && room.ID!=ID
                             select room).ToList();

                if (query.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Ban co chac chinh sua phong co ID = " + labIDRoomShow.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes: { updateData(); break; }
                        case DialogResult.No: return;

                        default:
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("Room Name is exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.Close();
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comBoxIDRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lableDefaultName.Text = comBoxIDRange.Text;
        }

        private void textRoomName_TextChanged(object sender, EventArgs e)
        {
            if (check == true)
            {
                var query = (from room in data.MOTELROOMs
                             where room.RoomName.Equals(textRoomName.Text)
                             select room).ToList();
                textRoomName.Text.ToUpper();
                if (query.Count == 0)
                {
                    comBoxIDRange.Enabled = true;
                    comBoxIDRank.Enabled = true;
                    if (textRoomName.Text.Trim().Equals(""))
                        butUpdate.Enabled = false;
                    else
                        butUpdate.Enabled = true;


                    labIDRoomShow.Text = "Loading ....";
                    labStateShow.Text = "Loading....";
                }
                else
                {
                    comBoxIDRange.Enabled = false;
                    comBoxIDRank.Enabled = false;
                    butUpdate.Enabled = false;
                    var query1 = (from room in data.MOTELROOMs
                                  join rank in data.ROOMRANKs on room.IDRoomRank equals rank.ID
                                  join range in data.ROOMRANGEs on room.IDRoomRange equals range.ID
                                  where room.RoomName.Equals(textRoomName.Text)
                                  select new { rank.RankName, range.RangeName, room.ID, room.StateRoom }).ToList();
                    foreach (var select in query1)
                    {
                        comBoxIDRange.Text = select.RangeName;
                        comBoxIDRank.Text = select.RankName;
                        labIDRoomShow.Text = select.ID.ToString();
                        if (select.StateRoom.Value == 1)
                        {
                            labStateShow.Text = "phòng trống";
                        }
                        else if (select.StateRoom.Value == 2)
                        {
                            labStateShow.Text = "Còn chỗ";
                        }
                        else
                        {
                            labStateShow.Text = "Hết chỗ";
                        }
                    }
                }
            }
        }
    }
}
