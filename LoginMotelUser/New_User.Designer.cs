namespace LoginMotelUser
{
    partial class New_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_User));
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.rOLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motelManagerDataSet = new LoginMotelUser.MotelManagerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.USERTableAdapter();
            this.rOLETableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.ROLETableAdapter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIn = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rankToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOldBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(103, 78);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(285, 24);
            this.textPassword.TabIndex = 0;
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(103, 27);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(285, 24);
            this.textUsername.TabIndex = 1;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.rOLEBindingSource1;
            this.roleComboBox.DisplayMember = "RoleName";
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(103, 129);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(148, 26);
            this.roleComboBox.TabIndex = 2;
            this.roleComboBox.ValueMember = "id";
            // 
            // rOLEBindingSource1
            // 
            this.rOLEBindingSource1.DataMember = "ROLE";
            this.rOLEBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // motelManagerDataSet
            // 
            this.motelManagerDataSet.DataSetName = "MotelManagerDataSet";
            this.motelManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(360, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "CREATE NEW USER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(452, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 406);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // uSERBindingSource1
            // 
            this.uSERBindingSource1.DataMember = "USER";
            this.uSERBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // uSERTableAdapter1
            // 
            this.uSERTableAdapter1.ClearBeforeFill = true;
            // 
            // rOLETableAdapter1
            // 
            this.rOLETableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(110, 30);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortToolStripMenuItem.Image")));
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // buttonIn
            // 
            this.buttonIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonIn.BorderColor = System.Drawing.Color.Silver;
            this.buttonIn.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonIn.FlatAppearance.BorderSize = 0;
            this.buttonIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.Location = new System.Drawing.Point(3, 376);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonIn.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonIn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonIn.Size = new System.Drawing.Size(80, 30);
            this.buttonIn.TabIndex = 21;
            this.buttonIn.Text = "SAVE";
            this.buttonIn.TextColor = System.Drawing.Color.Black;
            this.buttonIn.UseVisualStyleBackColor = false;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WOC1.BackColor = System.Drawing.SystemColors.Control;
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(321, 373);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(80, 30);
            this.button_WOC1.TabIndex = 22;
            this.button_WOC1.Text = "CANCLE";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.roleComboBox);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.button_WOC1);
            this.panel.Controls.Add(this.textPassword);
            this.panel.Controls.Add(this.buttonIn);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.textUsername);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(9, 87);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(404, 406);
            this.panel.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.billsToolStripMenuItem,
            this.reinforToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.rankToolStripMenuItem,
            this.rangeToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.staffToolStripMenuItem});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click_1);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click_1);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("roomToolStripMenuItem.Image")));
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click_1);
            // 
            // rankToolStripMenuItem
            // 
            this.rankToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rankToolStripMenuItem.Image")));
            this.rankToolStripMenuItem.Name = "rankToolStripMenuItem";
            this.rankToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rankToolStripMenuItem.Text = "Rank";
            this.rankToolStripMenuItem.Click += new System.EventHandler(this.rankToolStripMenuItem_Click_1);
            // 
            // rangeToolStripMenuItem
            // 
            this.rangeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rangeToolStripMenuItem.Image")));
            this.rangeToolStripMenuItem.Name = "rangeToolStripMenuItem";
            this.rangeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rangeToolStripMenuItem.Text = "Range";
            this.rangeToolStripMenuItem.Click += new System.EventHandler(this.rangeToolStripMenuItem_Click_1);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceToolStripMenuItem.Image")));
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click_1);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripMenuItem.Image")));
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Home";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem1,
            this.customerToolStripMenuItem1,
            this.roomToolStripMenuItem1,
            this.rankToolStripMenuItem1,
            this.rangeToolStripMenuItem1,
            this.serviceToolStripMenuItem1,
            this.staffToolStripMenuItem1});
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem1.Image")));
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem1.Image")));
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click_1);
            // 
            // roomToolStripMenuItem1
            // 
            this.roomToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("roomToolStripMenuItem1.Image")));
            this.roomToolStripMenuItem1.Name = "roomToolStripMenuItem1";
            this.roomToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.roomToolStripMenuItem1.Text = "Room";
            this.roomToolStripMenuItem1.Click += new System.EventHandler(this.roomToolStripMenuItem1_Click_1);
            // 
            // rankToolStripMenuItem1
            // 
            this.rankToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("rankToolStripMenuItem1.Image")));
            this.rankToolStripMenuItem1.Name = "rankToolStripMenuItem1";
            this.rankToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.rankToolStripMenuItem1.Text = "Rank";
            this.rankToolStripMenuItem1.Click += new System.EventHandler(this.rankToolStripMenuItem1_Click_1);
            // 
            // rangeToolStripMenuItem1
            // 
            this.rangeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("rangeToolStripMenuItem1.Image")));
            this.rangeToolStripMenuItem1.Name = "rangeToolStripMenuItem1";
            this.rangeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.rangeToolStripMenuItem1.Text = "Range";
            this.rangeToolStripMenuItem1.Click += new System.EventHandler(this.rangeToolStripMenuItem1_Click);
            // 
            // serviceToolStripMenuItem1
            // 
            this.serviceToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("serviceToolStripMenuItem1.Image")));
            this.serviceToolStripMenuItem1.Name = "serviceToolStripMenuItem1";
            this.serviceToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.serviceToolStripMenuItem1.Text = "Service";
            this.serviceToolStripMenuItem1.Click += new System.EventHandler(this.serviceToolStripMenuItem1_Click_1);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripMenuItem1.Image")));
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.staffToolStripMenuItem1.Text = "Staff";
            this.staffToolStripMenuItem1.Click += new System.EventHandler(this.staffToolStripMenuItem1_Click_1);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem,
            this.recieptToolStripMenuItem,
            this.viewOldBillToolStripMenuItem});
            this.billsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("billsToolStripMenuItem.Image")));
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.billsToolStripMenuItem.Text = "Bills";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // recieptToolStripMenuItem
            // 
            this.recieptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recieptToolStripMenuItem.Image")));
            this.recieptToolStripMenuItem.Name = "recieptToolStripMenuItem";
            this.recieptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recieptToolStripMenuItem.Text = "Receipt";
            this.recieptToolStripMenuItem.Click += new System.EventHandler(this.recieptToolStripMenuItem_Click);
            // 
            // viewOldBillToolStripMenuItem
            // 
            this.viewOldBillToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewOldBillToolStripMenuItem.Image")));
            this.viewOldBillToolStripMenuItem.Name = "viewOldBillToolStripMenuItem";
            this.viewOldBillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewOldBillToolStripMenuItem.Text = "View Bill";
            this.viewOldBillToolStripMenuItem.Click += new System.EventHandler(this.viewOldBillToolStripMenuItem_Click);
            // 
            // reinforToolStripMenuItem
            // 
            this.reinforToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checOutToolStripMenuItem});
            this.reinforToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reinforToolStripMenuItem.Image")));
            this.reinforToolStripMenuItem.Name = "reinforToolStripMenuItem";
            this.reinforToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.reinforToolStripMenuItem.Text = "Reinfor";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkInToolStripMenuItem.Image")));
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click_1);
            // 
            // checOutToolStripMenuItem
            // 
            this.checOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checOutToolStripMenuItem.Image")));
            this.checOutToolStripMenuItem.Name = "checOutToolStripMenuItem";
            this.checOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checOutToolStripMenuItem.Text = "Check out";
            this.checOutToolStripMenuItem.Click += new System.EventHandler(this.checOutToolStripMenuItem_Click);
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 495);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_User";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.New_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private MotelManagerDataSet motelManagerDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource1;
        private MotelManagerDataSetTableAdapters.USERTableAdapter uSERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource rOLEBindingSource1;
        private MotelManagerDataSetTableAdapters.ROLETableAdapter rOLETableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC buttonIn;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Panel panel;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recieptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOldBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinforToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rankToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rangeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
    }
}