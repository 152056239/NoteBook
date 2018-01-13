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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form register = new Register();
            register.ShowDialog();
            
        }
        //登录功能的实现
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string strcom = "select *from tbl_Users";
            MySqlCommand cmd = new MySqlCommand(strcom, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            //MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //ada.Fill(ds);//查询结果填充数据集
            //读取datareader中的内容
            bool flag=false;
            while (mdr.Read())
            {

                if ((txtUsername.Text.Equals(mdr["UserName"].ToString().Trim())) && (txtPassword.Text.Equals(mdr["Password"].ToString().Trim())))
                {
                    Form main = new Main(txtUsername.Text);
                    this.Hide();
                    main.ShowDialog();
                    flag = true;
                    break;
                }
               
            }
            con.Close();//关闭连接
            if (!flag) { 
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
