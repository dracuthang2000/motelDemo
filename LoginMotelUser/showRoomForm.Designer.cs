namespace LoginMotelUser
{
    partial class showRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showRoomForm));
            this.labPage = new System.Windows.Forms.Label();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.buttonCancle = new ePOSOne.btnProduct.Button_WOC();
            this.buttonDelete = new ePOSOne.btnProduct.Button_WOC();
            this.buttonUp = new ePOSOne.btnProduct.Button_WOC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labPage
            // 
            this.labPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(478, 528);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(65, 17);
            this.labPage.TabIndex = 11;
            this.labPage.Text = "Page 0/0";
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(3, 531);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(936, 528);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(86, 47);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(3, 50);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(61, 17);
            this.labSearch.TabIndex = 7;
            this.labSearch.Text = "Search: ";
            // 
            // listRoom
            // 
            this.listRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listRoom.FullRowSelect = true;
            this.listRoom.GridLines = true;
            this.listRoom.HideSelection = false;
            this.listRoom.LabelEdit = true;
            this.listRoom.Location = new System.Drawing.Point(3, 70);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(1008, 455);
            this.listRoom.TabIndex = 1;
            this.listRoom.UseCompatibleStateImageBehavior = false;
            this.listRoom.View = System.Windows.Forms.View.Details;
            this.listRoom.DoubleClick += new System.EventHandler(this.listRoom_DoubleClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(387, 10);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(287, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "LIST MOTEL ROOM";
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
            this.buttonCancle.Location = new System.Drawing.Point(700, 595);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonCancle.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonCancle.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonCancle.Size = new System.Drawing.Size(80, 40);
            this.buttonCancle.TabIndex = 20;
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
            this.buttonDelete.Location = new System.Drawing.Point(481, 595);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonDelete.Size = new System.Drawing.Size(80, 40);
            this.buttonDelete.TabIndex = 19;
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
            this.buttonUp.Location = new System.Drawing.Point(194, 595);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUp.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUp.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUp.Size = new System.Drawing.Size(80, 40);
            this.buttonUp.TabIndex = 18;
            this.buttonUp.Text = "...";
            this.buttonUp.TextColor = System.Drawing.Color.Black;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.buttonCancle);
            this.panel2.Controls.Add(this.labTieuDe);
            this.panel2.Controls.Add(this.butRight);
            this.panel2.Controls.Add(this.buttonUp);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.labPage);
            this.panel2.Controls.Add(this.listRoom);
            this.panel2.Controls.Add(this.labSearch);
            this.panel2.Controls.Add(this.textSearch);
            this.panel2.Controls.Add(this.butLeft);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 661);
            this.panel2.TabIndex = 22;
            // 
            // showRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 661);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showRoomForm";
            this.Text = "ROOM";
            this.MaximumSizeChanged += new System.EventHandler(this.showRoomForm_MaximumSizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listRoom;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Label labPage;
        private ePOSOne.btnProduct.Button_WOC buttonUp;
        private ePOSOne.btnProduct.Button_WOC buttonDelete;
        private ePOSOne.btnProduct.Button_WOC buttonCancle;
        private System.Windows.Forms.Panel panel2;
    }
}