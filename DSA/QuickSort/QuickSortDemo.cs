using System;

namespace DSA.QuickSort;

public static class QuickSortDemo
{
    public static void Run()
    {
        int[] data = { 33, 10, 55, 71, 29, 3, 18 };
        QuickSort(data, 0, data.Length - 1);
        Console.WriteLine(string.Join( ", ", data));
    }

    private static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;
        return i + 1;
    }
}
