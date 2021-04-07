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
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.motel_manager_demoDataSet1 = new LoginMotelUser.motel_manager_demoDataSet1();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rOLETableAdapter = new LoginMotelUser.motel_manager_demoDataSet1TableAdapters.ROLETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERTableAdapter = new LoginMotelUser.motel_manager_demoDataSet1TableAdapters.USERTableAdapter();
            this.motelManagerDataSet = new LoginMotelUser.MotelManagerDataSet();
            this.uSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.USERTableAdapter();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rOLETableAdapter1 = new LoginMotelUser.MotelManagerDataSetTableAdapters.ROLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.motel_manager_demoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(97, 141);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(285, 22);
            this.textPassword.TabIndex = 0;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(97, 87);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(285, 22);
            this.textUsername.TabIndex = 1;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.rOLEBindingSource1;
            this.roleComboBox.DisplayMember = "RoleName";
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(97, 202);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(148, 24);
            this.roleComboBox.TabIndex = 2;
            this.roleComboBox.ValueMember = "id";
            // 
            // motel_manager_demoDataSet1
            // 
            this.motel_manager_demoDataSet1.DataSetName = "motel_manager_demoDataSet1";
            this.motel_manager_demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInsert.Location = new System.Drawing.Point(0, 470);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancle.Location = new System.Drawing.Point(307, 470);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(75, 23);
            this.buttonCancle.TabIndex = 4;
            this.buttonCancle.Text = "Cancle";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
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
            // rOLETableAdapter
            // 
            this.rOLETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.uSERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(388, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 406);
            this.dataGridView1.TabIndex = 9;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // motelManagerDataSet
            // 
            this.motelManagerDataSet.DataSetName = "MotelManagerDataSet";
            this.motelManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoleName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Role";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // rOLEBindingSource1
            // 
            this.rOLEBindingSource1.DataMember = "ROLE";
            this.rOLEBindingSource1.DataSource = this.motelManagerDataSet;
            // 
            // rOLETableAdapter1
            // 
            this.rOLETableAdapter1.ClearBeforeFill = true;
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textPassword);
            this.MaximizeBox = false;
            this.Name = "New_User";
            this.Text = "New_User";
            this.Load += new System.EventHandler(this.New_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motel_manager_demoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motelManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private motel_manager_demoDataSet1 motel_manager_demoDataSet1;
        private motel_manager_demoDataSet1TableAdapters.ROLETableAdapter rOLETableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private motel_manager_demoDataSet1TableAdapters.USERTableAdapter uSERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private MotelManagerDataSet motelManagerDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource1;
        private MotelManagerDataSetTableAdapters.USERTableAdapter uSERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource rOLEBindingSource1;
        private MotelManagerDataSetTableAdapters.ROLETableAdapter rOLETableAdapter1;
    }
}