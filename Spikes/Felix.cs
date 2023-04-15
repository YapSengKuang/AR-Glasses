using System;

public class BubbleSort
{
    static void Main()
    {
        int[] arr = { 5, 2, 7, 3, 9, 1 };
        bubbleSort(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
    
    // Function to sort array using bubble sort
    public static void bubbleSort(int[] arr)
    {
        int len = arr.Length;
        
        // Traverse the array
        for (int i = 0; i < len - 1; i++)
        {
            // Traverse the unsorted part of the array
            for (int j = 0; j < len - i - 1; j++)
            {
                // Checks if adjecent element is in wrong order
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

