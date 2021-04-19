namespace LoginMotelUser
{
    partial class createStaffForm
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
            this.panStaffOpen = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.textIDStaff = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            this.datePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.comBoxSexual = new System.Windows.Forms.ComboBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.labSexual = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labIDStaff = new System.Windows.Forms.Label();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.panStaffOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panStaffOpen
            // 
            this.panStaffOpen.Controls.Add(this.textUserName);
            this.panStaffOpen.Controls.Add(this.butExit);
            this.panStaffOpen.Controls.Add(this.textIDStaff);
            this.panStaffOpen.Controls.Add(this.butUpdate);
            this.panStaffOpen.Controls.Add(this.datePickerBirth);
            this.panStaffOpen.Controls.Add(this.comBoxSexual);
            this.panStaffOpen.Controls.Add(this.textSDT);
            this.panStaffOpen.Controls.Add(this.textAddress);
            this.panStaffOpen.Controls.Add(this.textHoTen);
            this.panStaffOpen.Controls.Add(this.labUserName);
            this.panStaffOpen.Controls.Add(this.labSexual);
            this.panStaffOpen.Controls.Add(this.labSDT);
            this.panStaffOpen.Controls.Add(this.labDiaChi);
            this.panStaffOpen.Controls.Add(this.labNgaySinh);
            this.panStaffOpen.Controls.Add(this.labHoTen);
            this.panStaffOpen.Controls.Add(this.labIDStaff);
            this.panStaffOpen.Controls.Add(this.labTieuDe);
            this.panStaffOpen.Location = new System.Drawing.Point(12, 3);
            this.panStaffOpen.Name = "Staff";
            this.panStaffOpen.Size = new System.Drawing.Size(893, 654);
            this.panStaffOpen.TabIndex = 1;
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
            // textIDStaff
            // 
            this.textIDStaff.Location = new System.Drawing.Point(187, 79);
            this.textIDStaff.Name = "textIDStaff";
            this.textIDStaff.Size = new System.Drawing.Size(221, 22);
            this.textIDStaff.TabIndex = 0;
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
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(51, 332);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(75, 17);
            this.labUserName.TabIndex = 7;
            this.labUserName.Text = "Tên User :";
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
            // labIDStaff
            // 
            this.labIDStaff.AutoSize = true;
            this.labIDStaff.Location = new System.Drawing.Point(51, 82);
            this.labIDStaff.Name = "labIDStaff";
            this.labIDStaff.Size = new System.Drawing.Size(82, 17);
            this.labIDStaff.TabIndex = 1;
            this.labIDStaff.Text = "ID Quản lý :";
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(318, 0);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(255, 33);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "THÔNG TIN QUẢN LÝ";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(187, 329);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(221, 22);
            this.textUserName.TabIndex = 6;
            // 
            // staffOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 661);
            this.Controls.Add(this.panStaffOpen);
            this.Name = "staffOpenForm";
            this.Text = "staffOpenForm";
            this.panStaffOpen.ResumeLayout(false);
            this.panStaffOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panStaffOpen;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.TextBox textIDStaff;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.DateTimePicker datePickerBirth;
        private System.Windows.Forms.ComboBox comBoxSexual;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labSexual;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labIDStaff;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.TextBox textUserName;
    }
}