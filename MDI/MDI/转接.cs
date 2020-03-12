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
    public partial class 转接 : Form
    {
        public 转接()
        {
            InitializeComponent();
        }

        private void 转接_Load(object sender, EventArgs e)
        {
            switch (File.ReadAllText(MDI.Load.Config.things + "IF.dat"))
            {
                case "A":
                    panel1.Enabled = true;
                    break;
                case "true":
                    textBox1.Text = MDI.Load.Config.value;
                    panel1.Enabled = false;
                    break;
            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                if (Directory.Exists("./User_All/" + textBox1.Text) && Directory.Exists("./User_All/" + textBox2.Text))
                {
                    if(File.ReadAllText("./User_All/"+textBox1.Text+"/IF.dat")=="true"&& File.ReadAllText("./User_All/" + textBox2.Text + "/IF.dat") == "false")
                    {
                        MessageBox.Show("OK");
                    }
                }
            }
        }
    }
}
