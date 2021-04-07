namespace LoginMotelUser
{
    partial class Admin_Formcs
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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateuserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoaiPhongSC1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienCocSC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhongDaThueSC1 = new System.Windows.Forms.Label();
            this.lbPhongTrongSC1 = new System.Windows.Forms.Label();
            this.cbbDaySC1 = new System.Windows.Forms.ComboBox();
            this.txtTrangThaiSC1 = new System.Windows.Forms.TextBox();
            this.txtGiaPhongSC1 = new System.Windows.Forms.TextBox();
            this.txtDaySC1 = new System.Windows.Forms.TextBox();
            this.txtMaPhongSC1 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lvDanhSachKhachSC1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvDanhSachPhongSC1 = new System.Windows.Forms.TreeView();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "Password";
            this.PassWord.HeaderText = "Pass Word";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            this.PassWord.Width = 125;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Role";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 125;
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtUserMenuItem,
            this.insertCustomerMenuItem});
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newMenuItem.Text = "New";
            // 
            // newtUserMenuItem
            // 
            this.newtUserMenuItem.Name = "newtUserMenuItem";
            this.newtUserMenuItem.Size = new System.Drawing.Size(155, 26);
            this.newtUserMenuItem.Text = "Users";
            this.newtUserMenuItem.Click += new System.EventHandler(this.insertUserToolStripMenuItem_Click);
            // 
            // insertCustomerMenuItem
            // 
            this.insertCustomerMenuItem.Name = "insertCustomerMenuItem";
            this.insertCustomerMenuItem.Size = new System.Drawing.Size(155, 26);
            this.insertCustomerMenuItem.Text = "Customer";
            this.insertCustomerMenuItem.Click += new System.EventHandler(this.inserCustomerToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(122, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editMenuItem.Text = "Edit";
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateuserMenuItem});
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateMenuItem.Text = "Update";
            // 
            // updateuserMenuItem
            // 
            this.updateuserMenuItem.Name = "updateuserMenuItem";
            this.updateuserMenuItem.Size = new System.Drawing.Size(121, 26);
            this.updateuserMenuItem.Text = "User";
            this.updateuserMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1068, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.txtLoaiPhongSC1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTienCocSC1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbPhongDaThueSC1);
            this.panel2.Controls.Add(this.lbPhongTrongSC1);
            this.panel2.Controls.Add(this.cbbDaySC1);
            this.panel2.Controls.Add(this.txtTrangThaiSC1);
            this.panel2.Controls.Add(this.txtGiaPhongSC1);
            this.panel2.Controls.Add(this.txtDaySC1);
            this.panel2.Controls.Add(this.txtMaPhongSC1);
            this.panel2.Controls.Add(this.label47);
            this.panel2.Controls.Add(this.label46);
            this.panel2.Controls.Add(this.label45);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.lvDanhSachKhachSC1);
            this.panel2.Controls.Add(this.tvDanhSachPhongSC1);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 560);
            this.panel2.TabIndex = 2;
            // 
            // txtLoaiPhongSC1
            // 
            this.txtLoaiPhongSC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaiPhongSC1.Location = new System.Drawing.Point(889, 140);
            this.txtLoaiPhongSC1.Name = "txtLoaiPhongSC1";
            this.txtLoaiPhongSC1.ReadOnly = true;
            this.txtLoaiPhongSC1.Size = new System.Drawing.Size(145, 22);
            this.txtLoaiPhongSC1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Loại phòng";
            // 
            // txtTienCocSC1
            // 
            this.txtTienCocSC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienCocSC1.Location = new System.Drawing.Point(889, 196);
            this.txtTienCocSC1.Name = "txtTienCocSC1";
            this.txtTienCocSC1.ReadOnly = true;
            this.txtTienCocSC1.Size = new System.Drawing.Size(145, 22);
            this.txtTienCocSC1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tiền cọc";
            // 
            // lbPhongDaThueSC1
            // 
            this.lbPhongDaThueSC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhongDaThueSC1.AutoSize = true;
            this.lbPhongDaThueSC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongDaThueSC1.Location = new System.Drawing.Point(932, 471);
            this.lbPhongDaThueSC1.Name = "lbPhongDaThueSC1";
            this.lbPhongDaThueSC1.Size = new System.Drawing.Size(27, 20);
            this.lbPhongDaThueSC1.TabIndex = 20;
            this.lbPhongDaThueSC1.Text = "so";
            // 
            // lbPhongTrongSC1
            // 
            this.lbPhongTrongSC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhongTrongSC1.AutoSize = true;
            this.lbPhongTrongSC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongTrongSC1.Location = new System.Drawing.Point(932, 418);
            this.lbPhongTrongSC1.Name = "lbPhongTrongSC1";
            this.lbPhongTrongSC1.Size = new System.Drawing.Size(27, 20);
            this.lbPhongTrongSC1.TabIndex = 19;
            this.lbPhongTrongSC1.Text = "so";
            // 
            // cbbDaySC1
            // 
            this.cbbDaySC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDaySC1.FormattingEnabled = true;
            this.cbbDaySC1.Location = new System.Drawing.Point(889, 361);
            this.cbbDaySC1.Name = "cbbDaySC1";
            this.cbbDaySC1.Size = new System.Drawing.Size(159, 24);
            this.cbbDaySC1.TabIndex = 18;
            this.cbbDaySC1.SelectedIndexChanged += new System.EventHandler(this.cbbDaySC1_SelectedIndexChanged);
            // 
            // txtTrangThaiSC1
            // 
            this.txtTrangThaiSC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrangThaiSC1.Location = new System.Drawing.Point(889, 224);
            this.txtTrangThaiSC1.Name = "txtTrangThaiSC1";
            this.txtTrangThaiSC1.ReadOnly = true;
            this.txtTrangThaiSC1.Size = new System.Drawing.Size(145, 22);
            this.txtTrangThaiSC1.TabIndex = 17;
            // 
            // txtGiaPhongSC1
            // 
            this.txtGiaPhongSC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaPhongSC1.Location = new System.Drawing.Point(889, 168);
            this.txtGiaPhongSC1.Name = "txtGiaPhongSC1";
            this.txtGiaPhongSC1.ReadOnly = true;
            this.txtGiaPhongSC1.Size = new System.Drawing.Size(145, 22);
            this.txtGiaPhongSC1.TabIndex = 16;
            // 
            // txtDaySC1
            // 
            this.txtDaySC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDaySC1.Location = new System.Drawing.Point(889, 108);
            this.txtDaySC1.Name = "txtDaySC1";
            this.txtDaySC1.ReadOnly = true;
            this.txtDaySC1.Size = new System.Drawing.Size(145, 22);
            this.txtDaySC1.TabIndex = 15;
            // 
            // txtMaPhongSC1
            // 
            this.txtMaPhongSC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhongSC1.Location = new System.Drawing.Point(889, 80);
            this.txtMaPhongSC1.Name = "txtMaPhongSC1";
            this.txtMaPhongSC1.ReadOnly = true;
            this.txtMaPhongSC1.Size = new System.Drawing.Size(145, 22);
            this.txtMaPhongSC1.TabIndex = 14;
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(767, 170);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(85, 20);
            this.label47.TabIndex = 13;
            this.label47.Text = "Giá phòng";
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(766, 471);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(139, 20);
            this.label46.TabIndex = 12;
            this.label46.Text = "Số phòng đã thuê";
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(766, 418);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(122, 20);
            this.label45.TabIndex = 11;
            this.label45.Text = "Số phòng trống";
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(766, 361);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(39, 20);
            this.label44.TabIndex = 10;
            this.label44.Text = "Dãy";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(767, 226);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 20);
            this.label42.TabIndex = 8;
            this.label42.Text = "Trạng thái";
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(767, 108);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(39, 20);
            this.label41.TabIndex = 7;
            this.label41.Text = "Dãy";
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(766, 82);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 20);
            this.label40.TabIndex = 6;
            this.label40.Text = "Mã phòng";
            // 
            // lvDanhSachKhachSC1
            // 
            this.lvDanhSachKhachSC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDanhSachKhachSC1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvDanhSachKhachSC1.HideSelection = false;
            this.lvDanhSachKhachSC1.Location = new System.Drawing.Point(3, 337);
            this.lvDanhSachKhachSC1.Name = "lvDanhSachKhachSC1";
            this.lvDanhSachKhachSC1.Size = new System.Drawing.Size(709, 217);
            this.lvDanhSachKhachSC1.TabIndex = 5;
            this.lvDanhSachKhachSC1.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachKhachSC1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CMND";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quê quán";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SDT";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giới tính";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // tvDanhSachPhongSC1
            // 
            this.tvDanhSachPhongSC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDanhSachPhongSC1.Location = new System.Drawing.Point(16, 82);
            this.tvDanhSachPhongSC1.Name = "tvDanhSachPhongSC1";
            this.tvDanhSachPhongSC1.Size = new System.Drawing.Size(444, 178);
            this.tvDanhSachPhongSC1.TabIndex = 4;
            this.tvDanhSachPhongSC1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDanhSachPhongSC1_AfterSelect_1);
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(797, 307);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 25);
            this.label39.TabIndex = 3;
            this.label39.Text = "thong ke";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(797, 50);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(174, 25);
            this.label38.TabIndex = 2;
            this.label38.Text = "Thông tin cơ bản";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(136, 297);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(176, 25);
            this.label37.TabIndex = 1;
            this.label37.Text = "danh sach khach";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(109, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(181, 25);
            this.label36.TabIndex = 0;
            this.label36.Text = "Danh sách phòng";
            // 
            // Admin_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1068, 557);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Formcs";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateuserMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;


        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPhongDaThueSC1;
        private System.Windows.Forms.Label lbPhongTrongSC1;
        private System.Windows.Forms.ComboBox cbbDaySC1;
        private System.Windows.Forms.TextBox txtTrangThaiSC1;
        private System.Windows.Forms.TextBox txtGiaPhongSC1;
        private System.Windows.Forms.TextBox txtDaySC1;
        private System.Windows.Forms.TextBox txtMaPhongSC1;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ListView lvDanhSachKhachSC1;
        private System.Windows.Forms.TreeView tvDanhSachPhongSC1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtLoaiPhongSC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTienCocSC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}