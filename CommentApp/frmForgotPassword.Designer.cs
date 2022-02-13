
namespace CommentApp
{
    partial class frmForgotPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFpSecret = new System.Windows.Forms.TextBox();
            this.txtFpUserName = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtFpNewPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.txtIcon2 = new System.Windows.Forms.PictureBox();
            this.txtIcon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Forgot Password";
            // 
            // btnGetBack
            // 
            this.btnGetBack.AutoSize = true;
            this.btnGetBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetBack.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBack.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGetBack.Location = new System.Drawing.Point(856, 656);
            this.btnGetBack.Name = "btnGetBack";
            this.btnGetBack.Size = new System.Drawing.Size(76, 21);
            this.btnGetBack.TabIndex = 5;
            this.btnGetBack.Text = "Sign In";
            this.btnGetBack.Click += new System.EventHandler(this.btnGetBack_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Remember Password ?";
            // 
            // txtFpSecret
            // 
            this.txtFpSecret.BackColor = System.Drawing.SystemColors.Window;
            this.txtFpSecret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFpSecret.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFpSecret.ForeColor = System.Drawing.Color.Black;
            this.txtFpSecret.Location = new System.Drawing.Point(723, 371);
            this.txtFpSecret.Name = "txtFpSecret";
            this.txtFpSecret.Size = new System.Drawing.Size(202, 20);
            this.txtFpSecret.TabIndex = 2;
            this.txtFpSecret.Enter += new System.EventHandler(this.txtFpSecret_Enter);
            this.txtFpSecret.Leave += new System.EventHandler(this.txtFpSecret_Leave);
            // 
            // txtFpUserName
            // 
            this.txtFpUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFpUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFpUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFpUserName.ForeColor = System.Drawing.Color.Black;
            this.txtFpUserName.Location = new System.Drawing.Point(720, 262);
            this.txtFpUserName.Name = "txtFpUserName";
            this.txtFpUserName.Size = new System.Drawing.Size(202, 20);
            this.txtFpUserName.TabIndex = 1;
            this.txtFpUserName.Enter += new System.EventHandler(this.txtFpUserName_Enter);
            this.txtFpUserName.Leave += new System.EventHandler(this.txtFpUserName_Leave);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Tomato;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(81, 384);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 31);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Comment App";
            // 
            // txtFpNewPassword
            // 
            this.txtFpNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtFpNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFpNewPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFpNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtFpNewPassword.Location = new System.Drawing.Point(720, 479);
            this.txtFpNewPassword.Name = "txtFpNewPassword";
            this.txtFpNewPassword.Size = new System.Drawing.Size(202, 20);
            this.txtFpNewPassword.TabIndex = 3;
            this.txtFpNewPassword.Enter += new System.EventHandler(this.txtFpNewPassword_Enter);
            this.txtFpNewPassword.Leave += new System.EventHandler(this.txtFpNewPassword_Leave);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::CommentApp.Properties.Resources.Application_Exit;
            this.btnExit.Location = new System.Drawing.Point(975, -4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 67);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 33;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CommentApp.Properties.Resources.Modify_Password;
            this.pictureBox4.Location = new System.Drawing.Point(672, 473);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CommentApp.Properties.Resources.Textbox;
            this.pictureBox3.Location = new System.Drawing.Point(653, 453);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(326, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Icon2
            // 
            this.Icon2.Image = global::CommentApp.Properties.Resources.Secret_Code;
            this.Icon2.Location = new System.Drawing.Point(672, 364);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(30, 30);
            this.Icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon2.TabIndex = 25;
            this.Icon2.TabStop = false;
            // 
            // Icon1
            // 
            this.Icon1.Image = global::CommentApp.Properties.Resources.msg;
            this.Icon1.Location = new System.Drawing.Point(676, 259);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(30, 30);
            this.Icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon1.TabIndex = 24;
            this.Icon1.TabStop = false;
            // 
            // txtIcon2
            // 
            this.txtIcon2.Image = global::CommentApp.Properties.Resources.Textbox;
            this.txtIcon2.Location = new System.Drawing.Point(653, 344);
            this.txtIcon2.Name = "txtIcon2";
            this.txtIcon2.Size = new System.Drawing.Size(326, 71);
            this.txtIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon2.TabIndex = 18;
            this.txtIcon2.TabStop = false;
            // 
            // txtIcon1
            // 
            this.txtIcon1.Image = global::CommentApp.Properties.Resources.Textbox;
            this.txtIcon1.Location = new System.Drawing.Point(653, 240);
            this.txtIcon1.Name = "txtIcon1";
            this.txtIcon1.Size = new System.Drawing.Size(326, 71);
            this.txtIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon1.TabIndex = 17;
            this.txtIcon1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CommentApp.Properties.Resources.Login_User_Image;
            this.pictureBox2.Location = new System.Drawing.Point(706, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::CommentApp.Properties.Resources.Login_Image_Edited;
            this.pbBackground.Location = new System.Drawing.Point(0, -91);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(482, 875);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 14;
            this.pbBackground.TabStop = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(701, 552);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(228, 60);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 687);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtFpNewPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.Controls.Add(this.btnGetBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFpSecret);
            this.Controls.Add(this.txtFpUserName);
            this.Controls.Add(this.txtIcon2);
            this.Controls.Add(this.txtIcon1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.Label btnGetBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFpSecret;
        private System.Windows.Forms.TextBox txtFpUserName;
        private System.Windows.Forms.PictureBox txtIcon2;
        private System.Windows.Forms.PictureBox txtIcon1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtFpNewPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnChangePassword;
    }
}