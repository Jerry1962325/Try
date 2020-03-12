using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

using NPOI;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace My_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NPOI.HSSF.UserModel;
    using NPOI.XSSF.UserModel;
    using System.IO;
    using NPOI.SS.UserModel;


    public class Excel
    {
        string[,] arry = new string[100, 100];

        public string[,] ReadExcel(string filePath)
        {
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(0);

                IRow row = sheet.GetRow(0);  //读取当前行数据
                                             //LastRowNum 是当前表的总行数-1（注意）
                int offset = 0;



                for (int i = 0; i <= sheet.LastRowNum; i++)//此处除去了表的第一行表头
                {
                    row = sheet.GetRow(i);  //读取当前行数据
                    if (row != null)
                    {
                        //LastCellNum 是当前行的总列数
                        for (int j = 0; j < row.LastCellNum; j++)//数组里面存的是除去第一列开始的数据
                        {
                            //读取该行的第j列数据
                            string value = row.GetCell(j).ToString();
                            Console.Write(value.ToString() + " ");
                            arry[i, j] = value;
                        }
                        Console.WriteLine("\n");
                    }
                }
                return arry;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void Cer1(string name, string IF, string List,string password)
        {
            string path = ".//User_All//"+name+"//";
            Directory.CreateDirectory(path);
            File.WriteAllText(path + "Password.dat",password);
            File.WriteAllText(path + "IF.dat", IF);
            File.WriteAllText(path + "List.dat", List);
        }
    }
}
//p.arry[x,x-1]
