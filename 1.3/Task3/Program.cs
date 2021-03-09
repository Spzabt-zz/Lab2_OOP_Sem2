using System;

namespace Task3
{
    internal class Program
    {
        private delegate int[] MyDivideDelegate(int[] array);

        private static readonly Random _random = new Random();
        private static int[] _array;

        public static void Main(string[] args)
        {
            RandomizeArr();

            Console.Write("Array: ");
            PrintArr();

            MyDivideDelegate by3Or7 = DivideBy3Or7;
            MyDivideDelegate by3 = DivideBy3;
            MyDivideDelegate by7 = DivideBy7;

            int[] tmpArr = _array;
            
            _array = by3Or7(tmpArr);
            Console.Write("\nNumbers which divide by 3 or 7: ");
            PrintArr();

            _array = by3(tmpArr);
            Console.Write("\nNumbers which divide by 3: ");
            PrintArr();

            _array = by7(tmpArr);
            Console.Write("\nNumbers which divide by 7: ");
            PrintArr();

            Console.ReadKey();
        }

        private static int[] DivideBy3Or7(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 3 == 0 || array[i] % 7 == 0 || array[i] % 3 == 0 && array[i] % 7 == 0)
                    count++;

            int[] tmpArr = new int[count];
            count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 3 == 0 || array[i] % 7 == 0 || array[i] % 3 == 0 && array[i] % 7 == 0)
                {
                    tmpArr[count] = array[i];
                    count++;
                }

            count = 0;
            return tmpArr;
        }

        private static int[] DivideBy3(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 3 == 0)
                    count++;

            int[] tmpArr = new int[count];
            count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 3 == 0)
                {
                    tmpArr[count] = array[i];
                    count++;
                }

            count = 0;
            return tmpArr;
        }

        private static int[] DivideBy7(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 7 == 0)
                    count++;

            int[] tmpArr = new int[count];
            count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 7 == 0)
                {
                    tmpArr[count] = array[i];
                    count++;
                }

            count = 0;
            return tmpArr;
        }

        private static void RandomizeArr()
        {
            _array = new int[10];
            for (int i = 0; i < _array.Length; i++)
                _array[i] = _random.Next(101);
        }

        private static void PrintArr()
        {
            foreach (var elementOfArray in _array)
                Console.Write(elementOfArray + " ");
        }
    }
}