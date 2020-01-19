using System;

namespace Heapify
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 4, 1, 2 };
            Heapify(numbers);
            Console.WriteLine(numbers.ToString());
        }

        public static void Heapify(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Heapify(arr, i);
            }
        }

        private static void Heapify(int[] arr, int index)
        {
            var largerIndex = index;

            var leftIndex = index * 2 + 1;
            if (leftIndex < arr.Length && arr[leftIndex] > arr[largerIndex])
            {
                largerIndex = leftIndex;
            }

            var rightIndex = index * 2 + 2;
            if (rightIndex < arr.Length && arr[rightIndex] > arr[largerIndex])
            {
                largerIndex = rightIndex;
            }

            if (index == largerIndex)
                return;

            Sawp(arr, index, largerIndex);
            Heapify(arr, largerIndex);
        }

        private static void Sawp(int[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
