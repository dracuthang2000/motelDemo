namespace LoginMotelUser
{
    partial class New_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_User));
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.rOLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motelManagerDataSet = new LoginMotelUser.MotelManagerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.USERTableAdapter();
            this.rOLETableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.ROLETableAdapter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIn = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(103, 78);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(285, 24);
            this.textPassword.TabIndex = 0;
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(103, 27);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(285, 24);
            this.textUsername.TabIndex = 1;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.rOLEBindingSource1;
            this.roleComboBox.DisplayMember = "RoleName";
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(103, 129);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(148, 26);
            this.roleComboBox.TabIndex = 2;
            this.roleComboBox.ValueMember = "id";
            // 
            // rOLEBindingSource1
            // 
            this.rOLEBindingSource1.DataMember = "ROLE";
            this.rOLEBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // motelManagerDataSet
            // 
            this.motelManagerDataSet.DataSetName = "MotelManagerDataSet";
            this.motelManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(360, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "CREATE NEW USER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(452, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 406);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // uSERBindingSource1
            // 
            this.uSERBindingSource1.DataMember = "USER";
            this.uSERBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // uSERTableAdapter1
            // 
            this.uSERTableAdapter1.ClearBeforeFill = true;
            // 
            // rOLETableAdapter1
            // 
            this.rOLETableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(110, 30);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortToolStripMenuItem.Image")));
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // buttonIn
            // 
            this.buttonIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonIn.BorderColor = System.Drawing.Color.Silver;
            this.buttonIn.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonIn.FlatAppearance.BorderSize = 0;
            this.buttonIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.Location = new System.Drawing.Point(3, 376);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonIn.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonIn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonIn.Size = new System.Drawing.Size(80, 30);
            this.buttonIn.TabIndex = 21;
            this.buttonIn.Text = "UPDATE";
            this.buttonIn.TextColor = System.Drawing.Color.Black;
            this.buttonIn.UseVisualStyleBackColor = false;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
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
            this.button_WOC1.Location = new System.Drawing.Point(321, 373);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(80, 30);
            this.button_WOC1.TabIndex = 22;
            this.button_WOC1.Text = "CANCLE";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.roleComboBox);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.button_WOC1);
            this.panel.Controls.Add(this.textPassword);
            this.panel.Controls.Add(this.buttonIn);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.textUsername);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(9, 87);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(404, 406);
            this.panel.TabIndex = 23;
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 495);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_User";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.New_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private MotelManagerDataSet motelManagerDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource1;
        private MotelManagerDataSetTableAdapters.USERTableAdapter uSERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource rOLEBindingSource1;
        private MotelManagerDataSetTableAdapters.ROLETableAdapter rOLETableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC buttonIn;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Panel panel;
    }
}