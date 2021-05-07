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
    public partial class AddParticularServiceForm : Form
    {
        int IDcheck;
        public AddParticularServiceForm(String idRoom)
        {
            InitializeComponent();
            setColor();
            createNewList();
            IDcheck = int.Parse(idRoom);
        }
        private ListView listViewback;
        public AddParticularServiceForm(ListView list, String idRoom)
        {
            InitializeComponent();
            listViewback = new ListView();
            foreach (ListViewItem listv in list.Items)
            {
                ListViewItem listb = new ListViewItem(listv.SubItems[0].Text);
                listb.SubItems.Add(listv.SubItems[1].Text);
                listb.SubItems.Add(listv.SubItems[2].Text);
                listb.SubItems.Add(listv.SubItems[3].Text);
                listb.SubItems.Add(listv.SubItems[4].Text);
                listViewback.Items.Add(listb);
            }
            createbackList();
            IDcheck = int.Parse(idRoom);
        }
        public String IDlist = "";
        public String Pricelist = "";
        public String serviceName = "";
        Model.MotelManagerEntities3 db = new Model.MotelManagerEntities3();
        public void createNewList()
        {

            var query = from Ser in db.SERVICEs
                        select Ser;
            foreach (var service in query)
            {
                ListViewItem list = new ListViewItem(service.ID.ToString());
                list.SubItems.Add(service.ServiceName);
                list.SubItems.Add(service.Price.ToString());
                listService.Items.Add(list);
            }
        }

        public void createbackList()
        {
            listService.Items.Clear();

            var query = from Ser in db.SERVICEs
                        select Ser;
            foreach (var service in query)
            {
                int IDser = service.ID;
                bool check = false;
                foreach (ListViewItem listv in listViewback.Items)
                {
                    if (listv.SubItems[0].Text.Trim().Equals(IDser.ToString()))
                    {
                        check = true;
                    }
                }
                if (check == false)
                {
                    ListViewItem list = new ListViewItem(IDser.ToString());
                    list.SubItems.Add(service.ServiceName);
                    list.SubItems.Add(service.Price.ToString());
                    listService.Items.Add(list);
                }
            }


            foreach (ListViewItem listv in listViewback.Items)
            {
                ListViewItem listb = new ListViewItem(listv.SubItems[0].Text);
                listb.SubItems.Add(listv.SubItems[1].Text);
                listb.SubItems.Add(listv.SubItems[2].Text);
                listb.SubItems.Add(listv.SubItems[3].Text);
                listb.SubItems.Add(listv.SubItems[4].Text);
                listServicePar.Items.Add(listb);
            }
        }

        public void loadOldindex(int idServiceTemp)
        {
            var query = db.getMaxdate(IDcheck).ToList();
            if (query.Count == 0)
            {
                textOldIndex.Text = "0";
            }
            else
            {
                foreach (var id in query)
                {
                    int idBillTemp = id.Value; ;
                    var index = (from parSer in db.PARTICULARSERVICEs
                                 where parSer.IDBill == idBillTemp && parSer.IDService == idServiceTemp
                                 select parSer).ToList();
                    if (index.Count == 0)
                    {
                        textOldIndex.Text = "0";
                    }
                    else
                    {
                        foreach (var oldindex in index)
                        {
                            textOldIndex.Text = oldindex.NewIndex.ToString();
                        }
                    }
                }
            }
        }
        public ListView listServiceChoose()
        {
            ListView listView = new ListView();
            foreach (ListViewItem l in listServicePar.Items)
            {
                ListViewItem list = new ListViewItem(l.SubItems[0].Text);
                list.SubItems.Add(l.SubItems[1].Text);
                list.SubItems.Add(l.SubItems[2].Text);
                list.SubItems.Add(l.SubItems[3].Text);
                list.SubItems.Add(l.SubItems[4].Text);
                listView.Items.Add(list);
            }
            return listView;
        }
        private void listService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listService.SelectedItems.Count > 0)
            {
                IDlist = (listService.SelectedItems[0].Text);
                textServiceName.Text = listService.SelectedItems[0].SubItems[1].Text;
                Pricelist = listService.SelectedItems[0].SubItems[2].Text;
                loadOldindex(int.Parse(IDlist));
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (!textIndex.Text.Trim().Equals("") || !textOldIndex.Text.Trim().Equals(""))
            {
                if (int.Parse(textOldIndex.Text) <= int.Parse(textIndex.Text))
                {
                    if (int.Parse(textOldIndex.Text) == 0)
                    {
                        Decimal price = int.Parse(textIndex.Text) * Decimal.Parse(Pricelist);
                        ListViewItem list = new ListViewItem(IDlist);
                        list.SubItems.Add(textServiceName.Text);
                        list.SubItems.Add(textIndex.Text);
                        list.SubItems.Add(textOldIndex.Text);
                        list.SubItems.Add(price.ToString());
                        listServicePar.Items.Add(list);
                    }
                    else if (int.Parse(textIndex.Text) < 5)
                    {
                        Decimal price = int.Parse(textIndex.Text) * Decimal.Parse(Pricelist);
                        ListViewItem list = new ListViewItem(IDlist);
                        list.SubItems.Add(textServiceName.Text);
                        list.SubItems.Add(textIndex.Text);
                        list.SubItems.Add(textOldIndex.Text);
                        list.SubItems.Add(price.ToString());
                        listServicePar.Items.Add(list);
                    }
                    else
                    {
                        Decimal price = (int.Parse(textIndex.Text) - int.Parse(textOldIndex.Text)) * Decimal.Parse(Pricelist);
                        ListViewItem list = new ListViewItem(IDlist);
                        list.SubItems.Add(textServiceName.Text);
                        list.SubItems.Add(textIndex.Text);
                        list.SubItems.Add(textOldIndex.Text);
                        list.SubItems.Add(price.ToString());
                        listServicePar.Items.Add(list);
                    }

                    textServiceName.Text = "";
                    textOldIndex.Text = "";
                    textIndex.Text = "";
                    for (int i = listService.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        if (listService.SelectedItems[i].Text.Equals(IDlist))
                            listService.Items.RemoveAt(listService.SelectedIndices[i]);
                    }
                }
                else
                {
                    MessageBox.Show("New index: " + textIndex + " < " + textOldIndex.Text + " Old index", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("You need choose ID Service to add", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void listServicePar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listServicePar.SelectedItems.Count > 0)
            {
                IDlist = listServicePar.SelectedItems[0].Text;
                serviceName = listServicePar.SelectedItems[0].SubItems[1].Text;
                if (int.Parse(listServicePar.SelectedItems[0].SubItems[3].Text) > 6)
                {
                    Pricelist = (Decimal.Parse(listServicePar.SelectedItems[0].SubItems[4].Text) /
                        (int.Parse(listServicePar.SelectedItems[0].SubItems[2].Text) -
                        int.Parse(listServicePar.SelectedItems[0].SubItems[3].Text))).ToString();
                }
                else
                {
                    Pricelist = (Decimal.Parse(listServicePar.SelectedItems[0].SubItems[4].Text) /
                             (int.Parse(listServicePar.SelectedItems[0].SubItems[2].Text))).ToString();
                }
            }
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (!IDlist.Trim().Equals("") && !serviceName.Trim().Equals(""))
            {
                for (int i = listServicePar.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    if (listServicePar.SelectedItems[i].Text.Equals(IDlist))
                        listServicePar.Items.RemoveAt(listServicePar.SelectedIndices[i]);

                }

                ListViewItem list = new ListViewItem(IDlist);
                list.SubItems.Add(serviceName);
                list.SubItems.Add(Pricelist);
                listService.Items.Add(list);

                IDlist = "";
                Pricelist = "";
                serviceName = "";
            }
            else
            {
                MessageBox.Show("You need choose ID Service to remove", "WARING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            listServiceChoose();
            this.Close();
        }

        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
