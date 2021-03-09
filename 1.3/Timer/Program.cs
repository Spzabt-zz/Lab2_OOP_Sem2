using System;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Timer timer = new Timer();
            TimerCallback tC = timer.ShowTime;
            System.Threading.Timer TTimer = new System.Threading.Timer(tC, null, 0, 2000);
            
            Console.ReadLine();
        }
    }
}