namespace DefaultNamespace;

using System;

class Luke {
    static void Main(string[] args) {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int n = arr.Length;
        
        Console.WriteLine("Unsorted array:");
        PrintArray(arr, n);

        BubbleSortAlgorithm(arr, n);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr, n);
    }

    static void BubbleSortAlgorithm(int[] arr, int n) {
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    // swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr, int size) {
        for (int i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
