namespace LoginMotelUser
{
    partial class Update_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_User));
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.motelManagerDataSet = new LoginMotelUser.MotelManagerDataSet();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.rOLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uSERTableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.USERTableAdapter();
            this.rOLETableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.ROLETableAdapter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUp = new ePOSOne.btnProduct.Button_WOC();
            this.buttonDelete = new ePOSOne.btnProduct.Button_WOC();
            this.buttonCan = new ePOSOne.btnProduct.Button_WOC();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataUser
            // 
            this.dataUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUser.AutoGenerateColumns = false;
            this.dataUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.IDRole});
            this.dataUser.DataSource = this.uSERBindingSource1;
            this.dataUser.Location = new System.Drawing.Point(361, 94);
            this.dataUser.Name = "dataUser";
            this.dataUser.RowHeadersWidth = 51;
            this.dataUser.RowTemplate.Height = 24;
            this.dataUser.Size = new System.Drawing.Size(664, 410);
            this.dataUser.StandardTab = true;
            this.dataUser.TabIndex = 0;
            this.dataUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataUser_MouseClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
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
            // IDRole
            // 
            this.IDRole.DataPropertyName = "RoleName";
            this.IDRole.HeaderText = "Role";
            this.IDRole.MinimumWidth = 6;
            this.IDRole.Name = "IDRole";
            // 
            // uSERBindingSource1
            // 
            this.uSERBindingSource1.DataMember = "USER";
            this.uSERBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // motelManagerDataSet
            // 
            this.motelManagerDataSet.DataSetName = "MotelManagerDataSet";
            this.motelManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(86, 41);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(238, 22);
            this.textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(86, 86);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(238, 22);
            this.textPassword.TabIndex = 2;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DataSource = this.rOLEBindingSource1;
            this.comboBoxRole.DisplayMember = "RoleName";
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(86, 133);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRole.TabIndex = 3;
            this.comboBoxRole.ValueMember = "id";
            // 
            // rOLEBindingSource1
            // 
            this.rOLEBindingSource1.DataMember = "ROLE";
            this.rOLEBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(429, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "UPDATE USER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(425, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 22);
            this.panel1.TabIndex = 12;
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
            this.sortToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(127, 56);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortToolStripMenuItem.Image")));
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUp.BorderColor = System.Drawing.Color.Silver;
            this.buttonUp.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(4, 377);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUp.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUp.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUp.Size = new System.Drawing.Size(80, 30);
            this.buttonUp.TabIndex = 20;
            this.buttonUp.Text = "UPDATE";
            this.buttonUp.TextColor = System.Drawing.Color.Black;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.BorderColor = System.Drawing.Color.Silver;
            this.buttonDelete.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(115, 377);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextColor = System.Drawing.Color.Black;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // buttonCan
            // 
            this.buttonCan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCan.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCan.BorderColor = System.Drawing.Color.Silver;
            this.buttonCan.ButtonColor = System.Drawing.Color.MediumAquamarine;
            this.buttonCan.FlatAppearance.BorderSize = 0;
            this.buttonCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCan.Location = new System.Drawing.Point(233, 377);
            this.buttonCan.Name = "buttonCan";
            this.buttonCan.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonCan.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonCan.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonCan.Size = new System.Drawing.Size(80, 30);
            this.buttonCan.TabIndex = 22;
            this.buttonCan.Text = "CANCLE";
            this.buttonCan.TextColor = System.Drawing.Color.Black;
            this.buttonCan.UseVisualStyleBackColor = false;
            this.buttonCan.Click += new System.EventHandler(this.buttonCan_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.buttonUp);
            this.panel.Controls.Add(this.buttonDelete);
            this.panel.Controls.Add(this.buttonCan);
            this.panel.Controls.Add(this.comboBoxRole);
            this.panel.Controls.Add(this.textPassword);
            this.panel.Controls.Add(this.textUsername);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label3);
            this.panel.Location = new System.Drawing.Point(11, 94);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 410);
            this.panel.TabIndex = 23;
            // 
            // Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 509);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_User";
            this.Text = "UPDATE USER";
            this.Load += new System.EventHandler(this.Update_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private MotelManagerDataSet motelManagerDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource1;
        private MotelManagerDataSetTableAdapters.USERTableAdapter uSERTableAdapter1;
        private System.Windows.Forms.BindingSource rOLEBindingSource1;
        private MotelManagerDataSetTableAdapters.ROLETableAdapter rOLETableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRole;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private ePOSOne.btnProduct.Button_WOC buttonUp;
        private ePOSOne.btnProduct.Button_WOC buttonDelete;
        private ePOSOne.btnProduct.Button_WOC buttonCan;
        private System.Windows.Forms.Panel panel;
    }
}