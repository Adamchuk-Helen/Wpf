using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("notepad.exe");
            process.Start();
            ShowInfo(process);
            Thread.Sleep(3000);
            process.Kill();
            Process.Start("calc.exe");
            process.Kill();
        }
        private static void ShowInfo(Process process)
        {
            Console.WriteLine($"proc ID {process.Id}\n");
            Console.WriteLine($"proc name {process.ProcessName}\n");
            Console.WriteLine($"proc priority {process.BasePriority}\n");
            Console.WriteLine($"proc module {process.MainModule}\n");

        }
    }
    
}
