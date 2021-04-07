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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Formcs));
            this.roleCombobox = new System.Windows.Forms.ComboBox();
            this.rOLEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.motel_manager_demoDataSet1 = new LoginMotelUser.motel_manager_demoDataSet1();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passWordText = new System.Windows.Forms.TextBox();
            this.userName_text = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateuserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_admin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitUpdateUser = new System.Windows.Forms.Button();
            this.dataUserName = new System.Windows.Forms.DataGridView();
            this.uSERTableAdapter = new LoginMotelUser.motel_manager_demoDataSet1TableAdapters.USERTableAdapter();
            this.rOLETableAdapter = new LoginMotelUser.motel_manager_demoDataSet1TableAdapters.ROLETableAdapter();
            this.motelManagerDataSet = new LoginMotelUser.MotelManagerDataSet();
            this.uSERTableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.USERTableAdapter();
            this.uSERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motel_manager_demoDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // roleCombobox
            // 
            this.roleCombobox.DataSource = this.rOLEBindingSource2;
            this.roleCombobox.DisplayMember = "Name";
            this.roleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCombobox.FormattingEnabled = true;
            this.roleCombobox.Location = new System.Drawing.Point(88, 28);
            this.roleCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleCombobox.Name = "roleCombobox";
            this.roleCombobox.Size = new System.Drawing.Size(140, 24);
            this.roleCombobox.TabIndex = 7;
            this.roleCombobox.ValueMember = "id";
            // 
            // motel_manager_demoDataSet1
            // 
            this.motel_manager_demoDataSet1.DataSetName = "motel_manager_demoDataSet1";
            this.motel_manager_demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteUser
            // 
            this.deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteUser.Location = new System.Drawing.Point(999, 57);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(104, 39);
            this.deleteUser.TabIndex = 6;
            this.deleteUser.Text = "DELETE";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateUser.Enabled = false;
            this.updateUser.Location = new System.Drawing.Point(869, 57);
            this.updateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(104, 39);
            this.updateUser.TabIndex = 6;
            this.updateUser.Text = "UPDATE";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Visible = false;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // addUser
            // 
            this.addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUser.Location = new System.Drawing.Point(748, 57);
            this.addUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(104, 39);
            this.addUser.TabIndex = 6;
            this.addUser.Text = "ADD";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pass word";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passWordText
            // 
            this.passWordText.Location = new System.Drawing.Point(412, 2);
            this.passWordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passWordText.Name = "passWordText";
            this.passWordText.Size = new System.Drawing.Size(245, 22);
            this.passWordText.TabIndex = 3;
            // 
            // userName_text
            // 
            this.userName_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName_text.Location = new System.Drawing.Point(88, 2);
            this.userName_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName_text.Name = "userName_text";
            this.userName_text.Size = new System.Drawing.Size(239, 22);
            this.userName_text.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.roleCombobox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.userName_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.passWordText, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 65);
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.newMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newMenuItem.Text = "New";
            // 
            // newtUserMenuItem
            // 
            this.newtUserMenuItem.Name = "newtUserMenuItem";
            this.newtUserMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newtUserMenuItem.Text = "Users";
            this.newtUserMenuItem.Click += new System.EventHandler(this.insertUserToolStripMenuItem_Click);
            // 
            // insertCustomerMenuItem
            // 
            this.insertCustomerMenuItem.Name = "insertCustomerMenuItem";
            this.insertCustomerMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insertCustomerMenuItem.Text = "Customer";
            this.insertCustomerMenuItem.Click += new System.EventHandler(this.inserCustomerToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // Search_admin
            // 
            this.Search_admin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_admin.Location = new System.Drawing.Point(107, 135);
            this.Search_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_admin.Name = "Search_admin";
            this.Search_admin.Size = new System.Drawing.Size(693, 22);
            this.Search_admin.TabIndex = 11;
            this.Search_admin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.CausesValidation = false;
            this.panel1.Location = new System.Drawing.Point(77, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 22);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.updateUser);
            this.panel2.Controls.Add(this.exitUpdateUser);
            this.panel2.Controls.Add(this.deleteUser);
            this.panel2.Controls.Add(this.addUser);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.dataUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Search_admin);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 442);
            this.panel2.TabIndex = 14;
            // 
            // exitUpdateUser
            // 
            this.exitUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitUpdateUser.Location = new System.Drawing.Point(1122, 58);
            this.exitUpdateUser.Name = "exitUpdateUser";
            this.exitUpdateUser.Size = new System.Drawing.Size(104, 38);
            this.exitUpdateUser.TabIndex = 14;
            this.exitUpdateUser.Text = "ExitUpdate";
            this.exitUpdateUser.UseVisualStyleBackColor = true;
            this.exitUpdateUser.Visible = false;
            this.exitUpdateUser.Click += new System.EventHandler(this.exitUpdateUser_Click);
            // 
            // dataUserName
            // 
            this.dataUserName.ColumnHeadersHeight = 29;
            this.dataUserName.Location = new System.Drawing.Point(36, 205);
            this.dataUserName.Name = "dataUserName";
            this.dataUserName.RowHeadersWidth = 51;
            this.dataUserName.Size = new System.Drawing.Size(240, 150);
            this.dataUserName.TabIndex = 15;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // rOLETableAdapter
            // 
            this.rOLETableAdapter.ClearBeforeFill = true;
            // 
            // motelManagerDataSet
            // 
            this.motelManagerDataSet.DataSetName = "MotelManagerDataSet";
            this.motelManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERTableAdapter1
            // 
            this.uSERTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motel_manager_demoDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passWordText;
        private System.Windows.Forms.TextBox userName_text;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleCombobox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox Search_admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataUserName;
        private motel_manager_demoDataSet1 motel_manager_demoDataSet1;
        private motel_manager_demoDataSet1TableAdapters.USERTableAdapter uSERTableAdapter;
        private motel_manager_demoDataSet1TableAdapters.ROLETableAdapter rOLETableAdapter;
        private System.Windows.Forms.BindingSource rOLEBindingSource2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button exitUpdateUser;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private MotelManagerDataSet motelManagerDataSet;
        private MotelManagerDataSetTableAdapters.USERTableAdapter uSERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.BindingSource uSERBindingSource2;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateuserMenuItem;
    }
}