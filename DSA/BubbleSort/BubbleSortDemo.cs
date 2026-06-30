using System;

namespace DSA.BubbleSort;

public static class BubbleSortDemo
{
    public static void Run()
    {
        int[] data = { 5, 2, 9, 1, 5, 6 };
        BubbleSort(data);
        Console.WriteLine(string.Join( ", ", data));
    }

    private static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
