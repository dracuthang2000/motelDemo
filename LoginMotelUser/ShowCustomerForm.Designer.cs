namespace LoginMotelUser
{
    partial class ShowCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCustomerForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.listKhach = new System.Windows.Forms.ListView();
            this.labSearch = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.labPage = new System.Windows.Forms.Label();
            this.panKhach = new System.Windows.Forms.Panel();
            this.buttonCancle = new ePOSOne.btnProduct.Button_WOC();
            this.buttonDelete = new ePOSOne.btnProduct.Button_WOC();
            this.buttonUp = new ePOSOne.btnProduct.Button_WOC();
            this.contextMenuStrip1.SuspendLayout();
            this.panKhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 28);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.CheckOnClick = true;
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.iDToolStripMenuItem.Text = "ID";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.iDToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.CheckOnClick = true;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // labTieuDe
            // 
            this.labTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(357, 7);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(254, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "LIST CUSTOMER";
            // 
            // listKhach
            // 
            this.listKhach.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listKhach.AllowColumnReorder = true;
            this.listKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKhach.FullRowSelect = true;
            this.listKhach.GridLines = true;
            this.listKhach.HideSelection = false;
            this.listKhach.LabelEdit = true;
            this.listKhach.Location = new System.Drawing.Point(10, 113);
            this.listKhach.Name = "listKhach";
            this.listKhach.Size = new System.Drawing.Size(950, 412);
            this.listKhach.TabIndex = 1;
            this.listKhach.UseCompatibleStateImageBehavior = false;
            this.listKhach.View = System.Windows.Forms.View.Details;
            this.listKhach.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listKhach_ColumnClick);
            this.listKhach.DoubleClick += new System.EventHandler(this.listKhach_DoubleClick);
            this.listKhach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listKhach_MouseClick);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(36, 70);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(74, 20);
            this.labSearch.TabIndex = 6;
            this.labSearch.Text = "Search:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(116, 70);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(884, 527);
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
            this.butLeft.Location = new System.Drawing.Point(10, 531);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // labPage
            // 
            this.labPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(438, 541);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(65, 17);
            this.labPage.TabIndex = 9;
            this.labPage.Text = "Page 0/0";
            // 
            // panKhach
            // 
            this.panKhach.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panKhach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panKhach.BackgroundImage")));
            this.panKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panKhach.Controls.Add(this.buttonCancle);
            this.panKhach.Controls.Add(this.buttonDelete);
            this.panKhach.Controls.Add(this.buttonUp);
            this.panKhach.Controls.Add(this.labPage);
            this.panKhach.Controls.Add(this.butLeft);
            this.panKhach.Controls.Add(this.butRight);
            this.panKhach.Controls.Add(this.textSearch);
            this.panKhach.Controls.Add(this.labSearch);
            this.panKhach.Controls.Add(this.listKhach);
            this.panKhach.Controls.Add(this.labTieuDe);
            this.panKhach.Location = new System.Drawing.Point(2, 2);
            this.panKhach.Name = "panKhach";
            this.panKhach.Size = new System.Drawing.Size(970, 656);
            this.panKhach.TabIndex = 0;
            // 
            // buttonCancle
            // 
            this.buttonCancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancle.BackColor = System.Drawing.Color.Peru;
            this.buttonCancle.BorderColor = System.Drawing.Color.Silver;
            this.buttonCancle.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonCancle.FlatAppearance.BorderSize = 0;
            this.buttonCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancle.Location = new System.Drawing.Point(686, 577);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonCancle.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonCancle.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonCancle.Size = new System.Drawing.Size(103, 47);
            this.buttonCancle.TabIndex = 59;
            this.buttonCancle.Text = "CANCLE";
            this.buttonCancle.TextColor = System.Drawing.Color.Black;
            this.buttonCancle.UseVisualStyleBackColor = false;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.BackColor = System.Drawing.Color.Peru;
            this.buttonDelete.BorderColor = System.Drawing.Color.Silver;
            this.buttonDelete.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(420, 577);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonDelete.Size = new System.Drawing.Size(103, 47);
            this.buttonDelete.TabIndex = 58;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextColor = System.Drawing.Color.Black;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUp.BackColor = System.Drawing.Color.Peru;
            this.buttonUp.BorderColor = System.Drawing.Color.Silver;
            this.buttonUp.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(181, 577);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUp.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUp.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUp.Size = new System.Drawing.Size(103, 47);
            this.buttonUp.TabIndex = 57;
            this.buttonUp.Text = "...";
            this.buttonUp.TextColor = System.Drawing.Color.Black;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // ShowCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 659);
            this.Controls.Add(this.panKhach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCustomerForm";
            this.Text = "CUSTOMER";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panKhach.ResumeLayout(false);
            this.panKhach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Label labPage;
        private System.Windows.Forms.Panel panKhach;
        private ePOSOne.btnProduct.Button_WOC buttonUp;
        private ePOSOne.btnProduct.Button_WOC buttonDelete;
        private ePOSOne.btnProduct.Button_WOC buttonCancle;
        private System.Windows.Forms.ListView listKhach;
    }
}