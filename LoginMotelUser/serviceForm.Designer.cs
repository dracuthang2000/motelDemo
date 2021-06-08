namespace LoginMotelUser
{
    partial class serviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceForm));
            this.panService = new System.Windows.Forms.Panel();
            this.labPage = new System.Windows.Forms.Label();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.listService = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.textIDService = new System.Windows.Forms.TextBox();
            this.labServiceName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.buttonSave = new ePOSOne.btnProduct.Button_WOC();
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
            this.viewReninformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panService.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panService
            // 
            this.panService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panService.BackgroundImage")));
            this.panService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panService.Controls.Add(this.labPage);
            this.panService.Controls.Add(this.butRight);
            this.panService.Controls.Add(this.butLeft);
            this.panService.Controls.Add(this.listService);
            this.panService.Controls.Add(this.labTieuDe);
            this.panService.Location = new System.Drawing.Point(487, 72);
            this.panService.Name = "panService";
            this.panService.Size = new System.Drawing.Size(429, 548);
            this.panService.TabIndex = 1;
            // 
            // labPage
            // 
            this.labPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(175, 518);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(65, 17);
            this.labPage.TabIndex = 12;
            this.labPage.Text = "Page 0/0";
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(323, 513);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 2;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(26, 513);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 1;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // listService
            // 
            this.listService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listService.FullRowSelect = true;
            this.listService.GridLines = true;
            this.listService.HideSelection = false;
            this.listService.Location = new System.Drawing.Point(26, 67);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(372, 440);
            this.listService.TabIndex = 0;
            this.listService.UseCompatibleStateImageBehavior = false;
            this.listService.View = System.Windows.Forms.View.Details;
            this.listService.SelectedIndexChanged += new System.EventHandler(this.listService_SelectedIndexChanged);
            // 
            // labTieuDe
            // 
            this.labTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(31, 22);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(358, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "SERVICE INFORMATION";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(177, 55);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(167, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(3, 60);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(61, 17);
            this.labSearch.TabIndex = 8;
            this.labSearch.Text = "Search: ";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(177, 232);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(167, 22);
            this.textPrice.TabIndex = 6;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(3, 232);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(48, 17);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "Price :";
            // 
            // textServiceName
            // 
            this.textServiceName.Location = new System.Drawing.Point(177, 141);
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.Size = new System.Drawing.Size(167, 22);
            this.textServiceName.TabIndex = 5;
            this.textServiceName.TextChanged += new System.EventHandler(this.textServiceName_TextChanged);
            // 
            // textIDService
            // 
            this.textIDService.Enabled = false;
            this.textIDService.Location = new System.Drawing.Point(177, 96);
            this.textIDService.Name = "textIDService";
            this.textIDService.Size = new System.Drawing.Size(167, 22);
            this.textIDService.TabIndex = 4;
            // 
            // labServiceName
            // 
            this.labServiceName.AutoSize = true;
            this.labServiceName.Location = new System.Drawing.Point(3, 146);
            this.labServiceName.Name = "labServiceName";
            this.labServiceName.Size = new System.Drawing.Size(94, 17);
            this.labServiceName.TabIndex = 3;
            this.labServiceName.Text = "Service name";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(3, 101);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(29, 17);
            this.labID.TabIndex = 2;
            this.labID.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.comboBoxUnit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.labSearch);
            this.panel1.Controls.Add(this.button_WOC1);
            this.panel1.Controls.Add(this.textIDService);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labID);
            this.panel1.Controls.Add(this.textServiceName);
            this.panel1.Controls.Add(this.labPrice);
            this.panel1.Controls.Add(this.textPrice);
            this.panel1.Controls.Add(this.labServiceName);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 548);
            this.panel1.TabIndex = 61;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "kilowat/h",
            "meter^3",
            "lan",
            "nguoi",
            "chiec",
            "phong"});
            this.comboBoxUnit.Location = new System.Drawing.Point(177, 277);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(167, 24);
            this.comboBoxUnit.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Unit";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.BorderColor = System.Drawing.Color.Silver;
            this.buttonClear.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(247, 489);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonClear.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonClear.Size = new System.Drawing.Size(103, 47);
            this.buttonClear.TabIndex = 60;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.TextColor = System.Drawing.Color.Black;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button_WOC2_Click);
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
            this.button_WOC1.Location = new System.Drawing.Point(127, 489);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(103, 47);
            this.button_WOC1.TabIndex = 59;
            this.button_WOC1.Text = "DELETE";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.BorderColor = System.Drawing.Color.Silver;
            this.buttonSave.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(6, 489);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonSave.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonSave.Size = new System.Drawing.Size(103, 47);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click_1);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click_1);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("roomToolStripMenuItem.Image")));
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click_1);
            // 
            // rankToolStripMenuItem
            // 
            this.rankToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rankToolStripMenuItem.Image")));
            this.rankToolStripMenuItem.Name = "rankToolStripMenuItem";
            this.rankToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.rankToolStripMenuItem.Text = "Rank";
            this.rankToolStripMenuItem.Click += new System.EventHandler(this.rankToolStripMenuItem_Click_1);
            // 
            // rangeToolStripMenuItem
            // 
            this.rangeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rangeToolStripMenuItem.Image")));
            this.rangeToolStripMenuItem.Name = "rangeToolStripMenuItem";
            this.rangeToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.rangeToolStripMenuItem.Text = "Range";
            this.rangeToolStripMenuItem.Click += new System.EventHandler(this.rangeToolStripMenuItem_Click_1);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceToolStripMenuItem.Image")));
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click_1);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripMenuItem.Image")));
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem1.Image")));
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem1.Image")));
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click_1);
            // 
            // roomToolStripMenuItem1
            // 
            this.roomToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("roomToolStripMenuItem1.Image")));
            this.roomToolStripMenuItem1.Name = "roomToolStripMenuItem1";
            this.roomToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.roomToolStripMenuItem1.Text = "Room";
            this.roomToolStripMenuItem1.Click += new System.EventHandler(this.roomToolStripMenuItem1_Click_1);
            // 
            // rankToolStripMenuItem1
            // 
            this.rankToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("rankToolStripMenuItem1.Image")));
            this.rankToolStripMenuItem1.Name = "rankToolStripMenuItem1";
            this.rankToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.rankToolStripMenuItem1.Text = "Rank";
            this.rankToolStripMenuItem1.Click += new System.EventHandler(this.rankToolStripMenuItem1_Click_1);
            // 
            // rangeToolStripMenuItem1
            // 
            this.rangeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("rangeToolStripMenuItem1.Image")));
            this.rangeToolStripMenuItem1.Name = "rangeToolStripMenuItem1";
            this.rangeToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.rangeToolStripMenuItem1.Text = "Range";
            this.rangeToolStripMenuItem1.Click += new System.EventHandler(this.rangeToolStripMenuItem1_Click);
            // 
            // serviceToolStripMenuItem1
            // 
            this.serviceToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("serviceToolStripMenuItem1.Image")));
            this.serviceToolStripMenuItem1.Name = "serviceToolStripMenuItem1";
            this.serviceToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
            this.serviceToolStripMenuItem1.Text = "Service";
            this.serviceToolStripMenuItem1.Click += new System.EventHandler(this.serviceToolStripMenuItem1_Click_1);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripMenuItem1.Image")));
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(155, 26);
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
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // recieptToolStripMenuItem
            // 
            this.recieptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recieptToolStripMenuItem.Image")));
            this.recieptToolStripMenuItem.Name = "recieptToolStripMenuItem";
            this.recieptToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.recieptToolStripMenuItem.Text = "Receipt";
            this.recieptToolStripMenuItem.Click += new System.EventHandler(this.recieptToolStripMenuItem_Click);
            // 
            // viewOldBillToolStripMenuItem
            // 
            this.viewOldBillToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewOldBillToolStripMenuItem.Image")));
            this.viewOldBillToolStripMenuItem.Name = "viewOldBillToolStripMenuItem";
            this.viewOldBillToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.viewOldBillToolStripMenuItem.Text = "View Bill";
            this.viewOldBillToolStripMenuItem.Click += new System.EventHandler(this.viewOldBillToolStripMenuItem_Click);
            // 
            // reinforToolStripMenuItem
            // 
            this.reinforToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checOutToolStripMenuItem,
            this.viewReninformationToolStripMenuItem});
            this.reinforToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reinforToolStripMenuItem.Image")));
            this.reinforToolStripMenuItem.Name = "reinforToolStripMenuItem";
            this.reinforToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.reinforToolStripMenuItem.Text = "Reinfor";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkInToolStripMenuItem.Image")));
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click_1);
            // 
            // checOutToolStripMenuItem
            // 
            this.checOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checOutToolStripMenuItem.Image")));
            this.checOutToolStripMenuItem.Name = "checOutToolStripMenuItem";
            this.checOutToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.checOutToolStripMenuItem.Text = "Check out";
            this.checOutToolStripMenuItem.Click += new System.EventHandler(this.checOutToolStripMenuItem_Click);
            // 
            // viewReninformationToolStripMenuItem
            // 
            this.viewReninformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewReninformationToolStripMenuItem.Image")));
            this.viewReninformationToolStripMenuItem.Name = "viewReninformationToolStripMenuItem";
            this.viewReninformationToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.viewReninformationToolStripMenuItem.Text = "View reninformation";
            this.viewReninformationToolStripMenuItem.Click += new System.EventHandler(this.viewReninformationToolStripMenuItem_Click);
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 620);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "serviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.panService.ResumeLayout(false);
            this.panService.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panService;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox textServiceName;
        private System.Windows.Forms.TextBox textIDService;
        private System.Windows.Forms.Label labServiceName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.ListView listService;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Label labPage;
        private ePOSOne.btnProduct.Button_WOC buttonClear;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC buttonSave;
        private System.Windows.Forms.Panel panel1;

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.ToolStripMenuItem viewReninformationToolStripMenuItem;
    }
}