namespace MDI
{
    partial class Load
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Users = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(113, 59);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(173, 28);
            this.Users.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(114, 107);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(173, 28);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码:";
            // 
            // Loader
            // 
            this.Loader.Location = new System.Drawing.Point(209, 141);
            this.Loader.Name = "Loader";
            this.Loader.Size = new System.Drawing.Size(78, 36);
            this.Loader.TabIndex = 4;
            this.Loader.Text = "登录";
            this.Loader.UseVisualStyleBackColor = true;
            this.Loader.Click += new System.EventHandler(this.Loading);
            // 
            // Load
            // 
            this.AcceptButton = this.Loader;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 208);
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Load";
            this.ShowIcon = false;
            this.Text = "登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Load_FormClosed);
            this.Load += new System.EventHandler(this.Begin);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loader;
        public System.Windows.Forms.TextBox Users;
    }
}

