using System;

namespace Task4
{
    internal class Program
    {
        private delegate double MyInfiniteSeries(double a, double r, int n);

        public static void Main(string[] args)
        {
            bool isNumber = true;
            int n = 0;
            double a = 1.0 /*double.Parse(Console.ReadLine())*/;
            double r = 1.0 / 2.0 /*double.Parse(Console.ReadLine())*/;

            Console.Write("Enter count of calculations: ");
            while (isNumber)
            {
                if (int.TryParse("5"/*Console.ReadLine()*/, out n))
                    break;
                else
                {
                    Console.WriteLine("Enter number!");
                }
            }

            Console.Clear();

            MyInfiniteSeries mIS = CalculateSeries;
            Console.WriteLine("Number of calculations: " + n);
            Console.WriteLine("\nResult: " + mIS(a, r, n));

            Console.ReadKey();
        }

        private static double CalculateSeries(double a, double r, int n)
        {
            //geometric series
            //Harmonic factorial series sum
            //Alternating series
            double sum = 0;
            bool isSumOrSub = true;
            int changingSignsCount = -1;
            double tmp = sum + a;

            Console.WriteLine("1. Geometric series sum");
            Console.WriteLine("2. Harmonic factorial series sum");
            Console.WriteLine("3. Alternating geometric series sum");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write($"1/{a} + ");
                        sum += a;
                        a *= r;
                    }
                    break;
                case 2:
                    for (double i = 1; i <= n; i++)
                    {
                        Console.Write($"1/{i}! + ");
                        sum += 1.0 / Factorial(i);
                    }
                    break;
                case 3:
                    for (int i = 1; i <= n; i++)
                    {
                        changingSignsCount++;

                        if (isSumOrSub)
                        {
                            sum += tmp;
                            Console.Write($" + 1/{a}");
                        }
                        else
                        {
                            sum -= tmp;
                            Console.Write($" - 1/{a}");
                        }
                        if (changingSignsCount == 1)
                        {
                            isSumOrSub = !isSumOrSub;
                            changingSignsCount = 0;
                        }

                        tmp = a *= r;
                    }
                    break;
                default:
                    Console.WriteLine("Error NaN");
                    break;
            }

            return Math.Round(sum, 2);
        }

        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
                res *= i;
            return res;
        }
    }
}