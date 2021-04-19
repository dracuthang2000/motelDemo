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
            this.panKhach = new System.Windows.Forms.Panel();
            this.butUser = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.listStaff = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panKhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // panKhach
            // 
            this.panKhach.Controls.Add(this.butUser);
            this.panKhach.Controls.Add(this.butSua);
            this.panKhach.Controls.Add(this.butThem);
            this.panKhach.Controls.Add(this.butXoa);
            this.panKhach.Controls.Add(this.listStaff);
            this.panKhach.Controls.Add(this.labTieuDe);
            this.panKhach.Location = new System.Drawing.Point(2, 2);
            this.panKhach.Name = "panKhach";
            this.panKhach.Size = new System.Drawing.Size(969, 640);
            this.panKhach.TabIndex = 1;
            // 
            // butUser
            // 
            this.butUser.Location = new System.Drawing.Point(692, 503);
            this.butUser.Name = "butUser";
            this.butUser.Size = new System.Drawing.Size(75, 53);
            this.butUser.TabIndex = 6;
            this.butUser.Text = "Đặt Mật Khẩu";
            this.butUser.UseVisualStyleBackColor = true;
            this.butUser.Click += new System.EventHandler(this.butUser_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(522, 503);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 53);
            this.butSua.TabIndex = 5;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(184, 503);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 53);
            this.butThem.TabIndex = 3;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(348, 503);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 53);
            this.butXoa.TabIndex = 4;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
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
            this.listStaff.Location = new System.Drawing.Point(10, 51);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(949, 446);
            this.listStaff.TabIndex = 1;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            this.listStaff.View = System.Windows.Forms.View.Details;
            this.listStaff.DoubleClick += new System.EventHandler(this.listStaff_DoubleClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(314, 7);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(430, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "DANH SÁCH NGƯỜI QUẢN LÝ";
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 645);
            this.Controls.Add(this.panKhach);
            this.Name = "staffForm";
            this.Text = "staffForm";
            this.panKhach.ResumeLayout(false);
            this.panKhach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panKhach;
        private System.Windows.Forms.Button butUser;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.Label labTieuDe;
    }
}