using System;
using System.IO;
using System.Text.Encodings;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.SetAttributes("D:/VSWorks/MDI/MDI/bin/Debug/User_All", FileAttributes.Hidden);
            Console.ReadLine();
            File.SetAttributes("D:/VSWorks/MDI/MDI/bin/Debug/User_All", FileAttributes.Normal); 
        }
    }
}
