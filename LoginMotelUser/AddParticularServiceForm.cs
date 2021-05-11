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
        String Unit;
        Boolean checkLogout;
        public AddParticularServiceForm(String idRoom)
        {
            InitializeComponent();
            setColor();
            createNewList();
            IDcheck = int.Parse(idRoom);
        }
        private ListView listViewback = new ListView();
        public AddParticularServiceForm(ListView list, String idRoom)
        {
            InitializeComponent();
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
        Model.MotelManagerEntities4 db = new Model.MotelManagerEntities4();
        public void createNewList()
        {

            var query = from Ser in db.SERVICEs
                        select Ser;
            foreach (var service in query)
            {
                ListViewItem list = new ListViewItem(service.ID.ToString());
                Double price = Double.Parse(service.Price.ToString().Replace(",", ""));
                list.SubItems.Add(service.ServiceName);
                list.SubItems.Add(price.ToString());
                list.SubItems.Add(service.Unit);
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
                    list.SubItems.Add(service.Unit);
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
            if (checkLogout == false) {
                
                return listViewback;
            }
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
                Unit = listService.SelectedItems[0].SubItems[3].Text;
                loadOldindex(int.Parse(IDlist));
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (!textIndex.Text.Trim().Equals("") && !textOldIndex.Text.Trim().Equals(""))
            {
                if ((int.Parse(textOldIndex.Text) <= int.Parse(textIndex.Text) && Unit.Equals("meter^3")) || (int.Parse(textOldIndex.Text) <= int.Parse(textIndex.Text) && Unit.Equals("kilowat/h")) || !Unit.Equals("kilowat/h") && !Unit.Equals("meter^3"))
                {
                    if (int.Parse(textOldIndex.Text) == 0)
                    {
                        Decimal price = int.Parse(textIndex.Text) * Decimal.Parse(Pricelist);
                        Double priceSer = Double.Parse(price.ToString().Replace(",", ""));
                        ListViewItem list = new ListViewItem(IDlist);
                        list.SubItems.Add(textServiceName.Text);
                        list.SubItems.Add(textIndex.Text);
                        list.SubItems.Add(textOldIndex.Text);
                        list.SubItems.Add(priceSer.ToString());
                        listServicePar.Items.Add(list);
                    }
                    else if (!Unit.Equals("kilowat/h") && !Unit.Equals("meter^3"))
                    {
                        Decimal price = int.Parse(textIndex.Text) * Decimal.Parse(Pricelist);
                        Double priceSer = Double.Parse(price.ToString().Replace(",", ""));
                        ListViewItem list = new ListViewItem(IDlist);
                        list.SubItems.Add(textServiceName.Text);
                        list.SubItems.Add(textIndex.Text);
                        list.SubItems.Add(textOldIndex.Text);
                        list.SubItems.Add(priceSer.ToString());
                        listServicePar.Items.Add(list);
                    }
                    else
                    {
                        Decimal price = (int.Parse(textIndex.Text) - int.Parse(textOldIndex.Text)) * Decimal.Parse(Pricelist);
                        Double priceSer = Double.Parse(price.ToString().Replace(",", ""));
                        ListViewItem list = new ListViewItem(IDlist);
                        list.SubItems.Add(textServiceName.Text);
                        list.SubItems.Add(textIndex.Text);
                        list.SubItems.Add(textOldIndex.Text);
                        list.SubItems.Add(priceSer.ToString());
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
                var price = (from service in db.SERVICEs
                             where service.ID.ToString() == IDlist
                             select service).ToList();
                Pricelist = price[0].Price.ToString();
                Unit = price[0].Unit;
                serviceName = price[0].ServiceName;
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
                Double priceSer = Double.Parse(Pricelist.Replace(",", ""));
                ListViewItem list = new ListViewItem(IDlist);
                list.SubItems.Add(serviceName);
                list.SubItems.Add(priceSer.ToString());
                list.SubItems.Add(Unit);
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
            checkLogout = true;
            this.Close();
        }

        public void setColor()
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
        }

        private void AddParticularServiceForm_Load(object sender, EventArgs e)
        {
            checkLogout = false;
        }
    }
}
