namespace LoginMotelUser
{
    partial class AddParticularServiceForm
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
            this.listService = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listServicePar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textOldIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listService
            // 
            this.listService.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ServiceName,
            this.Price});
            this.listService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listService.FullRowSelect = true;
            this.listService.HideSelection = false;
            this.listService.Location = new System.Drawing.Point(12, 40);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(410, 149);
            this.listService.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listService.TabIndex = 0;
            this.listService.UseCompatibleStateImageBehavior = false;
            this.listService.View = System.Windows.Forms.View.Details;
            this.listService.SelectedIndexChanged += new System.EventHandler(this.listService_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // ServiceName
            // 
            this.ServiceName.Text = "Service Name";
            this.ServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ServiceName.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 150;
            // 
            // textIndex
            // 
            this.textIndex.Location = new System.Drawing.Point(606, 120);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(100, 22);
            this.textIndex.TabIndex = 1;
            this.textIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIndex_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "New index";
            // 
            // textServiceName
            // 
            this.textServiceName.Enabled = false;
            this.textServiceName.Location = new System.Drawing.Point(606, 40);
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.Size = new System.Drawing.Size(100, 22);
            this.textServiceName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Service Name";
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(606, 166);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 4;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Service";
            // 
            // listServicePar
            // 
            this.listServicePar.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listServicePar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listServicePar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listServicePar.FullRowSelect = true;
            this.listServicePar.HideSelection = false;
            this.listServicePar.Location = new System.Drawing.Point(12, 216);
            this.listServicePar.Name = "listServicePar";
            this.listServicePar.Size = new System.Drawing.Size(410, 166);
            this.listServicePar.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listServicePar.TabIndex = 0;
            this.listServicePar.UseCompatibleStateImageBehavior = false;
            this.listServicePar.View = System.Windows.Forms.View.Details;
            this.listServicePar.SelectedIndexChanged += new System.EventHandler(this.listServicePar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Service Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "New index";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Old index";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "REMOVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textOldIndex
            // 
            this.textOldIndex.Enabled = false;
            this.textOldIndex.Location = new System.Drawing.Point(606, 82);
            this.textOldIndex.Name = "textOldIndex";
            this.textOldIndex.Size = new System.Drawing.Size(100, 22);
            this.textOldIndex.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Old index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOldIndex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listServicePar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textServiceName);
            this.Controls.Add(this.textIndex);
            this.Controls.Add(this.listService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listService;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ServiceName;
        private System.Windows.Forms.TextBox textIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textServiceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listServicePar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textOldIndex;
        private System.Windows.Forms.Label label1;
    }
}