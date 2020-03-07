using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MDI
{
    public partial class 改密 : Form
    {
        public 改密()
        {
            InitializeComponent();
        }

        private void 改密_Load(object sender, EventArgs e)
        {
            if (File.ReadAllText("./User_All/" + MDI.Load.Config.value + "/IF.dat") == "A")
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void New2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (New1.Text == String.Empty || New2.Text == String.Empty) { MessageBox.Show("新密码不应为空"); }
                else
                {
                    if (File.ReadAllText("./User_All/" + MDI.Load.Config.value + "/Password.dat") == Old.Text && New1.Text == New2.Text)
                    {
                        File.WriteAllText("./User_All/" + MDI.Load.Config.value + "/Password.dat", New1.Text);
                        MessageBox.Show("改密完成");
                    }
                    else
                    {
                        MessageBox.Show("原密码不正确或者新密码不相同");
                    }
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (Directory.Exists("./User_All/" + textBox4.Text))
                {
                    File.WriteAllText("./User_All/" + textBox4.Text+"/Password.dat", "123456");
                    MessageBox.Show("重置完成");
                }
                else
                {
                    MessageBox.Show("请确认用户名");
                }
            }
        }
    }
}
