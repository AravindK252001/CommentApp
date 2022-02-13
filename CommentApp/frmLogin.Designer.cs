
namespace CommentApp
{
    partial class frmLogin
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.txtIcon2 = new System.Windows.Forms.PictureBox();
            this.txtIcon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Tomato;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(82, 400);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(216, 62);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the\r\n Comment App";
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoginUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserName.ForeColor = System.Drawing.Color.Black;
            this.txtLoginUserName.Location = new System.Drawing.Point(712, 277);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(202, 20);
            this.txtLoginUserName.TabIndex = 1;
            this.txtLoginUserName.Enter += new System.EventHandler(this.txtLoginUserName_Enter);
            this.txtLoginUserName.Leave += new System.EventHandler(this.txtLoginUserName_Leave);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.Location = new System.Drawing.Point(711, 400);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(202, 20);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.Enter += new System.EventHandler(this.txtLoginPassword_Enter);
            this.txtLoginPassword.Leave += new System.EventHandler(this.txtLoginPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "New User ?";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRegister.Location = new System.Drawing.Point(779, 631);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 21);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register Here";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sign In";
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.AutoSize = true;
            this.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnForgotPassword.Location = new System.Drawing.Point(761, 469);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(171, 21);
            this.btnForgotPassword.TabIndex = 4;
            this.btnForgotPassword.Text = "Forgot Password?";
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(684, 512);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(228, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::CommentApp.Properties.Resources.Application_Exit;
            this.btnExit.Location = new System.Drawing.Point(975, -4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 67);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 34;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Icon2
            // 
            this.Icon2.Image = global::CommentApp.Properties.Resources.key;
            this.Icon2.Location = new System.Drawing.Point(664, 395);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(30, 30);
            this.Icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon2.TabIndex = 11;
            this.Icon2.TabStop = false;
            // 
            // Icon1
            // 
            this.Icon1.Image = global::CommentApp.Properties.Resources.msg;
            this.Icon1.Location = new System.Drawing.Point(668, 274);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(30, 30);
            this.Icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon1.TabIndex = 10;
            this.Icon1.TabStop = false;
            // 
            // txtIcon2
            // 
            this.txtIcon2.Image = global::CommentApp.Properties.Resources.Textbox;
            this.txtIcon2.Location = new System.Drawing.Point(645, 377);
            this.txtIcon2.Name = "txtIcon2";
            this.txtIcon2.Size = new System.Drawing.Size(287, 71);
            this.txtIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon2.TabIndex = 4;
            this.txtIcon2.TabStop = false;
            // 
            // txtIcon1
            // 
            this.txtIcon1.Image = global::CommentApp.Properties.Resources.Textbox;
            this.txtIcon1.Location = new System.Drawing.Point(645, 255);
            this.txtIcon1.Name = "txtIcon1";
            this.txtIcon1.Size = new System.Drawing.Size(287, 71);
            this.txtIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon1.TabIndex = 3;
            this.txtIcon1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CommentApp.Properties.Resources.Login_User_Image;
            this.pictureBox2.Location = new System.Drawing.Point(698, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::CommentApp.Properties.Resources.Login_Image_Edited;
            this.pbBackground.Location = new System.Drawing.Point(-1, -91);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(482, 875);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 687);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.txtIcon2);
            this.Controls.Add(this.txtIcon1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
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

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox txtIcon1;
        private System.Windows.Forms.PictureBox txtIcon2;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnRegister;
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnForgotPassword;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

