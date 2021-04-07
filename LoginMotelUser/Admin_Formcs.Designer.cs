namespace LoginMotelUser
{
    partial class Admin_Formcs
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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateuserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 442);
            this.panel2.TabIndex = 14;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "Password";
            this.PassWord.HeaderText = "Pass Word";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            this.PassWord.Width = 125;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Role";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 125;
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtUserMenuItem,
            this.insertCustomerMenuItem});
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newMenuItem.Text = "New";
            // 
            // newtUserMenuItem
            // 
            this.newtUserMenuItem.Name = "newtUserMenuItem";
            this.newtUserMenuItem.Size = new System.Drawing.Size(155, 26);
            this.newtUserMenuItem.Text = "Users";
            this.newtUserMenuItem.Click += new System.EventHandler(this.insertUserToolStripMenuItem_Click);
            // 
            // insertCustomerMenuItem
            // 
            this.insertCustomerMenuItem.Name = "insertCustomerMenuItem";
            this.insertCustomerMenuItem.Size = new System.Drawing.Size(155, 26);
            this.insertCustomerMenuItem.Text = "Customer";
            this.insertCustomerMenuItem.Click += new System.EventHandler(this.inserCustomerToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(122, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editMenuItem.Text = "Edit";
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateuserMenuItem});
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateMenuItem.Text = "Update";
            // 
            // updateuserMenuItem
            // 
            this.updateuserMenuItem.Name = "updateuserMenuItem";
            this.updateuserMenuItem.Size = new System.Drawing.Size(121, 26);
            this.updateuserMenuItem.Text = "User";
            this.updateuserMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1225, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Admin_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Formcs";
            this.Text = "Admin_Formcs";
            this.Load += new System.EventHandler(this.Admin_Formcs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateuserMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}