namespace MDI
{
    partial class 改密
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
            this.Old = new System.Windows.Forms.TextBox();
            this.New1 = new System.Windows.Forms.TextBox();
            this.New2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Old
            // 
            this.Old.Location = new System.Drawing.Point(150, 12);
            this.Old.Name = "Old";
            this.Old.Size = new System.Drawing.Size(178, 28);
            this.Old.TabIndex = 0;
            // 
            // New1
            // 
            this.New1.Location = new System.Drawing.Point(150, 46);
            this.New1.Name = "New1";
            this.New1.PasswordChar = '*';
            this.New1.Size = new System.Drawing.Size(178, 28);
            this.New1.TabIndex = 1;
            // 
            // New2
            // 
            this.New2.Location = new System.Drawing.Point(150, 80);
            this.New2.Name = "New2";
            this.New2.PasswordChar = '*';
            this.New2.Size = new System.Drawing.Size(178, 28);
            this.New2.TabIndex = 2;
            this.New2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.New2_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "旧密码:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "新密码:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认新密码:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(9, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "重置密码(管理员项)";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(61, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户名:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 28);
            this.textBox4.TabIndex = 2;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // 改密
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 172);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.New2);
            this.Controls.Add(this.New1);
            this.Controls.Add(this.Old);
            this.Name = "改密";
            this.Text = "改密";
            this.Load += new System.EventHandler(this.改密_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Old;
        private System.Windows.Forms.TextBox New1;
        private System.Windows.Forms.TextBox New2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}