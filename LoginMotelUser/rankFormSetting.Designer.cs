namespace LoginMotelUser
{
    partial class rankFormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rankFormSetting));
            this.labTieuDe = new System.Windows.Forms.Label();
            this.labIDRank = new System.Windows.Forms.Label();
            this.labRankName = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labDeposit = new System.Windows.Forms.Label();
            this.GhiAbout = new System.Windows.Forms.Label();
            this.labIDShow = new System.Windows.Forms.Label();
            this.textRankName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.panRankOpen = new System.Windows.Forms.Panel();
            this.textAbout = new System.Windows.Forms.TextBox();
            this.panRankOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(181, 0);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(297, 33);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "THÔNG TIN LOẠI PHÒNG";
            // 
            // labIDRank
            // 
            this.labIDRank.AutoSize = true;
            this.labIDRank.Location = new System.Drawing.Point(51, 82);
            this.labIDRank.Name = "labIDRank";
            this.labIDRank.Size = new System.Drawing.Size(29, 17);
            this.labIDRank.TabIndex = 1;
            this.labIDRank.Text = "ID :";
            // 
            // labRankName
            // 
            this.labRankName.AutoSize = true;
            this.labRankName.Location = new System.Drawing.Point(51, 141);
            this.labRankName.Name = "labRankName";
            this.labRankName.Size = new System.Drawing.Size(117, 17);
            this.labRankName.TabIndex = 2;
            this.labRankName.Text = "Tên Loại Phòng :";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(51, 191);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(68, 17);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "Đơn Giá :";
            // 
            // labDeposit
            // 
            this.labDeposit.AutoSize = true;
            this.labDeposit.Location = new System.Drawing.Point(51, 251);
            this.labDeposit.Name = "labDeposit";
            this.labDeposit.Size = new System.Drawing.Size(72, 17);
            this.labDeposit.TabIndex = 5;
            this.labDeposit.Text = "Tiền Cọc :";
            // 
            // GhiAbout
            // 
            this.GhiAbout.AutoSize = true;
            this.GhiAbout.Location = new System.Drawing.Point(51, 329);
            this.GhiAbout.Name = "GhiAbout";
            this.GhiAbout.Size = new System.Drawing.Size(67, 17);
            this.GhiAbout.TabIndex = 7;
            this.GhiAbout.Text = "Ghi Chú :";
            // 
            // labIDShow
            // 
            this.labIDShow.AutoSize = true;
            this.labIDShow.Location = new System.Drawing.Point(184, 82);
            this.labIDShow.Name = "labIDShow";
            this.labIDShow.Size = new System.Drawing.Size(52, 17);
            this.labIDShow.TabIndex = 0;
            this.labIDShow.Text = "update";
            // 
            // textRankName
            // 
            this.textRankName.Location = new System.Drawing.Point(187, 138);
            this.textRankName.Name = "textRankName";
            this.textRankName.Size = new System.Drawing.Size(326, 22);
            this.textRankName.TabIndex = 1;
            this.textRankName.TextChanged += new System.EventHandler(this.textRankName_TextChanged);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(187, 191);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(326, 22);
            this.textPrice.TabIndex = 2;
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(187, 251);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(326, 22);
            this.textDeposit.TabIndex = 3;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(79, 448);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(141, 70);
            this.butUpdate.TabIndex = 5;
            this.butUpdate.Text = "Cập Nhật";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(477, 448);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(141, 70);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "THOÁT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // panRankOpen
            // 
            this.panRankOpen.Controls.Add(this.textAbout);
            this.panRankOpen.Controls.Add(this.butExit);
            this.panRankOpen.Controls.Add(this.butUpdate);
            this.panRankOpen.Controls.Add(this.textDeposit);
            this.panRankOpen.Controls.Add(this.textPrice);
            this.panRankOpen.Controls.Add(this.textRankName);
            this.panRankOpen.Controls.Add(this.labIDShow);
            this.panRankOpen.Controls.Add(this.GhiAbout);
            this.panRankOpen.Controls.Add(this.labDeposit);
            this.panRankOpen.Controls.Add(this.labPrice);
            this.panRankOpen.Controls.Add(this.labRankName);
            this.panRankOpen.Controls.Add(this.labIDRank);
            this.panRankOpen.Controls.Add(this.labTieuDe);
            this.panRankOpen.Location = new System.Drawing.Point(1, 0);
            this.panRankOpen.Name = "panRankOpen";
            this.panRankOpen.Size = new System.Drawing.Size(673, 563);
            this.panRankOpen.TabIndex = 1;
            // 
            // textAbout
            // 
            this.textAbout.Location = new System.Drawing.Point(187, 326);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.Size = new System.Drawing.Size(326, 100);
            this.textAbout.TabIndex = 4;
            // 
            // rankFormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 559);
            this.Controls.Add(this.panRankOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rankFormSetting";
            this.Text = "rankOpenForm";
            this.panRankOpen.ResumeLayout(false);
            this.panRankOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labIDRank;
        private System.Windows.Forms.Label labRankName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labDeposit;
        private System.Windows.Forms.Label GhiAbout;
        private System.Windows.Forms.Label labIDShow;
        private System.Windows.Forms.TextBox textRankName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textDeposit;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Panel panRankOpen;
        private System.Windows.Forms.TextBox textAbout;
    }
}