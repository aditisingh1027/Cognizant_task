using System;

namespace DSA.LinearSearch
{
    public static class LinearSearchDemo
    {
        public static void Run()
        {
            int[] data = { 1, 3, 5, 7, 9 };
            int target = 5;
            int index = LinearSearch(data, target);
            Console.WriteLine(index >= 0
                ? $"Linear search found {target} at index {index}."
                : $"{target} not found.");
        }

        private static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }
    }
}
