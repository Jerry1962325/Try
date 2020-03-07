using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDI
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            switch (File.ReadAllText("./User_All/" + MDI.Load.Config.value + "/IF.dat"))
            {
                case "A":
                    level.Text += "管理员";
                    break;
                case "false":
                    level.Text += "徒";
                    break;
                case "true":
                    level.Text += "师";
                    break;
            }
            MDI.Load.Config.things = "./User_All/" + MDI.Load.Config.value + "/";

        }

        private void 退出_Click(object sender, EventArgs e)
        {
            Form form = new Load();
            form.Show();
            this.Hide();
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new 改密();
            form.MdiParent = this;
            form.Show();
        }

        private void 关系转接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(MDI.Load.Config.things + "IF.dat") == "A" || File.ReadAllText(MDI.Load.Config.things + "IF.dat") == "true")
            {
                Form form = new 转接();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("无权进行关系转接");
            }
        }

        private void 文件共享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (File.ReadAllText(MDI.Load.Config.things + "IF.dat"))
            {
                case "A":
                    MessageBox.Show("管理员无共享文件夹");
                    break;
                case "true":
                    MDI.Load.Config.vs = MDI.Load.Config.value;
                    Directory.Move("./共享/" + MDI.Load.Config.value , "./"+MDI.Load.Config.value);
                    System.Diagnostics.Process.Start(MDI.Load.Config.value);
                    break;
                case "false":
                    MDI.Load.Config.vs = File.ReadAllText(MDI.Load.Config.things + "List.dat");
                    Directory.Move("./共享/" + MDI.Load.Config.vs, "./"+MDI.Load.Config.vs);
                    System.Diagnostics.Process.Start(MDI.Load.Config.vs);
                    break;
            }
            if (MessageBox.Show("使用文件夹结束后点击确定", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Directory.Move("./" + MDI.Load.Config.vs, "./共享/" + MDI.Load.Config.vs);
            }  

        }
    }
}
