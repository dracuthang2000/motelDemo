namespace LoginMotelUser
{
    partial class showStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showStaffForm));
            this.panKhach = new System.Windows.Forms.Panel();
            this.buttonDelete = new ePOSOne.btnProduct.Button_WOC();
            this.buttonUp = new ePOSOne.btnProduct.Button_WOC();
            this.listStaff = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panKhach.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panKhach
            // 
            this.panKhach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panKhach.BackgroundImage")));
            this.panKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panKhach.Controls.Add(this.buttonDelete);
            this.panKhach.Controls.Add(this.buttonUp);
            this.panKhach.Controls.Add(this.listStaff);
            this.panKhach.Controls.Add(this.labTieuDe);
            this.panKhach.Location = new System.Drawing.Point(-2, -2);
            this.panKhach.Name = "panKhach";
            this.panKhach.Size = new System.Drawing.Size(977, 635);
            this.panKhach.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Peru;
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BorderColor = System.Drawing.Color.Silver;
            this.buttonDelete.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(680, 537);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextColor = System.Drawing.Color.Black;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.Peru;
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BorderColor = System.Drawing.Color.Silver;
            this.buttonUp.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(201, 537);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUp.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUp.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUp.Size = new System.Drawing.Size(80, 30);
            this.buttonUp.TabIndex = 19;
            this.buttonUp.Text = "...";
            this.buttonUp.TextColor = System.Drawing.Color.Black;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // listStaff
            // 
            this.listStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStaff.FullRowSelect = true;
            this.listStaff.GridLines = true;
            this.listStaff.HideSelection = false;
            this.listStaff.LabelEdit = true;
            this.listStaff.Location = new System.Drawing.Point(7, 79);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(957, 441);
            this.listStaff.TabIndex = 1;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            this.listStaff.View = System.Windows.Forms.View.Details;
            this.listStaff.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listStaff_ColumnClick);
            this.listStaff.DoubleClick += new System.EventHandler(this.listStaff_DoubleClick);
            this.listStaff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listStaff_MouseClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(389, 44);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(180, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "LIST STAFF";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.CheckOnClick = true;
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.iDToolStripMenuItem.Text = "ID";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.iDToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.CheckOnClick = true;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
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
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
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
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click_1);
            // 
            // checOutToolStripMenuItem
            // 
            this.checOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checOutToolStripMenuItem.Image")));
            this.checOutToolStripMenuItem.Name = "checOutToolStripMenuItem";
            this.checOutToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.checOutToolStripMenuItem.Text = "Check out";
            this.checOutToolStripMenuItem.Click += new System.EventHandler(this.checOutToolStripMenuItem_Click);
            // 
            // showStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 598);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panKhach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "showStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAFF";
            this.panKhach.ResumeLayout(false);
            this.panKhach.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panKhach;
        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC buttonUp;
        private ePOSOne.btnProduct.Button_WOC buttonDelete;

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