using System;
using System.Threading;
namespace TimerCallBackDm
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(TimerCallBackMethod);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Console.WriteLine("Please press any key to stop timer");
            Console.ReadKey();
            timer.Dispose();
            Console.WriteLine("Timer stopped.Press anykey to exit");
            Console.ReadKey();


        }
        public static void TimerCallBackMethod(object state)
        {
            Console.WriteLine("Time callback executed at {0}",DateTime.Now);
        }
    }
}



