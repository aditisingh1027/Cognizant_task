using System;

namespace DSA.Arrays
{
    /// <summary>
    /// Contains utility methods for array operations.
    /// </summary>
    public static class LargestElement
    {
        /// <summary>
        /// Returns the maximum value in the given integer array.
        /// </summary>
        /// <param name="arr">Array of integers. Must contain at least one element.</param>
        /// <returns>Maximum integer value.</returns>
        /// <exception cref="ArgumentException">Thrown when the array is null or empty.</exception>
        public static int Find(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array must not be null or empty.");

            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max) max = item;
            }
            return max;
        }
    }
}
