using System;

namespace SharpWasher
{
    public class Washer
    {
        public static void Wash(Car car)
        {
            Console.WriteLine($"{car.CarName} washed, num of car - {car.CarIndex}");
        }
    }
}