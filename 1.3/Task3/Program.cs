using System;

namespace Task3
{
    internal class Program
    {
        public delegate int MyDivideDelegate(int[] array);

        private static Random _random;
        public static void Main(string[] args)
        {
            _random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = _random.Next(101);
            }
        }

        public static int Divide(int[] array)
        {
            return 0;
        }
    }
}