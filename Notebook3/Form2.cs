using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace Notebook3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
   
        private void Form2_Load(object sender, EventArgs e)
        {
            string str = "server=localhost;user id=root;password=root;database=note;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            //给combox绑定数据
            string strcom = "select * from tbl_type";
            MySqlCommand cmd = new MySqlCommand(strcom, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);//查询结果填充数据集
            cobType.DataSource = ds.Tables[0];
            cobType.DisplayMember = "TypeName";
            cobType.ValueMember = "TypeName";
            cmd = null;
            con.Close();//关闭连接
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /* string str = "server=localhost;user id=root;password=root;database=note;";
             MySqlConnection con = new MySqlConnection(str);//实例化链接
             con.Open();//开启连接
             string strcmd = "insert into tbl_note(notename,notecontent,notetype) values('"+txtName.Text+"','"+txtContent.Text+"','"+cobType.SelectedItem+"')";
             MySqlCommand cmd = new MySqlCommand(strcmd, con);
             cmd.ExecuteNonQuery();
             cmd = null;
             con.Dispose();
             con.Close();//关闭连接
             MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK);*/
            
            
            //新实例初始化 StreamWriter 类为使用 utf-8 编码及默认的缓冲区大小指定的流。
            StreamWriter sw = new StreamWriter(@"D:\All resource\C#\note.txt");
            //将后跟行结束符的字符串写入文本字符串或流。
            sw.WriteLine(txtContent.Text);
            
            //
            sw.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
