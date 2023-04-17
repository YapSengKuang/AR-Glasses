using System;

public class BubbleSort
{
    public static void bubbleSort(int[] arr)
    {   
        int temp = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] arr = {4,2,0,6,9};
        
        Console.Write("Initial array: ");
        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }

        bubbleSort(arr);

        Console.Write("\nSorted array: ");
        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }
    }
}