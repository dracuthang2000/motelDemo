namespace LoginMotelUser
{
    partial class showRankForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showRankForm));
            this.panRank = new System.Windows.Forms.Panel();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.buttonUpdate = new ePOSOne.btnProduct.Button_WOC();
            this.labPage = new System.Windows.Forms.Label();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.listRank = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRank
            // 
            this.panRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRank.BackColor = System.Drawing.Color.GhostWhite;
            this.panRank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panRank.BackgroundImage")));
            this.panRank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panRank.Controls.Add(this.button_WOC1);
            this.panRank.Controls.Add(this.buttonUpdate);
            this.panRank.Controls.Add(this.labPage);
            this.panRank.Controls.Add(this.butRight);
            this.panRank.Controls.Add(this.butLeft);
            this.panRank.Controls.Add(this.textSearch);
            this.panRank.Controls.Add(this.labSearch);
            this.panRank.Controls.Add(this.listRank);
            this.panRank.Controls.Add(this.labTieuDe);
            this.panRank.Location = new System.Drawing.Point(3, 1);
            this.panRank.Name = "panRank";
            this.panRank.Size = new System.Drawing.Size(969, 656);
            this.panRank.TabIndex = 1;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_WOC1.BackgroundImage")));
            this.button_WOC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.MediumTurquoise;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(612, 583);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(103, 37);
            this.button_WOC1.TabIndex = 13;
            this.button_WOC1.Text = "DELETE";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.BorderColor = System.Drawing.Color.Silver;
            this.buttonUpdate.ButtonColor = System.Drawing.Color.MediumTurquoise;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(291, 583);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUpdate.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUpdate.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUpdate.Size = new System.Drawing.Size(103, 37);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "...";
            this.buttonUpdate.TextColor = System.Drawing.Color.White;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // labPage
            // 
            this.labPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(433, 505);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(65, 17);
            this.labPage.TabIndex = 11;
            this.labPage.Text = "Page 0/0";
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(884, 498);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(10, 502);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(118, 63);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(38, 66);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(61, 17);
            this.labSearch.TabIndex = 7;
            this.labSearch.Tag = "";
            this.labSearch.Text = "Search: ";
            // 
            // listRank
            // 
            this.listRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRank.FullRowSelect = true;
            this.listRank.GridLines = true;
            this.listRank.HideSelection = false;
            this.listRank.LabelEdit = true;
            this.listRank.Location = new System.Drawing.Point(10, 97);
            this.listRank.Name = "listRank";
            this.listRank.Size = new System.Drawing.Size(949, 399);
            this.listRank.TabIndex = 1;
            this.listRank.UseCompatibleStateImageBehavior = false;
            this.listRank.View = System.Windows.Forms.View.Details;
            this.listRank.DoubleClick += new System.EventHandler(this.listRank_DoubleClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(359, 8);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(267, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "LIST ROOM RANK";
            // 
            // showRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 657);
            this.Controls.Add(this.panRank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "showRankForm";
            this.Text = "rankForm";
            this.panRank.ResumeLayout(false);
            this.panRank.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRank;
        private System.Windows.Forms.ListView listRank;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Label labPage;
        private ePOSOne.btnProduct.Button_WOC buttonUpdate;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}