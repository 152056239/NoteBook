using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Notebook
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }
        public Personal(string name) {
            InitializeComponent();
            lbUsername.Text = name;
        }
        private void btnLook_Click(object sender, EventArgs e)
        {
            
            txtPassword.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelNumber.ReadOnly = true;
            btnSave.Visible = false;
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string qurey = "select * from tbl_users where userName='" + lbUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(qurey, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                txtuserName.Text = mdr["userName"].ToString();
                txtPassword.Text = mdr["Password"].ToString();
                txtEmail.Text = mdr["Email"].ToString();
                txtTelNumber.Text = mdr["TelNumber"].ToString();
            }
            else {
                MessageBox.Show("您没有权限！");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string qurey = "select * from tbl_users where userName='" + lbUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(qurey, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                txtuserName.Text = mdr["userName"].ToString();
                txtPassword.Text = mdr["Password"].ToString();
                txtEmail.Text = mdr["Email"].ToString();
                txtTelNumber.Text = mdr["TelNumber"].ToString();
            }
            txtPassword.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelNumber.ReadOnly = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Equals("") || txtPassword.Text == null)
            {
                MessageBox.Show("密码不能为空！");
            }
            else {
                string connString = Properties.Settings.Default.ConnectionString;
                MySqlConnection con = new MySqlConnection(connString);//实例化链接
                con.Open();//开启连接
                string update = "update tbl_users set Password ='" + txtPassword.Text + "',Email='" + txtEmail.Text + "',TelNumber='" + txtTelNumber.Text + "' where userName='" + txtuserName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("保存成功！");
            }
           
        }

        private void main_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form main = new Main(lbUsername.Text);
            main.ShowDialog();
        }
    }
}
