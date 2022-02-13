
namespace CommentApp
{
    partial class frmComment
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
            this.btnComSubmit = new System.Windows.Forms.Button();
            this.btnComSignOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.btnComFilter = new System.Windows.Forms.Button();
            this.btnComShowAll = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComSubmit
            // 
            this.btnComSubmit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnComSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComSubmit.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComSubmit.ForeColor = System.Drawing.Color.White;
            this.btnComSubmit.Location = new System.Drawing.Point(889, 147);
            this.btnComSubmit.Name = "btnComSubmit";
            this.btnComSubmit.Size = new System.Drawing.Size(172, 60);
            this.btnComSubmit.TabIndex = 33;
            this.btnComSubmit.Text = "Submit";
            this.btnComSubmit.UseVisualStyleBackColor = false;
            this.btnComSubmit.Click += new System.EventHandler(this.btnComSubmit_Click);
            // 
            // btnComSignOut
            // 
            this.btnComSignOut.BackColor = System.Drawing.Color.DarkOrange;
            this.btnComSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComSignOut.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComSignOut.ForeColor = System.Drawing.Color.White;
            this.btnComSignOut.Location = new System.Drawing.Point(795, 605);
            this.btnComSignOut.Name = "btnComSignOut";
            this.btnComSignOut.Size = new System.Drawing.Size(228, 60);
            this.btnComSignOut.TabIndex = 34;
            this.btnComSignOut.Text = "Sign Out";
            this.btnComSignOut.UseVisualStyleBackColor = false;
            this.btnComSignOut.Click += new System.EventHandler(this.btnComSignOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "What would you like to share to this world?";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.DarkOrange;
            this.lblUser.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(184, 482);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 31);
            this.lblUser.TabIndex = 37;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtComment
            // 
            this.rtxtComment.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtComment.Location = new System.Drawing.Point(482, 71);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(401, 149);
            this.rtxtComment.TabIndex = 38;
            this.rtxtComment.Text = "";
            // 
            // btnComFilter
            // 
            this.btnComFilter.BackColor = System.Drawing.Color.DarkOrange;
            this.btnComFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComFilter.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComFilter.ForeColor = System.Drawing.Color.White;
            this.btnComFilter.Location = new System.Drawing.Point(482, 557);
            this.btnComFilter.Name = "btnComFilter";
            this.btnComFilter.Size = new System.Drawing.Size(228, 60);
            this.btnComFilter.TabIndex = 39;
            this.btnComFilter.Text = "Filter My Comments";
            this.btnComFilter.UseVisualStyleBackColor = false;
            this.btnComFilter.Click += new System.EventHandler(this.btnComFilter_Click);
            // 
            // btnComShowAll
            // 
            this.btnComShowAll.BackColor = System.Drawing.Color.DarkOrange;
            this.btnComShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComShowAll.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComShowAll.ForeColor = System.Drawing.Color.White;
            this.btnComShowAll.Location = new System.Drawing.Point(482, 557);
            this.btnComShowAll.Name = "btnComShowAll";
            this.btnComShowAll.Size = new System.Drawing.Size(228, 60);
            this.btnComShowAll.TabIndex = 40;
            this.btnComShowAll.Text = "Show All Comments";
            this.btnComShowAll.UseVisualStyleBackColor = false;
            this.btnComShowAll.Click += new System.EventHandler(this.btnComShowAll_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Tomato;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(24, 482);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(143, 31);
            this.lblWelcome.TabIndex = 42;
            this.lblWelcome.Text = "Welcome:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Tomato;
            this.lblComment.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(60, 252);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(202, 31);
            this.lblComment.TabIndex = 43;
            this.lblComment.Text = "Comment App";
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::CommentApp.Properties.Resources.Login_Image_Edited;
            this.pbBackground.Location = new System.Drawing.Point(-9, -91);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(482, 875);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 41;
            this.pbBackground.TabStop = false;
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.BackgroundColor = System.Drawing.Color.White;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(479, 275);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.Size = new System.Drawing.Size(571, 276);
            this.dgvComments.TabIndex = 44;
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 687);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.btnComShowAll);
            this.Controls.Add(this.btnComFilter);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComSignOut);
            this.Controls.Add(this.btnComSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComment";
            this.Load += new System.EventHandler(this.frmComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComSubmit;
        private System.Windows.Forms.Button btnComSignOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Button btnComFilter;
        private System.Windows.Forms.Button btnComShowAll;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.DataGridView dgvComments;
    }
}