namespace Notebook
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tvSort = new System.Windows.Forms.TreeView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkPersonal = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.llbeixt = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.tvSort);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 384);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(50, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 21);
            this.txtName.TabIndex = 2;
            // 
            // tvSort
            // 
            this.tvSort.Location = new System.Drawing.Point(3, 59);
            this.tvSort.Name = "tvSort";
            this.tvSort.Size = new System.Drawing.Size(169, 322);
            this.tvSort.TabIndex = 2;
            this.tvSort.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(175, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建分类ToolStripMenuItem,
            this.修改分类ToolStripMenuItem,
            this.删除分类ToolStripMenuItem,
            this.新建笔记ToolStripMenuItem,
            this.打开笔记ToolStripMenuItem,
            this.保存笔记ToolStripMenuItem,
            this.删除笔记ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.新建ToolStripMenuItem.Text = "新文档";
            // 
            // 新建分类ToolStripMenuItem
            // 
            this.新建分类ToolStripMenuItem.Name = "新建分类ToolStripMenuItem";
            this.新建分类ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建分类ToolStripMenuItem.Text = "新建分类";
            this.新建分类ToolStripMenuItem.Click += new System.EventHandler(this.新建分类ToolStripMenuItem_Click);
            // 
            // 修改分类ToolStripMenuItem
            // 
            this.修改分类ToolStripMenuItem.Name = "修改分类ToolStripMenuItem";
            this.修改分类ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改分类ToolStripMenuItem.Text = "修改分类";
            this.修改分类ToolStripMenuItem.Click += new System.EventHandler(this.修改分类ToolStripMenuItem_Click);
            // 
            // 删除分类ToolStripMenuItem
            // 
            this.删除分类ToolStripMenuItem.Name = "删除分类ToolStripMenuItem";
            this.删除分类ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除分类ToolStripMenuItem.Text = "删除分类";
            this.删除分类ToolStripMenuItem.Click += new System.EventHandler(this.删除分类ToolStripMenuItem_Click);
            // 
            // 新建笔记ToolStripMenuItem
            // 
            this.新建笔记ToolStripMenuItem.Name = "新建笔记ToolStripMenuItem";
            this.新建笔记ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建笔记ToolStripMenuItem.Text = "新建笔记";
            this.新建笔记ToolStripMenuItem.Click += new System.EventHandler(this.新建笔记ToolStripMenuItem_Click);
            // 
            // 打开笔记ToolStripMenuItem
            // 
            this.打开笔记ToolStripMenuItem.Name = "打开笔记ToolStripMenuItem";
            this.打开笔记ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开笔记ToolStripMenuItem.Text = "打开笔记";
            this.打开笔记ToolStripMenuItem.Click += new System.EventHandler(this.打开笔记ToolStripMenuItem_Click);
            // 
            // 保存笔记ToolStripMenuItem
            // 
            this.保存笔记ToolStripMenuItem.Name = "保存笔记ToolStripMenuItem";
            this.保存笔记ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存笔记ToolStripMenuItem.Text = "保存笔记";
            this.保存笔记ToolStripMenuItem.Click += new System.EventHandler(this.保存笔记ToolStripMenuItem_Click);
            // 
            // 删除笔记ToolStripMenuItem
            // 
            this.删除笔记ToolStripMenuItem.Name = "删除笔记ToolStripMenuItem";
            this.删除笔记ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除笔记ToolStripMenuItem.Text = "删除笔记";
            this.删除笔记ToolStripMenuItem.Click += new System.EventHandler(this.删除笔记ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.llbeixt);
            this.panel2.Controls.Add(this.linkPersonal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Controls.Add(this.rtxtContent);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(193, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 384);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkPersonal
            // 
            this.linkPersonal.AutoSize = true;
            this.linkPersonal.Location = new System.Drawing.Point(131, 41);
            this.linkPersonal.Name = "linkPersonal";
            this.linkPersonal.Size = new System.Drawing.Size(53, 12);
            this.linkPersonal.TabIndex = 4;
            this.linkPersonal.TabStop = true;
            this.linkPersonal.Text = "个人中心";
            this.linkPersonal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPersonal_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "欢迎您：";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(72, 41);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 12);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "请先登录";
            // 
            // rtxtContent
            // 
            this.rtxtContent.BackColor = System.Drawing.Color.White;
            this.rtxtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtContent.Location = new System.Drawing.Point(-3, 92);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(567, 292);
            this.rtxtContent.TabIndex = 1;
            this.rtxtContent.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.字体ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.剪切ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.颜色ToolStripMenuItem,
            this.字体ToolStripMenuItem1});
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.字体ToolStripMenuItem.Text = "字体";
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem1
            // 
            this.字体ToolStripMenuItem1.Name = "字体ToolStripMenuItem1";
            this.字体ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.字体ToolStripMenuItem1.Text = "字体";
            this.字体ToolStripMenuItem1.Click += new System.EventHandler(this.字体ToolStripMenuItem1_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看状态栏ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 查看状态栏ToolStripMenuItem
            // 
            this.查看状态栏ToolStripMenuItem.Name = "查看状态栏ToolStripMenuItem";
            this.查看状态栏ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看状态栏ToolStripMenuItem.Text = "查看状态栏";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于记事本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于记事本ToolStripMenuItem
            // 
            this.关于记事本ToolStripMenuItem.Name = "关于记事本ToolStripMenuItem";
            this.关于记事本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于记事本ToolStripMenuItem.Text = "关于记事本";
            this.关于记事本ToolStripMenuItem.Click += new System.EventHandler(this.关于记事本ToolStripMenuItem_Click);
            // 
            // llbeixt
            // 
            this.llbeixt.AutoSize = true;
            this.llbeixt.Location = new System.Drawing.Point(190, 41);
            this.llbeixt.Name = "llbeixt";
            this.llbeixt.Size = new System.Drawing.Size(29, 12);
            this.llbeixt.TabIndex = 5;
            this.llbeixt.TabStop = true;
            this.llbeixt.Text = "退出";
            this.llbeixt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbeixt_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(769, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看状态栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于记事本ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建笔记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开笔记ToolStripMenuItem;
        private System.Windows.Forms.TreeView tvSort;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem 删除分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除笔记ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 保存笔记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改分类ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkPersonal;
        private System.Windows.Forms.LinkLabel llbeixt;

    }
}