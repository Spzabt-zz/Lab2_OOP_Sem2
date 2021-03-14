using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        private delegate double MyDelMath(double number);

        static void Main(string[] args)
        {
            MyDelMath[] mD =
            {
                num => Math.Sqrt(Math.Abs(num)),
                num => Math.Pow(num, 3),
                num => num + 3.5
            };
            Dictionary<int, MyDelMath> switcher = new Dictionary<int, MyDelMath>
            {
                {0, mD[0]},
                {1, mD[1]},
                {2, mD[2]}
            };
            
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 -- x^3");
            Console.WriteLine("2 -- x + 3,5");
            
            while (true)
            {
                try
                {
                    string str = Console.ReadLine();
                    string[] sArr = str.Split();
                    int key = int.Parse(sArr[0]);
                    double value = double.Parse(sArr[1]);
                    var a = switcher[key];
                    Console.WriteLine(a(value));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.ToString());
                    break;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ToString());
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}