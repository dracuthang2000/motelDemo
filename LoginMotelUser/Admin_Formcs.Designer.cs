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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_admin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitUpdateUser = new System.Windows.Forms.Button();
            this.dataUserName = new System.Windows.Forms.DataGridView();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motelmanagerdemoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new LoginMotelUser.motel_manager_demoDataSet1TableAdapters.USERTableAdapter();
            this.rOLETableAdapter = new LoginMotelUser.motel_manager_demoDataSet1TableAdapters.ROLETableAdapter();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motel_manager_demoDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelmanagerdemoDataSet1BindingSource)).BeginInit();
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
            // rOLEBindingSource2
            // 
            this.rOLEBindingSource2.DataMember = "ROLE";
            this.rOLEBindingSource2.DataSource = this.motel_manager_demoDataSet1;
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
            this.menuFile,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1225, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Crt+N";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Tag = "";
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+N";
            this.newUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.updateUserToolStripMenuItem.Text = "Update and Delete user";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.dataUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUserName.AutoGenerateColumns = false;
            this.dataUserName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUserName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUserName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.PassWord,
            this.idRole});
            this.dataUserName.DataSource = this.uSERBindingSource;
            this.dataUserName.Location = new System.Drawing.Point(3, 162);
            this.dataUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataUserName.Name = "dataUserName";
            this.dataUserName.ReadOnly = true;
            this.dataUserName.RowHeadersWidth = 51;
            this.dataUserName.RowTemplate.Height = 24;
            this.dataUserName.Size = new System.Drawing.Size(1223, 294);
            this.dataUserName.TabIndex = 1;
            this.dataUserName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.motelmanagerdemoDataSet1BindingSource;
            // 
            // motelmanagerdemoDataSet1BindingSource
            // 
            this.motelmanagerdemoDataSet1BindingSource.DataSource = this.motel_manager_demoDataSet1;
            this.motelmanagerdemoDataSet1BindingSource.Position = 0;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // rOLETableAdapter
            // 
            this.rOLETableAdapter.ClearBeforeFill = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "userName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "password";
            this.PassWord.HeaderText = "Pass Word";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            // 
            // idRole
            // 
            this.idRole.DataPropertyName = "Name";
            this.idRole.HeaderText = "Role";
            this.idRole.MinimumWidth = 6;
            this.idRole.Name = "idRole";
            this.idRole.ReadOnly = true;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewChartToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewChartToolStripMenuItem
            // 
            this.viewChartToolStripMenuItem.Name = "viewChartToolStripMenuItem";
            this.viewChartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewChartToolStripMenuItem.Text = "View Chart";
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
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelmanagerdemoDataSet1BindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource motelmanagerdemoDataSet1BindingSource;
        private motel_manager_demoDataSet1 motel_manager_demoDataSet1;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private motel_manager_demoDataSet1TableAdapters.USERTableAdapter uSERTableAdapter;
        private motel_manager_demoDataSet1TableAdapters.ROLETableAdapter rOLETableAdapter;
        private System.Windows.Forms.BindingSource rOLEBindingSource2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button exitUpdateUser;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRole;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewChartToolStripMenuItem;
    }
}