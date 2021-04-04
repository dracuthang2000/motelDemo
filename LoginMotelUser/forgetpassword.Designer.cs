namespace LoginMotelUser
{
    partial class forgetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetpassword));
            this.text_idCard = new System.Windows.Forms.TextBox();
            this.textdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.checkIdanddate = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.eyesVerifypass = new System.Windows.Forms.Panel();
            this.eyeNewpassword = new System.Windows.Forms.Panel();
            this.noteyesnewpass = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textVerifyPassword = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.incorrectPass = new System.Windows.Forms.Panel();
            this.correctPass = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_idCard
            // 
            this.text_idCard.Location = new System.Drawing.Point(134, 56);
            this.text_idCard.Name = "text_idCard";
            this.text_idCard.Size = new System.Drawing.Size(207, 22);
            this.text_idCard.TabIndex = 0;
            // 
            // textdate
            // 
            this.textdate.Location = new System.Drawing.Point(134, 101);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(207, 22);
            this.textdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indentity card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(124, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "FORGET PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Controls.Add(this.checkIdanddate);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.textdate);
            this.panel1.Controls.Add(this.text_idCard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 276);
            this.panel1.TabIndex = 5;
            // 
            // checkUsername
            // 
            this.checkUsername.AutoSize = true;
            this.checkUsername.ForeColor = System.Drawing.Color.Red;
            this.checkUsername.Location = new System.Drawing.Point(99, 140);
            this.checkUsername.Name = "checkUsername";
            this.checkUsername.Size = new System.Drawing.Size(154, 17);
            this.checkUsername.TabIndex = 8;
            this.checkUsername.Text = "User name is not exists";
            this.checkUsername.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "User name";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(134, 20);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(207, 22);
            this.textUsername.TabIndex = 6;
            // 
            // checkIdanddate
            // 
            this.checkIdanddate.AutoSize = true;
            this.checkIdanddate.ForeColor = System.Drawing.Color.Red;
            this.checkIdanddate.Location = new System.Drawing.Point(99, 140);
            this.checkIdanddate.Name = "checkIdanddate";
            this.checkIdanddate.Size = new System.Drawing.Size(231, 17);
            this.checkIdanddate.TabIndex = 5;
            this.checkIdanddate.Text = "Indentity or date of birth is incorrect";
            this.checkIdanddate.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(88, 205);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(242, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPassword.Controls.Add(this.correctPass);
            this.panelPassword.Controls.Add(this.incorrectPass);
            this.panelPassword.Controls.Add(this.noteyesnewpass);
            this.panelPassword.Controls.Add(this.eyesVerifypass);
            this.panelPassword.Controls.Add(this.eyeNewpassword);
            this.panelPassword.Controls.Add(this.panel3);
            this.panelPassword.Controls.Add(this.buttonOk);
            this.panelPassword.Controls.Add(this.label7);
            this.panelPassword.Controls.Add(this.label6);
            this.panelPassword.Controls.Add(this.textVerifyPassword);
            this.panelPassword.Controls.Add(this.textPassword);
            this.panelPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelPassword.Location = new System.Drawing.Point(36, 72);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(445, 276);
            this.panelPassword.TabIndex = 6;
            this.panelPassword.Visible = false;
            // 
            // eyesVerifypass
            // 
            this.eyesVerifypass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.eyesVerifypass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyesVerifypass.BackgroundImage")));
            this.eyesVerifypass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyesVerifypass.Location = new System.Drawing.Point(339, 113);
            this.eyesVerifypass.Name = "eyesVerifypass";
            this.eyesVerifypass.Size = new System.Drawing.Size(25, 20);
            this.eyesVerifypass.TabIndex = 11;
            this.eyesVerifypass.Visible = false;
            this.eyesVerifypass.Click += new System.EventHandler(this.eyesVerifypass_Click);
            // 
            // eyeNewpassword
            // 
            this.eyeNewpassword.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.eyeNewpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeNewpassword.BackgroundImage")));
            this.eyeNewpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeNewpassword.Location = new System.Drawing.Point(339, 55);
            this.eyeNewpassword.Name = "eyeNewpassword";
            this.eyeNewpassword.Size = new System.Drawing.Size(25, 20);
            this.eyeNewpassword.TabIndex = 11;
            this.eyeNewpassword.Visible = false;
            this.eyeNewpassword.Click += new System.EventHandler(this.eyeNewpassword_Click);
            // 
            // noteyesnewpass
            // 
            this.noteyesnewpass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.noteyesnewpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noteyesnewpass.BackgroundImage")));
            this.noteyesnewpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteyesnewpass.Location = new System.Drawing.Point(339, 55);
            this.noteyesnewpass.Name = "noteyesnewpass";
            this.noteyesnewpass.Size = new System.Drawing.Size(25, 20);
            this.noteyesnewpass.TabIndex = 10;
            this.noteyesnewpass.Click += new System.EventHandler(this.noteyesnewpass_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(339, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 20);
            this.panel3.TabIndex = 10;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(112, 209);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(205, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Verify password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "New password";
            // 
            // textVerifyPassword
            // 
            this.textVerifyPassword.Location = new System.Drawing.Point(187, 112);
            this.textVerifyPassword.Name = "textVerifyPassword";
            this.textVerifyPassword.PasswordChar = '*';
            this.textVerifyPassword.Size = new System.Drawing.Size(146, 22);
            this.textVerifyPassword.TabIndex = 2;
            this.textVerifyPassword.TextChanged += new System.EventHandler(this.textVerifyPassword_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(187, 53);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(146, 22);
            this.textPassword.TabIndex = 1;
            // 
            // incorrectPass
            // 
            this.incorrectPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("incorrectPass.BackgroundImage")));
            this.incorrectPass.Location = new System.Drawing.Point(370, 113);
            this.incorrectPass.Name = "incorrectPass";
            this.incorrectPass.Size = new System.Drawing.Size(25, 22);
            this.incorrectPass.TabIndex = 12;
            this.incorrectPass.Visible = false;
            // 
            // correctPass
            // 
            this.correctPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("correctPass.BackgroundImage")));
            this.correctPass.Location = new System.Drawing.Point(370, 113);
            this.correctPass.Name = "correctPass";
            this.correctPass.Size = new System.Drawing.Size(25, 22);
            this.correctPass.TabIndex = 12;
            this.correctPass.Visible = false;
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 383);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "forgetpassword";
            this.Text = "createpassword";
            this.Load += new System.EventHandler(this.createpassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_idCard;
        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label checkIdanddate;
        private System.Windows.Forms.Label checkUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel eyeNewpassword;
        private System.Windows.Forms.Panel noteyesnewpass;
        private System.Windows.Forms.Panel eyesVerifypass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textVerifyPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Panel correctPass;
        private System.Windows.Forms.Panel incorrectPass;
    }
}