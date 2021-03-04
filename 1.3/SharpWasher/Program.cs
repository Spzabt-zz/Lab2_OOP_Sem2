using System;

namespace SharpWasher
{
    public delegate void WasherDelegate(Car car);
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var garage = new Garage();
            garage.StartWashing();
        }
    }
}