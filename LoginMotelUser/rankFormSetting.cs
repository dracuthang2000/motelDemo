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
    public partial class rankFormSetting : Form
    {
        Model.MotelManagerEntities4 data = new Model.MotelManagerEntities4();
        public callFunction goiHam;
        private Boolean check;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
                goiHam();
        }
        public rankFormSetting(Boolean check)
        {
            InitializeComponent();
            if(check == true)
            {
                textPrice.Enabled = false;
                textDeposit.Enabled = false;
                textAbout.Enabled = false;
                buttonSave.Enabled = false;
            }
            this.check = check;
        }
        public rankFormSetting(String a,Boolean check)
        {
            InitializeComponent();
            this.labIDShow.Text = a;
            if (check == true)
            {
                textPrice.Enabled = false;
                textDeposit.Enabled = false;
                textAbout.Enabled = false;
                buttonSave.Enabled = false;
            }
            this.check = check;
            loadData(a);
        }
        public bool catchData()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPrice.Text, "[^0-9.]"))
            {
                MessageBox.Show("Type only number on price!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPrice.Text = "";
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textDeposit.Text, "[^0-9.]"))
            {
                MessageBox.Show("Type only number on Deposit!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDeposit.Text = "";
                return false;
            }
            return true;
        }
        public void loadData(String a)
        {


            Model.ROOMRANK c = data.ROOMRANKs.Find(int.Parse(a));
            textRankName.Text = c.RankName;
            textPrice.Text = c.Price.ToString();
            textDeposit.Text = c.Deposits.ToString();
            textAbout.Text = c.About;
            numericQuantity.Value = c.Quantity;

        }

        public void saveDate()
        {
            int Quantity = int.Parse(numericQuantity.Value.ToString());
            Model.ROOMRANK temp = new Model.ROOMRANK() { RankName = textRankName.Text, Price = int.Parse(textPrice.Text), Deposits = int.Parse(textDeposit.Text), About = textAbout.Text,Quantity = Quantity  };
            data.ROOMRANKs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            int Quantity = int.Parse(numericQuantity.Value.ToString());
            Model.ROOMRANK temp = data.ROOMRANKs.Find(int.Parse(labIDShow.Text));
            temp.RankName = textRankName.Text;
            decimal a = decimal.Parse(textPrice.Text);
            temp.Price = a;
            a = decimal.Parse(textDeposit.Text);
            temp.Deposits = a;
            temp.Quantity = Quantity;
            temp.About = textAbout.Text;

            data.SaveChanges();

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
          

        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textRankName_TextChanged(object sender, EventArgs e)
        {
            if(this.check == true)
            {
                var query = (from rank in data.ROOMRANKs
                            where rank.RankName.Equals(textRankName.Text)
                            select rank).ToList();
                if(query.Count == 0 && !(textRankName.Text.Trim().Equals("")))
                {
                    textPrice.Enabled = true;
                    textDeposit.Enabled = true;
                    textAbout.Enabled = true;
                    buttonSave.Enabled = true;

                    textPrice.Text = "";
                    textDeposit.Text = "";
                    textAbout.Text = "";
                    labIDShow.Text = "updating ....";
                }
                else
                {
                    textPrice.Enabled = false;
                    textDeposit.Enabled = false;
                    textAbout.Enabled = false;
                    buttonSave.Enabled = false;
                    if (textRankName.Text.Trim().Equals(""))
                    {
                        textPrice.Text = "";
                        textDeposit.Text = "";
                        textAbout.Text = "";
                        labIDShow.Text = "updating ....";
                    }
                    foreach (var rank in query)
                    {
                        textPrice.Text = rank.Price.ToString();
                        textDeposit.Text = rank.Deposits.ToString();
                        textAbout.Text = rank.About;
                        labIDShow.Text = rank.ID.ToString();
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                DialogResult result = MessageBox.Show("Are you sure Save Rank?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
                int ID = int.Parse(labIDShow.Text);
                var query = (from rank in data.ROOMRANKs
                             where rank.RankName.Equals(textRankName.Text) && rank.ID != ID
                             select rank).ToList();
                if (query.Count == 0)
                {

                    DialogResult result = MessageBox.Show("Are you sure update Rank ID = " + labIDShow.Text + " ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes: { updateData(); this.Close();
                                MessageBox.Show("COMPLETE!"); break;                               
                            }
                        case DialogResult.No: return;

                        default:
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("The Rank name is exist", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setColor()
        {
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labDeposit.BackColor = System.Drawing.Color.Transparent;
            this.labIDRank.BackColor = System.Drawing.Color.Transparent;
            this.labIDShow.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labRankName.BackColor = System.Drawing.Color.Transparent;
            this.GhiAbout.BackColor = System.Drawing.Color.Transparent;
        }


    }
}
