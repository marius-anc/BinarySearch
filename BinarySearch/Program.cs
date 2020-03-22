using System;

namespace BinarySearch
{
    public class Program
    {
        public static int BinarySearch(int[] numbers, int numberToFind)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            const int half = 2;
            int minNum = 0;
            int maxNum = numbers.Length - 1;
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / half;
                if (CheckNumberAtIndex(numbers, mid, numberToFind))
                {
                    return mid;
                }
                else if (numberToFind < numbers[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            return -1;
        }

        static void Main()
        {
            int[] numbers = ReadNumbers();
            int numberToFind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbers, numberToFind));
            Console.Read();
        }

        private static int[] ReadNumbers()
        {
            string[] numbers = Console.ReadLine().Split();
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Convert.ToInt32(numbers[i]);
            }

            return result;
        }

        static bool CheckNumberAtIndex(int[] numbers, int index, int numberToCheck)
        {
            Console.WriteLine("Checking index " + index + " (value " + numbers[index] + ")");
            return numbers[index] == numberToCheck;
        }
    }
}
