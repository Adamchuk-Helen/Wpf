using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDll
{
    class Program
    {
        static void Main(string[] args)

        {
            string passFrom = @"C:\Новая папка\Text.txt";
            string passTo = @"C:\Новая папка";

            ExamDLL.ExamDLL.CopyFile(passFrom, passTo);
         
        }
    }
}
