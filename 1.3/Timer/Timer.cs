using System;

namespace Timer
{
    public class Timer
    {
        public Timer()
        {
        }

        public void ShowTime(object obj)
        {
            Console.WriteLine($"Time - {DateTime.Now.ToLongTimeString()}");
        }
    }
}