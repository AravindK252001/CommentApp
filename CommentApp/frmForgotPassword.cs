using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentApp
{
    public partial class frmForgotPassword : Form
    {
        Function fn = new Function();
        string query;

        public frmForgotPassword()
        {
            InitializeComponent();
        }

        public void clearall()
        {
            txtFpUserName.Text = "E-mail Address";
            txtFpSecret.Text = "Type Your Secret Code";
            txtFpNewPassword.Text = "New Password";
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            try
            {
                lblWelcome.Parent = pbBackground;
                lblWelcome.BackColor = Color.Transparent;
                txtFpUserName.Text = "E-mail Address";
                txtFpSecret.Text = "Type Your Secret Code";
                txtFpNewPassword.Text = "New Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFpUserName_Enter(object sender, EventArgs e)
        {
            if (txtFpUserName.Text == "E-mail Address")
            {
                txtFpUserName.Text = "";
            }
        }

        private void txtFpUserName_Leave(object sender, EventArgs e)
        {
            if (txtFpUserName.Text == "")
            {
                txtFpUserName.Text = "E-mail Address";
            }
        }

        private void txtFpSecret_Enter(object sender, EventArgs e)
        {
            if (txtFpSecret.Text == "Type Your Secret Code")
            {
                txtFpSecret.Text = "";
            }
        }

        private void txtFpSecret_Leave(object sender, EventArgs e)
        {
            if (txtFpSecret.Text == "")
            {
                txtFpSecret.Text = "Type Your Secret Code";
            }
        }

        private void txtFpNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtFpNewPassword.Text == "New Password")
            {
                txtFpNewPassword.Text = "";
            }
        }

        private void txtFpNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtFpNewPassword.Text == "")
            {
                txtFpNewPassword.Text = "New Password";
            }
        }

        private void btnGetBack_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {                
                query = "select * from commenttable where Username ='" + txtFpUserName.Text + "' and Secretcode='" + txtFpSecret.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String password = txtFpNewPassword.Text;
                    query = "update commenttable set Pass = '" + password + "' where Username = '"+txtFpUserName.Text+"'";
                    fn.setData(query, "Password changed successfully.!");
                    clearall();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Secret Code.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        
    }
}
