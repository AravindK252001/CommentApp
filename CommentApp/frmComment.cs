using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentApp
{
    public partial class frmComment : Form
    {
        Function fn = new Function();
        string query;
        
        public frmComment(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void btnComSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        public void dgv()
        {
            query = "select Username,Comment from commenttable";
            DataSet ds = fn.getData(query);
            dgvComments.DataSource = ds.Tables[0];                       
        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            try
            {
                lblWelcome.Parent = pbBackground;
                lblComment.Parent = pbBackground;
                lblUser.Parent = pbBackground;
                lblUser.BackColor = Color.Transparent;
                lblComment.BackColor = Color.Transparent;
                lblWelcome.BackColor = Color.Transparent;
                btnComShowAll.SendToBack();
                dgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(rtxtComment.Text.Length==0)
                {
                    MessageBox.Show("Please enter a comment.", "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string comment = rtxtComment.Text;
                query = "update commenttable set Comment='" + rtxtComment.Text + "' where Username='" + lblUser.Text + "'";
                fn.setData(query, "Comment added.");
                rtxtComment.Text = null;
                dgv();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Thrown: "+ex.Message, "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComFilter_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select Username,Comment from commenttable where Username ='" + lblUser.Text + "'";
                DataSet ds = fn.getData(query);
                dgvComments.DataSource = ds.Tables[0];
                btnComFilter.SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select Username,Comment from commenttable";
                DataSet ds = fn.getData(query);
                dgvComments.DataSource = ds.Tables[0];
                btnComShowAll.SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message, "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
