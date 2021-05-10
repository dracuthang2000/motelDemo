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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createStaffForm));
            this.panStaffOpen = new System.Windows.Forms.Panel();
            this.buttonCancle = new ePOSOne.btnProduct.Button_WOC();
            this.buttonSave = new ePOSOne.btnProduct.Button_WOC();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textIDStaff = new System.Windows.Forms.TextBox();
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
            this.panStaffOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panStaffOpen
            // 
            this.panStaffOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panStaffOpen.BackgroundImage")));
            this.panStaffOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panStaffOpen.Controls.Add(this.buttonCancle);
            this.panStaffOpen.Controls.Add(this.buttonSave);
            this.panStaffOpen.Controls.Add(this.buttonChoose);
            this.panStaffOpen.Controls.Add(this.textUserName);
            this.panStaffOpen.Controls.Add(this.textIDStaff);
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
            this.panStaffOpen.Location = new System.Drawing.Point(-2, 1);
            this.panStaffOpen.Name = "panStaffOpen";
            this.panStaffOpen.Size = new System.Drawing.Size(888, 662);
            this.panStaffOpen.TabIndex = 1;
            // 
            // buttonCancle
            // 
            this.buttonCancle.BackColor = System.Drawing.Color.Peru;
            this.buttonCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancle.BackgroundImage")));
            this.buttonCancle.BorderColor = System.Drawing.Color.Silver;
            this.buttonCancle.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonCancle.FlatAppearance.BorderSize = 0;
            this.buttonCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancle.Location = new System.Drawing.Point(805, 629);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonCancle.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonCancle.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonCancle.Size = new System.Drawing.Size(80, 30);
            this.buttonCancle.TabIndex = 18;
            this.buttonCancle.Text = "CANCLE";
            this.buttonCancle.TextColor = System.Drawing.Color.Black;
            this.buttonCancle.UseVisualStyleBackColor = false;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Peru;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BorderColor = System.Drawing.Color.Silver;
            this.buttonSave.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(3, 629);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonSave.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonSave.Size = new System.Drawing.Size(80, 30);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChoose.Location = new System.Drawing.Point(420, 325);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(93, 30);
            this.buttonChoose.TabIndex = 16;
            this.buttonChoose.Text = "CHOOSE";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // textUserName
            // 
            this.textUserName.Enabled = false;
            this.textUserName.Location = new System.Drawing.Point(187, 329);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(221, 22);
            this.textUserName.TabIndex = 6;
            // 
            // textIDStaff
            // 
            this.textIDStaff.Location = new System.Drawing.Point(187, 130);
            this.textIDStaff.MaxLength = 9;
            this.textIDStaff.Name = "textIDStaff";
            this.textIDStaff.Size = new System.Drawing.Size(221, 22);
            this.textIDStaff.TabIndex = 0;
            this.textIDStaff.TextChanged += new System.EventHandler(this.textIDStaff_TextChanged);
            this.textIDStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIDStaff_KeyPress);
            // 
            // datePickerBirth
            // 
            this.datePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerBirth.Location = new System.Drawing.Point(718, 162);
            this.datePickerBirth.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.datePickerBirth.Name = "datePickerBirth";
            this.datePickerBirth.Size = new System.Drawing.Size(136, 22);
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
            this.textSDT.MaxLength = 10;
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(326, 22);
            this.textSDT.TabIndex = 4;
            this.textSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSDT_KeyPress);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(187, 223);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(667, 22);
            this.textAddress.TabIndex = 3;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(187, 176);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(326, 22);
            this.textHoTen.TabIndex = 1;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(51, 332);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(100, 18);
            this.labUserName.TabIndex = 7;
            this.labUserName.Text = "User name :";
            // 
            // labSexual
            // 
            this.labSexual.AutoSize = true;
            this.labSexual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSexual.Location = new System.Drawing.Point(538, 266);
            this.labSexual.Name = "labSexual";
            this.labSexual.Size = new System.Drawing.Size(68, 18);
            this.labSexual.TabIndex = 6;
            this.labSexual.Text = "Sexual :";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSDT.Location = new System.Drawing.Point(51, 266);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(127, 18);
            this.labSDT.TabIndex = 5;
            this.labSDT.Text = "Phone number :";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiaChi.Location = new System.Drawing.Point(51, 224);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(79, 18);
            this.labDiaChi.TabIndex = 4;
            this.labDiaChi.Text = "Address :";
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNgaySinh.Location = new System.Drawing.Point(633, 162);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(79, 18);
            this.labNgaySinh.TabIndex = 3;
            this.labNgaySinh.Text = "Birhtday :";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoTen.Location = new System.Drawing.Point(51, 180);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(91, 18);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "Full name :";
            // 
            // labIDStaff
            // 
            this.labIDStaff.AutoSize = true;
            this.labIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIDStaff.Location = new System.Drawing.Point(51, 131);
            this.labIDStaff.Name = "labIDStaff";
            this.labIDStaff.Size = new System.Drawing.Size(72, 18);
            this.labIDStaff.TabIndex = 1;
            this.labIDStaff.Text = "ID card :";
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(338, 8);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(258, 33);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "INFORMATION STAFF";
            // 
            // createStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 661);
            this.Controls.Add(this.panStaffOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "createStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "STAFF UPDATE";
            this.panStaffOpen.ResumeLayout(false);
            this.panStaffOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panStaffOpen;
        private System.Windows.Forms.TextBox textIDStaff;
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
        private System.Windows.Forms.Button buttonChoose;
        private ePOSOne.btnProduct.Button_WOC buttonSave;
        private ePOSOne.btnProduct.Button_WOC buttonCancle;
    }
}