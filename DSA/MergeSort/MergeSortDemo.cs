namespace DSA.MergeSort
{
    public class MergeSortDemo
    {
        public static void Run()
        {
            int[] data = { 9, 5, 2, 7, 1, 3 };
            MergeSort(data, 0, data.Length - 1);
            System.Console.WriteLine(string.Join(", " , data));
        }

        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int i = 0; i < n1; i++) L[i] = arr[left + i];
            for (int j = 0; j < n2; j++) R[j] = arr[mid + 1 + j];
            int iIdx = 0, jIdx = 0, k = left;
            while (iIdx < n1 && jIdx < n2)
            {
                if (L[iIdx] <= R[jIdx]) arr[k++] = L[iIdx++];
                else arr[k++] = R[jIdx++];
            }
            while (iIdx < n1) arr[k++] = L[iIdx++];
            while (jIdx < n2) arr[k++] = R[jIdx++];
        }
    }
}
