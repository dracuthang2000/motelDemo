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

        Model.MotelManagerEntities data = new Model.MotelManagerEntities();

        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
            {
                goiHam();
            }
        }
        public AddRoomcs()
        {
            InitializeComponent();
            loadComboBox();
        }
        public AddRoomcs(String a)
        {
            InitializeComponent();
            loadComboBox();
            loadData(a);

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
            foreach (Model.ROOMRANK a in list1)
            {
                comBoxIDRank.Items.Add(a.ID.ToString());
            }
            foreach (Model.ROOMRANGE a in list2)
            {
                comBoxIDRange.Items.Add(a.ID.ToString());
            }
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
            else if(c.StateRoom.Value == 2)
            {
                labStateShow.Text = "Còn chỗ";
            }
            else
            {
                labStateShow.Text = "Hết chỗ";
            }
            comBoxIDRank.Text = c.IDRoomRank.ToString();
            Model.ROOMRANK d = data.ROOMRANKs.Find(c.IDRoomRank);
            textRankName.Text = d.RankName;
            comBoxIDRange.Text = c.IDRoomRange.ToString();
            Model.ROOMRANGE b = data.ROOMRANGEs.Find(c.IDRoomRange);
            textRangeName.Text = b.RangeName;

        }

        public void saveDate()
        {

            Model.MOTELROOM room = new Model.MOTELROOM() { RoomName = textRoomName.Text, StateRoom = 3, IDRoomRank = int.Parse(comBoxIDRank.Text), IDRoomRange = int.Parse(comBoxIDRange.Text) };
            data.MOTELROOMs.Add(room);
            data.SaveChanges();
        }
        public void updateData()
        {
            Model.MOTELROOM temp = data.MOTELROOMs.Find(int.Parse(labIDRoomShow.Text));
            temp.RoomName = textRoomName.Text;
            temp.IDRoomRank = int.Parse(comBoxIDRank.Text);
            temp.IDRoomRange = int.Parse(comBoxIDRange.Text);

            data.SaveChanges();

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (catchData() == false) return;

            if (labIDRoomShow.Text != "loading")
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

            this.Close();
        }



        private void roomOpenForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void comBoxIDRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.ROOMRANK d = data.ROOMRANKs.Find(int.Parse(comBoxIDRank.Text));
            textRankName.Text = d.RankName;
        }

        private void comBoxIDRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.ROOMRANGE d = data.ROOMRANGEs.Find(int.Parse(comBoxIDRange.Text));
            textRangeName.Text = d.RangeName;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
