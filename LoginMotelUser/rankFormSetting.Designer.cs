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
            this.panRankOpen = new System.Windows.Forms.Panel();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.QUAN = new System.Windows.Forms.Label();
            this.textAbout = new System.Windows.Forms.TextBox();
            this.buttonCancle = new ePOSOne.btnProduct.Button_WOC();
            this.buttonSave = new ePOSOne.btnProduct.Button_WOC();
            this.panRankOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(191, 14);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(252, 33);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "RANK INFORMATION";
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
            this.labRankName.Size = new System.Drawing.Size(88, 17);
            this.labRankName.TabIndex = 2;
            this.labRankName.Text = "Rank name :";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(51, 191);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(44, 17);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "Price:";
            // 
            // labDeposit
            // 
            this.labDeposit.AutoSize = true;
            this.labDeposit.Location = new System.Drawing.Point(51, 285);
            this.labDeposit.Name = "labDeposit";
            this.labDeposit.Size = new System.Drawing.Size(67, 17);
            this.labDeposit.TabIndex = 5;
            this.labDeposit.Text = "Desposit:";
            // 
            // GhiAbout
            // 
            this.GhiAbout.AutoSize = true;
            this.GhiAbout.Location = new System.Drawing.Point(51, 329);
            this.GhiAbout.Name = "GhiAbout";
            this.GhiAbout.Size = new System.Drawing.Size(49, 17);
            this.GhiAbout.TabIndex = 7;
            this.GhiAbout.Text = "About:";
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
            this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrice_KeyPress);
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(187, 285);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(326, 22);
            this.textDeposit.TabIndex = 3;
            this.textDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDeposit_KeyPress);
            // 
            // panRankOpen
            // 
            this.panRankOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panRankOpen.BackColor = System.Drawing.SystemColors.Control;
            this.panRankOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panRankOpen.Controls.Add(this.numericQuantity);
            this.panRankOpen.Controls.Add(this.QUAN);
            this.panRankOpen.Controls.Add(this.textAbout);
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
            this.panRankOpen.Location = new System.Drawing.Point(212, 21);
            this.panRankOpen.Name = "panRankOpen";
            this.panRankOpen.Size = new System.Drawing.Size(627, 508);
            this.panRankOpen.TabIndex = 1;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(187, 238);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericQuantity.TabIndex = 17;
            // 
            // QUAN
            // 
            this.QUAN.AutoSize = true;
            this.QUAN.Location = new System.Drawing.Point(51, 238);
            this.QUAN.Name = "QUAN";
            this.QUAN.Size = new System.Drawing.Size(61, 17);
            this.QUAN.TabIndex = 16;
            this.QUAN.Text = "Quantity";
            // 
            // textAbout
            // 
            this.textAbout.Location = new System.Drawing.Point(187, 326);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.Size = new System.Drawing.Size(326, 100);
            this.textAbout.TabIndex = 4;
            // 
            // buttonCancle
            // 
            this.buttonCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancle.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancle.BorderColor = System.Drawing.Color.Silver;
            this.buttonCancle.ButtonColor = System.Drawing.Color.MediumTurquoise;
            this.buttonCancle.FlatAppearance.BorderSize = 0;
            this.buttonCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancle.Location = new System.Drawing.Point(944, 546);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonCancle.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonCancle.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonCancle.Size = new System.Drawing.Size(100, 40);
            this.buttonCancle.TabIndex = 14;
            this.buttonCancle.Text = "CANCLE";
            this.buttonCancle.TextColor = System.Drawing.Color.White;
            this.buttonCancle.UseVisualStyleBackColor = false;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.BorderColor = System.Drawing.Color.Silver;
            this.buttonSave.ButtonColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1, 546);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonSave.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.TextColor = System.Drawing.Color.White;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // rankFormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 585);
            this.Controls.Add(this.panRankOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rankFormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rankOpenForm";
            this.panRankOpen.ResumeLayout(false);
            this.panRankOpen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
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
        private System.Windows.Forms.Panel panRankOpen;
        private System.Windows.Forms.TextBox textAbout;
        private ePOSOne.btnProduct.Button_WOC buttonSave;
        private ePOSOne.btnProduct.Button_WOC buttonCancle;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label QUAN;
    }
}