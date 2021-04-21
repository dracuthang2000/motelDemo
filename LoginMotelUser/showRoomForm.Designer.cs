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
            this.panRoom = new System.Windows.Forms.Panel();
            this.buttonDelete = new ePOSOne.btnProduct.Button_WOC();
            this.buttonUp = new ePOSOne.btnProduct.Button_WOC();
            this.labPage = new System.Windows.Forms.Label();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRoom
            // 
            this.panRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panRoom.BackgroundImage")));
            this.panRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panRoom.Controls.Add(this.buttonDelete);
            this.panRoom.Controls.Add(this.buttonUp);
            this.panRoom.Controls.Add(this.labPage);
            this.panRoom.Controls.Add(this.butLeft);
            this.panRoom.Controls.Add(this.butRight);
            this.panRoom.Controls.Add(this.textSearch);
            this.panRoom.Controls.Add(this.labSearch);
            this.panRoom.Controls.Add(this.listRoom);
            this.panRoom.Controls.Add(this.labTieuDe);
            this.panRoom.Location = new System.Drawing.Point(-2, 1);
            this.panRoom.Name = "panRoom";
            this.panRoom.Size = new System.Drawing.Size(978, 664);
            this.panRoom.TabIndex = 1;
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
            this.buttonDelete.Location = new System.Drawing.Point(607, 592);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 19;
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
            this.buttonUp.Location = new System.Drawing.Point(250, 592);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonUp.OnHoverButtonColor = System.Drawing.Color.Turquoise;
            this.buttonUp.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUp.Size = new System.Drawing.Size(80, 30);
            this.buttonUp.TabIndex = 18;
            this.buttonUp.Text = "...";
            this.buttonUp.TextColor = System.Drawing.Color.Black;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labPage
            // 
            this.labPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(441, 530);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(65, 17);
            this.labPage.TabIndex = 11;
            this.labPage.Text = "Page 0/0";
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(11, 524);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(885, 520);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(116, 63);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(36, 66);
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
            this.listRoom.FullRowSelect = true;
            this.listRoom.GridLines = true;
            this.listRoom.HideSelection = false;
            this.listRoom.LabelEdit = true;
            this.listRoom.Location = new System.Drawing.Point(11, 102);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(958, 416);
            this.listRoom.TabIndex = 1;
            this.listRoom.UseCompatibleStateImageBehavior = false;
            this.listRoom.View = System.Windows.Forms.View.Details;
            this.listRoom.DoubleClick += new System.EventHandler(this.listRoom_DoubleClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(314, 7);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(287, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "LIST MOTEL ROOM";
            // 
            // showRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 661);
            this.Controls.Add(this.panRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showRoomForm";
            this.Text = "ROOM";
            this.panRoom.ResumeLayout(false);
            this.panRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRoom;
        private System.Windows.Forms.ListView listRoom;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Label labPage;
        private ePOSOne.btnProduct.Button_WOC buttonUp;
        private ePOSOne.btnProduct.Button_WOC buttonDelete;
    }
}