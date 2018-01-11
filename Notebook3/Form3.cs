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

namespace Notebook3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string str = "server=localhost;user id=root;password=root;database=note;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            //给cobtype绑定数据
            string strcom = "select * from tbl_note";
            MySqlCommand cmd = new MySqlCommand(strcom, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);//查询结果填充数据集
            cobType.DataSource = ds.Tables[0];
            cobType.DisplayMember = "typeName";
            cobType.ValueMember = "typeName";
            cobName.DataSource = ds.Tables[0];
            cobName.DisplayMember = "noteName";
            cobName.ValueMember = "noteName";
            cmd = null;
            con.Close();//关闭连接
        }
    }
}
