namespace LoginMotelUser
{
    partial class showRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.panRoom = new System.Windows.Forms.Panel();
            this.labPage = new System.Windows.Forms.Label();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.listRoom = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRoom
            // 
            this.panRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRoom.Controls.Add(this.labPage);
            this.panRoom.Controls.Add(this.butLeft);
            this.panRoom.Controls.Add(this.butRight);
            this.panRoom.Controls.Add(this.textSearch);
            this.panRoom.Controls.Add(this.labSearch);
            this.panRoom.Controls.Add(this.butSua);
            this.panRoom.Controls.Add(this.butThem);
            this.panRoom.Controls.Add(this.butXoa);
            this.panRoom.Controls.Add(this.listRoom);
            this.panRoom.Controls.Add(this.labTieuDe);
            this.panRoom.Location = new System.Drawing.Point(1, 2);
            this.panRoom.Name = "panRoom";
            this.panRoom.Size = new System.Drawing.Size(969, 656);
            this.panRoom.TabIndex = 1;
            // 
            // labPage
            // 
            this.labPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(441, 522);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(70, 17);
            this.labPage.TabIndex = 11;
            this.labPage.Text = "Trang 0/0";
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(11, 516);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Trái";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(885, 512);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "Phải";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(116, 63);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(36, 66);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(74, 17);
            this.labSearch.TabIndex = 7;
            this.labSearch.Text = "Tìm Kiếm :";
            // 
            // butSua
            // 
            this.butSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSua.AutoSize = true;
            this.butSua.Location = new System.Drawing.Point(569, 575);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 53);
            this.butSua.TabIndex = 6;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butThem.AutoSize = true;
            this.butThem.Location = new System.Drawing.Point(302, 575);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 53);
            this.butThem.TabIndex = 4;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butXoa.AutoSize = true;
            this.butXoa.Location = new System.Drawing.Point(436, 575);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 53);
            this.butXoa.TabIndex = 5;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // listRoom
            // 
            this.listRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRoom.FullRowSelect = true;
            this.listRoom.GridLines = true;
            this.listRoom.HideSelection = false;
            this.listRoom.LabelEdit = true;
            this.listRoom.Location = new System.Drawing.Point(11, 102);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(949, 408);
            this.listRoom.TabIndex = 1;
            this.listRoom.UseCompatibleStateImageBehavior = false;
            this.listRoom.View = System.Windows.Forms.View.Details;
            this.listRoom.DoubleClick += new System.EventHandler(this.listRoom_DoubleClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(314, 7);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(374, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "DANH SÁCH PHÒNG TRỌ";
            // 
            // roomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 661);
            this.Controls.Add(this.panRoom);
            this.Name = "roomForm";
            this.Text = "roomForm";
            this.panRoom.ResumeLayout(false);
            this.panRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRoom;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.ListView listRoom;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Label labPage;
    }
}