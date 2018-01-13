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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Main(string username){
            InitializeComponent();
            lbUsername.Text =username;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            setTreeView(tvSort);
            Console.WriteLine(lbUsername.Text);
        }
        private void setTreeView(TreeView tr1) {
            //初始化treeView
            //初始化根节点
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string qurey = "select *from tbl_type where TypeUsername='"+lbUsername.Text+"'";
            MySqlCommand cmd = new MySqlCommand(qurey, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read()) {
                tvSort.Nodes.Add(mdr["TypeName"].ToString().Trim());
            }
            mdr.Close();
            //初始化子节点
            string qurey2 = "select *from tbl_note where noteUserName='"+lbUsername.Text+"'";
            MySqlCommand cmd2 = new MySqlCommand(qurey2, con);
            MySqlDataReader mdr2 = cmd2.ExecuteReader();
            while (mdr2.Read()) {
                for (int i = 0; i < tvSort.Nodes.Count;i++) 
                {
                    if(tvSort.Nodes[i].Text.Equals(mdr2["noteTypeName"].ToString())){
                        tvSort.Nodes[i].Nodes.Add(mdr2["noteName"].ToString());
                    }
                }
            }
            
        }
        private void 新建笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tvSort.Nodes.Add();
            //加入数据库
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string qurey = "select *from tbl_note where noteName='"+txtName.Text.Trim() +"'and noteUsername='"+lbUsername.Text.Trim()+"'";
            MySqlCommand cmd = new MySqlCommand(qurey, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("文件已存在！");
            }
            else
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    MessageBox.Show("要添加的笔记名称不能为空！");
                    return;
                }
                if (tvSort.SelectedNode == null)
                {
                    MessageBox.Show("请选择你要添加笔记的分类名！");
                }
                else {
                    //添加子节点
                    tvSort.SelectedNode.Nodes.Add(txtName.Text.Trim());
                    string insert = "insert into tbl_note(noteName,noteContent,noteTypeName,noteUserName)values('" + txtName.Text + "','" + rtxtContent.Text + "','" + tvSort.SelectedNode.Text + "','" + lbUsername.Text + "')";
                    MySqlCommand cmd2 = new MySqlCommand(insert, con);
                    mdr.Close();
                    cmd2.ExecuteNonQuery();
                }
               
            }

            con.Close();

        }

        private void 新建分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //写入数据库
                string connString = Properties.Settings.Default.ConnectionString;
                MySqlConnection con = new MySqlConnection(connString);//实例化链接
                con.Open();//开启连接
                string qurey = "select *from tbl_type where Typename='"+txtName.Text.Trim()+"' and TypeUserName='"+lbUsername.Text.Trim()+"'";
                MySqlCommand cmd = new MySqlCommand(qurey, con);
                MySqlDataReader mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("分类名已存在！");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtName.Text.Trim()))
                    {
                        MessageBox.Show("要添加的分类名称不能为空！");
                        return;
                    }
                    //添加根节点
                    tvSort.Nodes.Add(txtName.Text.Trim());
                    string insert = "insert into tbl_type(TypeName,TypeUserName)values('" + txtName.Text.Trim() + "','"+lbUsername.Text.Trim()+"')";
                    MySqlCommand cmd2 = new MySqlCommand(insert, con);
                    mdr.Close();
                    cmd2.ExecuteNonQuery();
                }

                con.Close();

        }

        private void 修改分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string update = "update tbl_type set TypeName ='" +txtName.Text + "' where TypeUserName='" + lbUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(update, con);
            cmd.ExecuteNonQuery();
            //修改节点的值
            tvSort.SelectedNode.Text = txtName.Text;
            MessageBox.Show("修改成功！");
            
        }

        private void 删除分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string delete1 = "delete from tbl_note where noteTypeName='" + tvSort.SelectedNode.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(delete1, con);
            cmd1.ExecuteNonQuery();
            string delete = "delete from tbl_type where TypeName='"+tvSort.SelectedNode.Text+"'";
            MySqlCommand cmd = new MySqlCommand(delete, con);
            cmd.ExecuteNonQuery();
                //删除根节点
            tvSort.SelectedNode.Remove();
            MessageBox.Show("删除成功！");
        }

        private void 打开笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string qurey = "select  noteContent from tbl_note where noteName='" + tvSort.SelectedNode.Text + "'";
            MySqlCommand cmd = new MySqlCommand(qurey, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                rtxtContent.Text = mdr["noteContent"].ToString();
            }
        }

        private void 保存笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string update = "update tbl_note set noteContent ='"+rtxtContent.Text+"' where noteName='" + tvSort.SelectedNode.Text + "'";
            MySqlCommand cmd = new MySqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("保存成功！");
        }

        private void 删除笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connString = Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(connString);//实例化链接
            con.Open();//开启连接
            string delete = "delete from tbl_note where noteName='" + tvSort.SelectedNode.Text + "'";
            MySqlCommand cmd = new MySqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            //删除子节点
            tvSort.SelectedNode.Remove();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtContent.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtContent.Paste();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string strTemp = rtxtContent.SelectedText;
            if (strTemp.Equals(""))
                return;
            Clipboard.Clear();
            rtxtContent.Cut();
            this.Cursor = Cursors.Default;
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            rtxtContent.ForeColor = c;
        }

        private void 字体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font f = fontDialog1.Font;
            rtxtContent.Font = f;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void 关于记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();

        }


        private void linkPersonal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form personal = new Personal(lbUsername.Text);
            personal.ShowDialog();
        }

        private void llbeixt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.ShowDialog();
        }
      
    }
}
