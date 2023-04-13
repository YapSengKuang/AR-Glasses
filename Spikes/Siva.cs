using System;
    
public class BubbleSort
{
    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nSorted array: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}