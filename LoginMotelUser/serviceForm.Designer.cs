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
            this.panService = new System.Windows.Forms.Panel();
            this.labPage = new System.Windows.Forms.Label();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.buttUpdate = new System.Windows.Forms.Button();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.textIDService = new System.Windows.Forms.TextBox();
            this.labServiceName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.listService = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panService
            // 
            this.panService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panService.Controls.Add(this.labPage);
            this.panService.Controls.Add(this.butRight);
            this.panService.Controls.Add(this.butLeft);
            this.panService.Controls.Add(this.textSearch);
            this.panService.Controls.Add(this.labSearch);
            this.panService.Controls.Add(this.textPrice);
            this.panService.Controls.Add(this.labPrice);
            this.panService.Controls.Add(this.butClear);
            this.panService.Controls.Add(this.butDelete);
            this.panService.Controls.Add(this.buttUpdate);
            this.panService.Controls.Add(this.textServiceName);
            this.panService.Controls.Add(this.textIDService);
            this.panService.Controls.Add(this.labServiceName);
            this.panService.Controls.Add(this.labID);
            this.panService.Controls.Add(this.listService);
            this.panService.Controls.Add(this.labTieuDe);
            this.panService.Location = new System.Drawing.Point(3, 2);
            this.panService.Name = "panService";
            this.panService.Size = new System.Drawing.Size(910, 618);
            this.panService.TabIndex = 1;
            // 
            // labPage
            // 
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(198, 543);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(70, 17);
            this.labPage.TabIndex = 12;
            this.labPage.Text = "Trang 0/0";
            // 
            // butRight
            // 
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(368, 538);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 2;
            this.butRight.Text = "Phải";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butLeft
            // 
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(26, 538);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 1;
            this.butLeft.Text = "Trái";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(627, 79);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(161, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(492, 82);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(74, 17);
            this.labSearch.TabIndex = 8;
            this.labSearch.Text = "Tìm Kiếm :";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(627, 281);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(167, 22);
            this.textPrice.TabIndex = 6;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(498, 284);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(68, 17);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "Đơn Giá :";
            // 
            // butClear
            // 
            this.butClear.AutoSize = true;
            this.butClear.Location = new System.Drawing.Point(774, 378);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(104, 64);
            this.butClear.TabIndex = 9;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butDelete
            // 
            this.butDelete.AutoSize = true;
            this.butDelete.Location = new System.Drawing.Point(627, 378);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(104, 64);
            this.butDelete.TabIndex = 8;
            this.butDelete.Text = "Xóa";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // buttUpdate
            // 
            this.buttUpdate.AutoSize = true;
            this.buttUpdate.Location = new System.Drawing.Point(462, 378);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(104, 64);
            this.buttUpdate.TabIndex = 7;
            this.buttUpdate.Text = "Cập Nhật";
            this.buttUpdate.UseVisualStyleBackColor = true;
            this.buttUpdate.Click += new System.EventHandler(this.buttUpdate_Click);
            // 
            // textServiceName
            // 
            this.textServiceName.Location = new System.Drawing.Point(627, 211);
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.Size = new System.Drawing.Size(167, 22);
            this.textServiceName.TabIndex = 5;
            // 
            // textIDService
            // 
            this.textIDService.Enabled = false;
            this.textIDService.Location = new System.Drawing.Point(627, 135);
            this.textIDService.Name = "textIDService";
            this.textIDService.Size = new System.Drawing.Size(161, 22);
            this.textIDService.TabIndex = 4;
            // 
            // labServiceName
            // 
            this.labServiceName.AutoSize = true;
            this.labServiceName.Location = new System.Drawing.Point(474, 214);
            this.labServiceName.Name = "labServiceName";
            this.labServiceName.Size = new System.Drawing.Size(92, 17);
            this.labServiceName.TabIndex = 3;
            this.labServiceName.Text = "Tên Dịch vụ :";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(537, 138);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(29, 17);
            this.labID.TabIndex = 2;
            this.labID.Text = "ID :";
            // 
            // listService
            // 
            this.listService.FullRowSelect = true;
            this.listService.GridLines = true;
            this.listService.HideSelection = false;
            this.listService.Location = new System.Drawing.Point(26, 67);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(417, 465);
            this.listService.TabIndex = 0;
            this.listService.UseCompatibleStateImageBehavior = false;
            this.listService.View = System.Windows.Forms.View.Details;
            this.listService.SelectedIndexChanged += new System.EventHandler(this.listService_SelectedIndexChanged);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(272, 5);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(304, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 620);
            this.Controls.Add(this.panService);
            this.Name = "serviceForm";
            this.Text = "serviceForm";
            this.panService.ResumeLayout(false);
            this.panService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panService;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button buttUpdate;
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
    }
}