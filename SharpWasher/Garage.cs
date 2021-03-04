using System;
using System.Collections.Generic;

namespace SharpWasher
{
    public class Garage
    {
        private readonly List<Car> _cars = new List<Car>();

        private readonly string[] _carNames =
        {
            "Tesla",
            "Bugatti",
            "Lamborghini",
            "Lada",
            "Mercedes",
            "Mustang",
            "Corvette",
            "Ferrari",
            "Lexus",
            "Maserati"
        };

        public Garage()
        {
            for (int i = 0; i < 10; i++)
            {
                _cars.Add(new Car(_carNames[i], i + 1));
            }
        }

        public void StartWashing()
        {
            WasherDelegate wD = Washer.Wash;
            foreach (var car in _cars)
                wD.Invoke(car);
        }
    }
}