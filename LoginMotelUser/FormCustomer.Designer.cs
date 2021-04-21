namespace LoginMotelUser
{
    partial class FormCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panGuestOpen = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIDCus = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            this.datePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.datePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.datePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.comBoxSexual = new System.Windows.Forms.ComboBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.labIDRoomShow = new System.Windows.Forms.Label();
            this.labCOD = new System.Windows.Forms.Label();
            this.labCID = new System.Windows.Forms.Label();
            this.labIDRoom = new System.Windows.Forms.Label();
            this.labSexual = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labIDCus = new System.Windows.Forms.Label();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panGuestOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGuestOpen
            // 
            this.panGuestOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGuestOpen.Controls.Add(this.butExit);
            this.panGuestOpen.Controls.Add(this.label2);
            this.panGuestOpen.Controls.Add(this.label1);
            this.panGuestOpen.Controls.Add(this.textIDCus);
            this.panGuestOpen.Controls.Add(this.butUpdate);
            this.panGuestOpen.Controls.Add(this.datePickerCheckOut);
            this.panGuestOpen.Controls.Add(this.datePickerCheckIn);
            this.panGuestOpen.Controls.Add(this.datePickerBirth);
            this.panGuestOpen.Controls.Add(this.comBoxSexual);
            this.panGuestOpen.Controls.Add(this.textSDT);
            this.panGuestOpen.Controls.Add(this.textAddress);
            this.panGuestOpen.Controls.Add(this.textHoTen);
            this.panGuestOpen.Controls.Add(this.labIDRoomShow);
            this.panGuestOpen.Controls.Add(this.labCOD);
            this.panGuestOpen.Controls.Add(this.labCID);
            this.panGuestOpen.Controls.Add(this.labIDRoom);
            this.panGuestOpen.Controls.Add(this.labSexual);
            this.panGuestOpen.Controls.Add(this.labSDT);
            this.panGuestOpen.Controls.Add(this.labDiaChi);
            this.panGuestOpen.Controls.Add(this.labNgaySinh);
            this.panGuestOpen.Controls.Add(this.labHoTen);
            this.panGuestOpen.Controls.Add(this.labIDCus);
            this.panGuestOpen.Controls.Add(this.labTieuDe);
            this.panGuestOpen.Location = new System.Drawing.Point(2, 3);
            this.panGuestOpen.Name = "panGuestOpen";
            this.panGuestOpen.Size = new System.Drawing.Size(941, 688);
            this.panGuestOpen.TabIndex = 0;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(478, 487);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(141, 70);
            this.butExit.TabIndex = 15;
            this.butExit.Text = "THOÁT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "update....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "update....";
            // 
            // textIDCus
            // 
            this.textIDCus.Location = new System.Drawing.Point(187, 79);
            this.textIDCus.MaxLength = 9;
            this.textIDCus.Name = "textIDCus";
            this.textIDCus.Size = new System.Drawing.Size(221, 22);
            this.textIDCus.TabIndex = 0;
            this.textIDCus.TextChanged += new System.EventHandler(this.textIDCus_TextChanged);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(267, 487);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(141, 70);
            this.butUpdate.TabIndex = 8;
            this.butUpdate.Text = "Cập Nhật";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // datePickerCheckOut
            // 
            this.datePickerCheckOut.Enabled = false;
            this.datePickerCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerCheckOut.Location = new System.Drawing.Point(654, 396);
            this.datePickerCheckOut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerCheckOut.Name = "datePickerCheckOut";
            this.datePickerCheckOut.Size = new System.Drawing.Size(200, 22);
            this.datePickerCheckOut.TabIndex = 7;
            this.datePickerCheckOut.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // datePickerCheckIn
            // 
            this.datePickerCheckIn.Enabled = false;
            this.datePickerCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerCheckIn.Location = new System.Drawing.Point(187, 396);
            this.datePickerCheckIn.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerCheckIn.Name = "datePickerCheckIn";
            this.datePickerCheckIn.Size = new System.Drawing.Size(200, 22);
            this.datePickerCheckIn.TabIndex = 6;
            this.datePickerCheckIn.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // datePickerBirth
            // 
            this.datePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerBirth.Location = new System.Drawing.Point(654, 136);
            this.datePickerBirth.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.datePickerBirth.Name = "datePickerBirth";
            this.datePickerBirth.Size = new System.Drawing.Size(200, 22);
            this.datePickerBirth.TabIndex = 2;
            this.datePickerBirth.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // comBoxSexual
            // 
            this.comBoxSexual.AllowDrop = true;
            this.comBoxSexual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comBoxSexual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comBoxSexual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSexual.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comBoxSexual.Location = new System.Drawing.Point(654, 263);
            this.comBoxSexual.Name = "comBoxSexual";
            this.comBoxSexual.Size = new System.Drawing.Size(121, 24);
            this.comBoxSexual.Sorted = true;
            this.comBoxSexual.TabIndex = 5;
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(187, 263);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(326, 22);
            this.textSDT.TabIndex = 4;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(187, 203);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(667, 22);
            this.textAddress.TabIndex = 3;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(187, 138);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(326, 22);
            this.textHoTen.TabIndex = 1;
            // 
            // labIDRoomShow
            // 
            this.labIDRoomShow.AutoSize = true;
            this.labIDRoomShow.Location = new System.Drawing.Point(184, 332);
            this.labIDRoomShow.Name = "labIDRoomShow";
            this.labIDRoomShow.Size = new System.Drawing.Size(68, 17);
            this.labIDRoomShow.TabIndex = 12;
            this.labIDRoomShow.Text = "update....";
            // 
            // labCOD
            // 
            this.labCOD.AutoSize = true;
            this.labCOD.Location = new System.Drawing.Point(538, 401);
            this.labCOD.Name = "labCOD";
            this.labCOD.Size = new System.Drawing.Size(108, 17);
            this.labCOD.TabIndex = 9;
            this.labCOD.Text = "CheckOutDate :";
            // 
            // labCID
            // 
            this.labCID.AutoSize = true;
            this.labCID.Location = new System.Drawing.Point(51, 401);
            this.labCID.Name = "labCID";
            this.labCID.Size = new System.Drawing.Size(96, 17);
            this.labCID.TabIndex = 8;
            this.labCID.Text = "CheckInDate :";
            // 
            // labIDRoom
            // 
            this.labIDRoom.AutoSize = true;
            this.labIDRoom.Location = new System.Drawing.Point(51, 332);
            this.labIDRoom.Name = "labIDRoom";
            this.labIDRoom.Size = new System.Drawing.Size(94, 17);
            this.labIDRoom.TabIndex = 7;
            this.labIDRoom.Text = "Room Name :";
            // 
            // labSexual
            // 
            this.labSexual.AutoSize = true;
            this.labSexual.Location = new System.Drawing.Point(538, 266);
            this.labSexual.Name = "labSexual";
            this.labSexual.Size = new System.Drawing.Size(73, 17);
            this.labSexual.TabIndex = 6;
            this.labSexual.Text = "Giới Tính :";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(51, 266);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(106, 17);
            this.labSDT.TabIndex = 5;
            this.labSDT.Text = "Số Điện Thoại :";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(51, 208);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(61, 17);
            this.labDiaChi.TabIndex = 4;
            this.labDiaChi.Text = "Địa Chỉ :";
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Location = new System.Drawing.Point(538, 141);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(81, 17);
            this.labNgaySinh.TabIndex = 3;
            this.labNgaySinh.Text = "Ngày Sinh :";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(51, 141);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(63, 17);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "Họ Tên :";
            // 
            // labIDCus
            // 
            this.labIDCus.AutoSize = true;
            this.labIDCus.Location = new System.Drawing.Point(51, 82);
            this.labIDCus.Name = "labIDCus";
            this.labIDCus.Size = new System.Drawing.Size(73, 17);
            this.labIDCus.TabIndex = 1;
            this.labIDCus.Text = "ID Khách :";
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(318, 0);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(293, 33);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "THÔNG TIN KHÁCH TRỌ";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 693);
            this.Controls.Add(this.panGuestOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustomer";
            this.Text = "CUSTOMER";
            this.panGuestOpen.ResumeLayout(false);
            this.panGuestOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGuestOpen;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labIDCus;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.DateTimePicker datePickerCheckOut;
        private System.Windows.Forms.DateTimePicker datePickerCheckIn;
        private System.Windows.Forms.DateTimePicker datePickerBirth;
        private System.Windows.Forms.ComboBox comBoxSexual;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.Label labIDRoomShow;
        private System.Windows.Forms.Label labCOD;
        private System.Windows.Forms.Label labCID;
        private System.Windows.Forms.Label labIDRoom;
        private System.Windows.Forms.Label labSexual;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.TextBox textIDCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butExit;
    }
}