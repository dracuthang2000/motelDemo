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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showStaffForm));
            this.panKhach = new System.Windows.Forms.Panel();
            this.buttonDelete = new ePOSOne.btnProduct.Button_WOC();
            this.buttonUp = new ePOSOne.btnProduct.Button_WOC();
            this.listStaff = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panKhach.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panKhach
            // 
            this.panKhach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panKhach.BackgroundImage")));
            this.panKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panKhach.Controls.Add(this.buttonDelete);
            this.panKhach.Controls.Add(this.buttonUp);
            this.panKhach.Controls.Add(this.listStaff);
            this.panKhach.Controls.Add(this.labTieuDe);
            this.panKhach.Location = new System.Drawing.Point(-2, -2);
            this.panKhach.Name = "panKhach";
            this.panKhach.Size = new System.Drawing.Size(977, 635);
            this.panKhach.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Peru;
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BorderColor = System.Drawing.Color.Silver;
            this.buttonDelete.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(680, 537);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextColor = System.Drawing.Color.Black;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.Peru;
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BorderColor = System.Drawing.Color.Silver;
            this.buttonUp.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(201, 537);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUp.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUp.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUp.Size = new System.Drawing.Size(80, 30);
            this.buttonUp.TabIndex = 19;
            this.buttonUp.Text = "...";
            this.buttonUp.TextColor = System.Drawing.Color.Black;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
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
            this.listStaff.Size = new System.Drawing.Size(957, 441);
            this.listStaff.TabIndex = 1;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            this.listStaff.View = System.Windows.Forms.View.Details;
            this.listStaff.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listStaff_ColumnClick);
            this.listStaff.DoubleClick += new System.EventHandler(this.listStaff_DoubleClick);
            this.listStaff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listStaff_MouseClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(397, 16);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(180, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "LIST STAFF";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 598);
            this.Controls.Add(this.panKhach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "showStaffForm";
            this.Text = "STAFF";
            this.panKhach.ResumeLayout(false);
            this.panKhach.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panKhach;
        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC buttonUp;
        private ePOSOne.btnProduct.Button_WOC buttonDelete;
    }
}