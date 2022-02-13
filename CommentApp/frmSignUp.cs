using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentApp
{
    public partial class frmSignUp : Form
    {
        Function fn = new Function();
        string query;

        public frmSignUp()
        {
            InitializeComponent();
        }

        public void clearall()
        {
            txtSuUserName.Text = "E-mail Address";
            txtSuPassword.Text = "Password";
            txtSuSecret.Text = "Secret Code";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }               

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmLogin ln = new frmLogin();
            ln.Show();
            this.Hide();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            try
            {
                lblWelcome.Parent = pbBackground;
                lblWelcome.BackColor = Color.Transparent;
                txtSuUserName.Text = "E-mail Address";
                txtSuPassword.Text = "Password";
                txtSuSecret.Text = "Secret Code";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSuUserName_Enter(object sender, EventArgs e)
        {
            if (txtSuUserName.Text == "E-mail Address")
            {
                txtSuUserName.Text = "";
            }
        }

        private void txtSuUserName_Leave(object sender, EventArgs e)
        {
            if (txtSuUserName.Text == "")
            {
                txtSuUserName.Text = "E-mail Address";
            }
        }

        private void txtSuPassword_Enter(object sender, EventArgs e)
        {
            if (txtSuPassword.Text == "Password")
            {
                txtSuPassword.Text = "";
            }
        }

        private void txtSuPassword_Leave(object sender, EventArgs e)
        {
            if (txtSuPassword.Text == "")
            {
                txtSuPassword.Text = "Password";
            }
        }

        private void txtSuSecret_Enter(object sender, EventArgs e)
        {
            if (txtSuSecret.Text == "Secret Code")
            {
                txtSuSecret.Text = "";
            }
        }

        private void txtSuSecret_Leave(object sender, EventArgs e)
        {
            if (txtSuSecret.Text == "")
            {
                txtSuSecret.Text = "Secret Code";
            }
        }

        public bool IsEmailValid()
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool blnIsValidEmailId = regex.IsMatch(txtSuUserName.Text.Trim());
            if (!blnIsValidEmailId)
            {
                MessageBox.Show("Please enter a Valid Email Id. (Eg:abc@gmail.com)", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSuUserName.Focus();
                return false;
            }

            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = IsEmailValid();
                if (valid)
                {
                    string username = txtSuUserName.Text;
                    string password = txtSuPassword.Text;
                    string secret = txtSuSecret.Text;

                    try
                    {
                        query = "insert into commenttable (Username,Pass,Secretcode) values ('" + username + "','" + password + "','" + secret + "')";
                        fn.setData(query, "Sign Up Successful.");
                        clearall();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Username already exists.! ", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSuUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from commenttable where Username='" + txtSuUserName.Text + "'";
                DataSet ds = fn.getData(query);

                if (txtSuUserName.Text.Length != 0)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {                        
                        pbCheck.Image = Properties.Resources.yes;
                    }
                    else
                    {
                        pbCheck.Image = Properties.Resources.no;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        
    }
}
