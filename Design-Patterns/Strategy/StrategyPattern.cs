using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    // Strategy interface
    public interface ISortStrategy
    {
        int[] Sort(int[] data);
    }

    // Bubble sort implementation
    public class BubbleSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] data)
        {
            var arr = (int[])data.Clone();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }

    // Quick sort implementation
    public class QuickSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] data) => QuickSort((int[])data.Clone(), 0, data.Length - 1);
        private int[] QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
            return arr;
        }
        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }

    // Merge sort implementation
    public class MergeSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] data) => MergeSort((int[])data.Clone());
        private int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            int mid = arr.Length / 2;
            var left = MergeSort(arr[..mid]);
            var right = MergeSort(arr[mid..]);
            return Merge(left, right);
        }
        private int[] Merge(int[] left, int[] right)
        {
            var result = new List<int>();
            int i = 0, j = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j]) result.Add(left[i++]);
                else result.Add(right[j++]);
            }
            while (i < left.Length) result.Add(left[i++]);
            while (j < right.Length) result.Add(right[j++]);
            return result.ToArray();
        }
    }

    // Context that uses a strategy
    public class SortContext
    {
        private ISortStrategy _strategy;
        public SortContext(ISortStrategy strategy) => _strategy = strategy;
        public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;
        public void Execute(int[] data)
        {
            var sorted = _strategy.Sort(data);
            Console.WriteLine($"Sorted with {_strategy.GetType().Name}: {string.Join(", ", sorted)}");
        }
    }

    // Demo class exposing a static Run method
    public static class StrategyPattern
    {
        public static void Run()
        {
            int[] sample = { 5, 2, 9, 1, 5, 6 };
            var context = new SortContext(new BubbleSortStrategy());
            context.Execute(sample);
            context.SetStrategy(new QuickSortStrategy());
            context.Execute(sample);
            context.SetStrategy(new MergeSortStrategy());
            context.Execute(sample);
        }
    }
}
