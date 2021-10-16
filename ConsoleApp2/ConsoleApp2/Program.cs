using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        delegate int Calc(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread # : " + Thread.CurrentThread.ManagedThreadId);
            Calc calc = new Calc(Add);
            int delta =Convert.ToInt32(Console.ReadLine());
            var result = calc.BeginInvoke(12, 5, calcCallBack, delta);
            Console.ReadLine();
            
        }

        private static void calcCallBack(IAsyncResult ar)
        {
            Console.WriteLine("calc Thread # : " + Thread.CurrentThread.ManagedThreadId);
            var calc = ((AsyncResult)ar).AsyncDelegate as Calc;
            var res = calc.EndInvoke(ar);
            int delta = Convert.ToInt32(ar.AsyncState);
            Console.WriteLine(res-delta);
        }

        private static int Add(int x, int y)
        {
            Console.WriteLine(" Thread # : " + Thread.CurrentThread.ManagedThreadId);
            
            return x + y;
        }
    }
}
