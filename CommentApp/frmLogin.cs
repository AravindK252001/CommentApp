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
    public partial class frmLogin : Form
    {
        Function fn = new Function();
        string query;

        public frmLogin()
        {
            InitializeComponent();            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                lblWelcome.Parent = pbBackground;
                lblWelcome.BackColor = Color.Transparent;
                txtLoginUserName.Text = "E-mail Address";
                txtLoginPassword.Text = "Type Your Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLoginUserName_Enter(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text == "E-mail Address")
            {
                txtLoginUserName.Text = "";
            }
        }

        private void txtLoginUserName_Leave(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text == "")
            {
                txtLoginUserName.Text = "E-mail Address";
            }
        }

        private void txtLoginPassword_Enter(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "Type Your Password")
            {
                txtLoginPassword.Text = "";
            }
        }

        private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "")
            {
                txtLoginPassword.Text = "Type Your Password";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmSignUp su = new frmSignUp();
            su.Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword fp = new frmForgotPassword();
            fp.Show();
            this.Hide();            
        }        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from commenttable";
                DataSet ds = fn.getData(query);
                query = "select * from commenttable where Username ='" + txtLoginUserName.Text + "' and Pass='" + txtLoginPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    frmComment com = new frmComment(txtLoginUserName.Text);
                    com.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Thrown: "+ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        
    }
}
