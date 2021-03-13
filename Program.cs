using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 123, 564, 894, 258, 456 };
            Console.WriteLine(GetMaxNumber(array));
        }

        public static int GetMaxNumber(int[] array)
        {
            return ArrayToNum(SortArrayDesc(GetMaxDigitArray(array)));
        }

        private static int ArrayToNum(int[] array )
        {
            int res = 0;
            foreach (int i in array)
            {
                res = res * 10 + i;
            }
            return res;
        }

        private static int[] SortArrayDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        private static int[] GetMaxDigitArray(int[] array)
        {
            int[] maxDigitArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                maxDigitArray[i] = GetMaxDigit(array[i]);
            }
            return maxDigitArray;
        }

        private static int GetMaxDigit(int num)
        {
            int max = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (max < digit)
                {
                    max = digit;
                }
                num = num / 10;

            }
            return max;

        }
    }
    }
