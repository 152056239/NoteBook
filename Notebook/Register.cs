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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.ShowDialog();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string qurey = "select *from tbl_users where username='"+txtUsername.Text+"'";
            MySqlCommand cmd = new MySqlCommand(qurey, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("改用户已存在，请重新注册！");
            }
            else {
                if (txtUsername.Text == null || txtUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("用户名不能为空！");
                }
                else {
                    if (txtPassword.Text.Equals("") || txtPassword.Text == null)
                    {
                        MessageBox.Show("密码不能为空！");
                    }
                    else
                    {
                        string insert = "insert into tbl_users(UserName,Password,Email,TelNumber) values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtTelnum.Text + "')";
                        MySqlCommand cmd2 = new MySqlCommand(insert, con);
                        mdr.Close();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK);
                    }
                }
            }
            con.Close();
        }
    }
}
