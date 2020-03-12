using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;

namespace ConsoleApp2
{
    class Program
    {
        string[,] arry = new string[100, 100];

        public void ReadExcel(string filePath)
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
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {

            string filePath = "D:\\0EF00820.xls";

            Program p = new Program();
            p.ReadExcel(filePath);
            Console.WriteLine(p.arry[0,0]);//这里是测试数组的值是否正确
            Console.ReadLine();
            for(int i = 1; i <p.arry.Length;i=++i)
            {
                if (p.arry[i,0] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(p.arry[i, 0]);
                }
            }
        }
    }
}

