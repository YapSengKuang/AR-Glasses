using System;
public class BubbleSort{
    static void Main(){
        int[] arr = {1,3,2,6,7,8,10,9};
        bubbleSort(arr);
    }

    public static void bubbleSort(int[] arr){
        n = arr.Length;

        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var tempVar = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tempVar;
                }

         return arr;
    }

}   