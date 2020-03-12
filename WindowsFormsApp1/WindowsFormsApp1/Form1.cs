using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using My_Class;





namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                textBox1.Text = foldPath;
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "选";
            open.Filter = "Excel表格（*.xls;*.xlsx）| *.xls;*.xlsx";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = open.FileName;
                Excel c = new Excel();
                string[,] VS = c.ReadExcel(file);
            }

        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)//使内容仅数字及字母
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
        }
    }
}
