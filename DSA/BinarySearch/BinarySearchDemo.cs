using System;

namespace DSA.BinarySearch
{
    public class BinarySearchDemo
    {
        public static void Run()
        {
            int[] data = { 1, 3, 5, 7, 9 };
            int index = BinarySearch(data, 7);
            Console.WriteLine(index);
        }

        private static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}
