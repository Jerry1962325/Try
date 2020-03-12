using System;

using System.IO;
namespace Driving
{
    class Program
    {
        static void Main(string[] args)
        {
            void Cer1(string path, string name, string IF, string List)
            {
                Directory.CreateDirectory(path);
                File.WriteAllText(path + "Password.dat", "123456");
                File.WriteAllText(path + "IF.dat", IF);
                File.WriteAllText(path + "List.dat", List);
            }
            Console.WriteLine("这将会初始化目录，按回车以确定");
            Console.ReadLine();
            Console.WriteLine("正在初始化目录");
            try { Directory.Delete("D:/师徒系统", true); } catch (DirectoryNotFoundException) { }
            Cer1("D:/师徒系统/User_All/Administrator/","Administrator","A","");
            Cer1("D:/师徒系统/User_All/艾鑫/", "艾鑫", "flase", "");
            Cer1("D:/师徒系统/User_All/杨晨/", "杨晨", "flase", "");
            Cer1("D:/师徒系统/User_All/王华/" , "王华", "true", "杨晨");
            Console.WriteLine("初始化完成"); Console.ReadLine();
        }
    }
}
