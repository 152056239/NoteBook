using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 新建文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form form2=new Form2();
           form2.Show();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
