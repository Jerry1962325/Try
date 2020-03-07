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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent(); 
        }

        public static class Config
        {
            public static string value = null;
            public static string things = null;
            public static string vs = null;
        }
        private void Loading(object sender, EventArgs e)
        {
            if (Users.Text == string.Empty||password.Text == string.Empty)
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                if (Directory.Exists("./User_All/" + Users.Text)&&(File.ReadAllText("./User_All/" + Users.Text+"/Password.dat")==password.Text))
                {
                    Config.value = Users.Text;
                    Config.things = "./User_All/" + Users.Text + "/";
                    Form MDI = new MDIParent1();
                    MDI.Text += Users.Text;
                    this.Hide();                  
                    MDI.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码不正确，如忘记密码，请联系管理员");
                }
            }
           
        }

        private void Begin(object sender, EventArgs e)
        {
            Users.Focus();
            File.SetAttributes("./User_All", FileAttributes.Hidden);
            File.SetAttributes("./共享", FileAttributes.Hidden);
        }

        private void Load_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
