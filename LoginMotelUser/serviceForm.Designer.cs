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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceForm));
            this.panService = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textNewName = new System.Windows.Forms.TextBox();
            this.labPage = new System.Windows.Forms.Label();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.textIDService = new System.Windows.Forms.TextBox();
            this.labServiceName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.listService = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.buttonSave = new ePOSOne.btnProduct.Button_WOC();
            this.panService.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panService
            // 
            this.panService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panService.BackgroundImage")));
            this.panService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panService.Controls.Add(this.labPage);
            this.panService.Controls.Add(this.butRight);
            this.panService.Controls.Add(this.butLeft);
            this.panService.Controls.Add(this.listService);
            this.panService.Controls.Add(this.labTieuDe);
            this.panService.Location = new System.Drawing.Point(487, 5);
            this.panService.Name = "panService";
            this.panService.Size = new System.Drawing.Size(429, 615);
            this.panService.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "New service name";
            // 
            // textNewName
            // 
            this.textNewName.Location = new System.Drawing.Point(177, 182);
            this.textNewName.Name = "textNewName";
            this.textNewName.Size = new System.Drawing.Size(167, 22);
            this.textNewName.TabIndex = 13;
            // 
            // labPage
            // 
            this.labPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(175, 585);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(65, 17);
            this.labPage.TabIndex = 12;
            this.labPage.Text = "Page 0/0";
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(323, 580);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 2;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(26, 580);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 1;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(177, 55);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(161, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(3, 60);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(61, 17);
            this.labSearch.TabIndex = 8;
            this.labSearch.Text = "Search: ";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(177, 232);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(167, 22);
            this.textPrice.TabIndex = 6;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(3, 232);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(48, 17);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "Price :";
            // 
            // textServiceName
            // 
            this.textServiceName.Location = new System.Drawing.Point(177, 141);
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.Size = new System.Drawing.Size(167, 22);
            this.textServiceName.TabIndex = 5;
            this.textServiceName.TextChanged += new System.EventHandler(this.textServiceName_TextChanged);
            // 
            // textIDService
            // 
            this.textIDService.Enabled = false;
            this.textIDService.Location = new System.Drawing.Point(177, 96);
            this.textIDService.Name = "textIDService";
            this.textIDService.Size = new System.Drawing.Size(161, 22);
            this.textIDService.TabIndex = 4;
            // 
            // labServiceName
            // 
            this.labServiceName.AutoSize = true;
            this.labServiceName.Location = new System.Drawing.Point(3, 146);
            this.labServiceName.Name = "labServiceName";
            this.labServiceName.Size = new System.Drawing.Size(118, 17);
            this.labServiceName.TabIndex = 3;
            this.labServiceName.Text = "Old service name";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(3, 101);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(29, 17);
            this.labID.TabIndex = 2;
            this.labID.Text = "ID :";
            // 
            // listService
            // 
            this.listService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listService.FullRowSelect = true;
            this.listService.GridLines = true;
            this.listService.HideSelection = false;
            this.listService.Location = new System.Drawing.Point(26, 67);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(372, 507);
            this.listService.TabIndex = 0;
            this.listService.UseCompatibleStateImageBehavior = false;
            this.listService.View = System.Windows.Forms.View.Details;
            this.listService.SelectedIndexChanged += new System.EventHandler(this.listService_SelectedIndexChanged);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(52, 19);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(358, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "SERVICE INFORMATION";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.labSearch);
            this.panel1.Controls.Add(this.button_WOC1);
            this.panel1.Controls.Add(this.textIDService);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textServiceName);
            this.panel1.Controls.Add(this.textNewName);
            this.panel1.Controls.Add(this.labPrice);
            this.panel1.Controls.Add(this.textPrice);
            this.panel1.Controls.Add(this.labServiceName);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 548);
            this.panel1.TabIndex = 61;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.BorderColor = System.Drawing.Color.Silver;
            this.buttonClear.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(247, 489);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonClear.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonClear.Size = new System.Drawing.Size(103, 47);
            this.buttonClear.TabIndex = 60;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.TextColor = System.Drawing.Color.Black;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WOC1.BackColor = System.Drawing.SystemColors.Control;
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(127, 489);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(103, 47);
            this.button_WOC1.TabIndex = 59;
            this.button_WOC1.Text = "DELETE";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.BorderColor = System.Drawing.Color.Silver;
            this.buttonSave.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(6, 489);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonSave.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonSave.Size = new System.Drawing.Size(103, 47);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "serviceForm";
            this.Text = "Z";
            this.panService.ResumeLayout(false);
            this.panService.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panService;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labPrice;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNewName;
        private ePOSOne.btnProduct.Button_WOC buttonClear;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC buttonSave;
        private System.Windows.Forms.Panel panel1;
    }
}