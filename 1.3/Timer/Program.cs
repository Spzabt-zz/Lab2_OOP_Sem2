using System;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int timerCount = 0;
            
            Timer timer = new Timer();
            TimerCallback tC = new TimerCallback(timer.ShowTime);
            System.Threading.Timer threadingTimer = new System.Threading.Timer(tC, null, 0, 2000);

            /*while (timerCount <= 10)
            {
                Task.Delay(2000).Wait();
                timerCount++;
            }*/

            //threadingTimer.Dispose();
            
            Console.ReadLine();
        }
    }
}