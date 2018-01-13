namespace Notebook
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎您：";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.White;
            this.lbUsername.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.Location = new System.Drawing.Point(90, 32);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(72, 16);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "请先登录";
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(47, 91);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(105, 23);
            this.btnLook.TabIndex = 2;
            this.btnLook.Text = "查看个人信息";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(47, 129);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "修改个人信息";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(312, 118);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 16);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "用户名：";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(375, 117);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.ReadOnly = true;
            this.txtuserName.Size = new System.Drawing.Size(120, 21);
            this.txtuserName.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.White;
            this.lbPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPassword.Location = new System.Drawing.Point(313, 155);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 16);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(375, 155);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(120, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.White;
            this.lbEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEmail.Location = new System.Drawing.Point(313, 189);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 16);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "邮箱：";
            // 
            // lbTelNumber
            // 
            this.lbTelNumber.AutoSize = true;
            this.lbTelNumber.BackColor = System.Drawing.Color.White;
            this.lbTelNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTelNumber.Location = new System.Drawing.Point(312, 226);
            this.lbTelNumber.Name = "lbTelNumber";
            this.lbTelNumber.Size = new System.Drawing.Size(72, 16);
            this.lbTelNumber.TabIndex = 9;
            this.lbTelNumber.Text = "手机号：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(375, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(120, 21);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(375, 226);
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.ReadOnly = true;
            this.txtTelNumber.Size = new System.Drawing.Size(120, 21);
            this.txtTelNumber.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // main
            // 
            this.main.AutoSize = true;
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main.Location = new System.Drawing.Point(30, 9);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(88, 16);
            this.main.TabIndex = 13;
            this.main.TabStop = true;
            this.main.Text = "←回到首页";
            this.main.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.main_LinkClicked);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(769, 408);
            this.Controls.Add(this.main);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTelNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbTelNumber);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label1);
            this.Name = "Personal";
            this.Text = "Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel main;
    }
}