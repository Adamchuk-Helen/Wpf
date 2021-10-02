using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();
            process.StartInfo = new ProcessStartInfo("Notepad++.exe");
            process.Start();
            ShowInfo(process);
            Thread.Sleep(7000);
            process.Kill();

            Process.Start("calc.exe");
        }

        private static void ShowInfo(Process process)
        {
       
            Console.WriteLine($"ID: {process.Id}");
            Console.WriteLine($"MachineName: {process.MachineName}");
            Console.WriteLine($"MainModule: {process.MainModule}");
            Console.WriteLine($"BasePriority: {process.BasePriority}");
            Console.WriteLine($"ProcessName: {process.ProcessName}");
        }

       

    }
}
