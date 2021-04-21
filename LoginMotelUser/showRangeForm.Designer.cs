namespace LoginMotelUser
{
    partial class showRangeForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showRangeForm));
            this.panRange = new System.Windows.Forms.Panel();
            this.OldName = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.Label();
            this.textNewName = new System.Windows.Forms.TextBox();
            this.labPage = new System.Windows.Forms.Label();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.buttUpdate = new System.Windows.Forms.Button();
            this.textRangeName = new System.Windows.Forms.TextBox();
            this.textIDRange = new System.Windows.Forms.TextBox();
            this.labRangeName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.listRange = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRange
            // 
            this.panRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panRange.BackgroundImage")));
            this.panRange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panRange.Controls.Add(this.OldName);
            this.panRange.Controls.Add(this.NewName);
            this.panRange.Controls.Add(this.textNewName);
            this.panRange.Controls.Add(this.labPage);
            this.panRange.Controls.Add(this.butRight);
            this.panRange.Controls.Add(this.butLeft);
            this.panRange.Controls.Add(this.textSearch);
            this.panRange.Controls.Add(this.labSearch);
            this.panRange.Controls.Add(this.butClear);
            this.panRange.Controls.Add(this.butDelete);
            this.panRange.Controls.Add(this.buttUpdate);
            this.panRange.Controls.Add(this.textRangeName);
            this.panRange.Controls.Add(this.textIDRange);
            this.panRange.Controls.Add(this.labRangeName);
            this.panRange.Controls.Add(this.labID);
            this.panRange.Controls.Add(this.listRange);
            this.panRange.Controls.Add(this.labTieuDe);
            this.panRange.Location = new System.Drawing.Point(-1, 1);
            this.panRange.Name = "panRange";
            this.panRange.Size = new System.Drawing.Size(913, 621);
            this.panRange.TabIndex = 0;
            // 
            // OldName
            // 
            this.OldName.AutoSize = true;
            this.OldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldName.Location = new System.Drawing.Point(443, 214);
            this.OldName.Name = "OldName";
            this.OldName.Size = new System.Drawing.Size(151, 20);
            this.OldName.TabIndex = 14;
            this.OldName.Text = "Old Range Name";
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewName.Location = new System.Drawing.Point(443, 262);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(158, 20);
            this.NewName.TabIndex = 13;
            this.NewName.Text = "New Range Name";
            // 
            // textNewName
            // 
            this.textNewName.Location = new System.Drawing.Point(627, 260);
            this.textNewName.Name = "textNewName";
            this.textNewName.Size = new System.Drawing.Size(167, 22);
            this.textNewName.TabIndex = 12;
            // 
            // labPage
            // 
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(184, 543);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(70, 17);
            this.labPage.TabIndex = 11;
            this.labPage.Text = "Trang 0/0";
            // 
            // butRight
            // 
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(301, 538);
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
            this.butLeft.Location = new System.Drawing.Point(52, 538);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 1;
            this.butLeft.Text = "Trái";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(627, 62);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(167, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(443, 67);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(80, 20);
            this.labSearch.TabIndex = 7;
            this.labSearch.Text = "Search: ";
            // 
            // butClear
            // 
            this.butClear.AutoSize = true;
            this.butClear.Location = new System.Drawing.Point(765, 321);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(104, 64);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "CLEAR";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butDelete
            // 
            this.butDelete.AutoSize = true;
            this.butDelete.Location = new System.Drawing.Point(588, 321);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(104, 64);
            this.butDelete.TabIndex = 7;
            this.butDelete.Text = "DELETE";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // buttUpdate
            // 
            this.buttUpdate.AutoSize = true;
            this.buttUpdate.Location = new System.Drawing.Point(418, 321);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(104, 64);
            this.buttUpdate.TabIndex = 6;
            this.buttUpdate.Text = "...";
            this.buttUpdate.UseVisualStyleBackColor = true;
            this.buttUpdate.Click += new System.EventHandler(this.buttUpdate_Click);
            // 
            // textRangeName
            // 
            this.textRangeName.Location = new System.Drawing.Point(627, 211);
            this.textRangeName.Name = "textRangeName";
            this.textRangeName.Size = new System.Drawing.Size(167, 22);
            this.textRangeName.TabIndex = 5;
            this.textRangeName.TextChanged += new System.EventHandler(this.textRangeName_TextChanged);
            // 
            // textIDRange
            // 
            this.textIDRange.Enabled = false;
            this.textIDRange.Location = new System.Drawing.Point(627, 137);
            this.textIDRange.Name = "textIDRange";
            this.textIDRange.Size = new System.Drawing.Size(167, 22);
            this.textIDRange.TabIndex = 4;
            // 
            // labRangeName
            // 
            this.labRangeName.AutoSize = true;
            this.labRangeName.Location = new System.Drawing.Point(468, 214);
            this.labRangeName.Name = "labRangeName";
            this.labRangeName.Size = new System.Drawing.Size(91, 17);
            this.labRangeName.TabIndex = 3;
            this.labRangeName.Text = "Range Name";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(443, 137);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(40, 20);
            this.labID.TabIndex = 2;
            this.labID.Text = "ID :";
            // 
            // listRange
            // 
            this.listRange.FullRowSelect = true;
            this.listRange.GridLines = true;
            this.listRange.HideSelection = false;
            this.listRange.Location = new System.Drawing.Point(52, 67);
            this.listRange.Name = "listRange";
            this.listRange.Size = new System.Drawing.Size(324, 465);
            this.listRange.TabIndex = 0;
            this.listRange.UseCompatibleStateImageBehavior = false;
            this.listRange.View = System.Windows.Forms.View.Details;
            this.listRange.SelectedIndexChanged += new System.EventHandler(this.listRange_SelectedIndexChanged);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(286, 5);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(333, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "RANGE INFORMATION";
            // 
            // showRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 621);
            this.Controls.Add(this.panRange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showRangeForm";
            this.Text = "RANGE";
            this.panRange.ResumeLayout(false);
            this.panRange.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panRange;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button buttUpdate;
        private System.Windows.Forms.TextBox textRangeName;
        private System.Windows.Forms.TextBox textIDRange;
        private System.Windows.Forms.Label labRangeName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.ListView listRange;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Label labPage;
        private System.Windows.Forms.Label OldName;
        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.TextBox textNewName;
    }
}