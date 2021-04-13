namespace LoginMotelUser
{
    partial class AddRoomcs
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
            this.panRoomOpen = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.comBoxIDRange = new System.Windows.Forms.ComboBox();
            this.comBoxIDRank = new System.Windows.Forms.ComboBox();
            this.labStateShow = new System.Windows.Forms.Label();
            this.textRoomName = new System.Windows.Forms.TextBox();
            this.labIDRoomShow = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.labState = new System.Windows.Forms.Label();
            this.labIDRange = new System.Windows.Forms.Label();
            this.labIDRank = new System.Windows.Forms.Label();
            this.labRoomName = new System.Windows.Forms.Label();
            this.labIDRoom = new System.Windows.Forms.Label();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panRoomOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRoomOpen
            // 
            this.panRoomOpen.Controls.Add(this.butExit);
            this.panRoomOpen.Controls.Add(this.comBoxIDRange);
            this.panRoomOpen.Controls.Add(this.comBoxIDRank);
            this.panRoomOpen.Controls.Add(this.labStateShow);
            this.panRoomOpen.Controls.Add(this.textRoomName);
            this.panRoomOpen.Controls.Add(this.labIDRoomShow);
            this.panRoomOpen.Controls.Add(this.butUpdate);
            this.panRoomOpen.Controls.Add(this.labState);
            this.panRoomOpen.Controls.Add(this.labIDRange);
            this.panRoomOpen.Controls.Add(this.labIDRank);
            this.panRoomOpen.Controls.Add(this.labRoomName);
            this.panRoomOpen.Controls.Add(this.labIDRoom);
            this.panRoomOpen.Controls.Add(this.labTieuDe);
            this.panRoomOpen.Location = new System.Drawing.Point(3, 4);
            this.panRoomOpen.Name = "panRoomOpen";
            this.panRoomOpen.Size = new System.Drawing.Size(992, 678);
            this.panRoomOpen.TabIndex = 0;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(613, 450);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(141, 70);
            this.butExit.TabIndex = 17;
            this.butExit.Text = "Thoát";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // comBoxIDRange
            // 
            this.comBoxIDRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxIDRange.FormattingEnabled = true;
            this.comBoxIDRange.Location = new System.Drawing.Point(396, 301);
            this.comBoxIDRange.Name = "comBoxIDRange";
            this.comBoxIDRange.Size = new System.Drawing.Size(179, 24);
            this.comBoxIDRange.TabIndex = 3;
            this.comBoxIDRange.SelectedIndexChanged += new System.EventHandler(this.comBoxIDRange_SelectedIndexChanged);
            // 
            // comBoxIDRank
            // 
            this.comBoxIDRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxIDRank.FormattingEnabled = true;
            this.comBoxIDRank.Location = new System.Drawing.Point(396, 246);
            this.comBoxIDRank.Name = "comBoxIDRank";
            this.comBoxIDRank.Size = new System.Drawing.Size(179, 24);
            this.comBoxIDRank.TabIndex = 2;
            // 
            // labStateShow
            // 
            this.labStateShow.AutoSize = true;
            this.labStateShow.Location = new System.Drawing.Point(393, 196);
            this.labStateShow.Name = "labStateShow";
            this.labStateShow.Size = new System.Drawing.Size(54, 17);
            this.labStateShow.TabIndex = 12;
            this.labStateShow.Text = "loading";
            // 
            // textRoomName
            // 
            this.textRoomName.Location = new System.Drawing.Point(396, 129);
            this.textRoomName.Name = "textRoomName";
            this.textRoomName.Size = new System.Drawing.Size(179, 22);
            this.textRoomName.TabIndex = 1;
            this.textRoomName.TextChanged += new System.EventHandler(this.textRoomName_TextChanged);
            // 
            // labIDRoomShow
            // 
            this.labIDRoomShow.AutoSize = true;
            this.labIDRoomShow.Location = new System.Drawing.Point(393, 76);
            this.labIDRoomShow.Name = "labIDRoomShow";
            this.labIDRoomShow.Size = new System.Drawing.Size(54, 17);
            this.labIDRoomShow.TabIndex = 10;
            this.labIDRoomShow.Text = "loading";
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(229, 450);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(141, 70);
            this.butUpdate.TabIndex = 9;
            this.butUpdate.Text = "Cập Nhật";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(243, 196);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(81, 17);
            this.labState.TabIndex = 5;
            this.labState.Text = "Trạng thái :";
            // 
            // labIDRange
            // 
            this.labIDRange.AutoSize = true;
            this.labIDRange.Location = new System.Drawing.Point(238, 301);
            this.labIDRange.Name = "labIDRange";
            this.labIDRange.Size = new System.Drawing.Size(86, 17);
            this.labIDRange.TabIndex = 4;
            this.labIDRange.Text = "ID Khu Vực :";
            // 
            // labIDRank
            // 
            this.labIDRank.AutoSize = true;
            this.labIDRank.Location = new System.Drawing.Point(264, 253);
            this.labIDRank.Name = "labIDRank";
            this.labIDRank.Size = new System.Drawing.Size(60, 17);
            this.labIDRank.TabIndex = 3;
            this.labIDRank.Text = "ID Loại :";
            // 
            // labRoomName
            // 
            this.labRoomName.AutoSize = true;
            this.labRoomName.Location = new System.Drawing.Point(238, 143);
            this.labRoomName.Name = "labRoomName";
            this.labRoomName.Size = new System.Drawing.Size(86, 17);
            this.labRoomName.TabIndex = 2;
            this.labRoomName.Text = "Tên Phòng :";
            // 
            // labIDRoom
            // 
            this.labIDRoom.AutoSize = true;
            this.labIDRoom.Location = new System.Drawing.Point(238, 76);
            this.labIDRoom.Name = "labIDRoom";
            this.labIDRoom.Size = new System.Drawing.Size(74, 17);
            this.labIDRoom.TabIndex = 1;
            this.labIDRoom.Text = "ID Phòng :";
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(308, 0);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(362, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "THÔNG TIN PHÒNG TRỌ";
            // 
            // AddRoomcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 684);
            this.Controls.Add(this.panRoomOpen);
            this.Name = "AddRoomcs";
            this.Text = "roomOpenForm";
            this.panRoomOpen.ResumeLayout(false);
            this.panRoomOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRoomOpen;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Label labIDRange;
        private System.Windows.Forms.Label labIDRank;
        private System.Windows.Forms.Label labRoomName;
        private System.Windows.Forms.Label labIDRoom;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labStateShow;
        private System.Windows.Forms.TextBox textRoomName;
        private System.Windows.Forms.Label labIDRoomShow;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.ComboBox comBoxIDRange;
        private System.Windows.Forms.ComboBox comBoxIDRank;
        private System.Windows.Forms.Button butExit;
    }
}