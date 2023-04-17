
public class BubbleSort {
    public static void bubbleSort(int[] arr) {
        int n = arr.Length;

        // Traverse through all array elements
        for (int i = 0; i < n - 1; i++) {
            // Last i elements are already in place
            for (int j = 0; j < n - i - 1; j++) {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void Main() {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        bubbleSort(arr);
        Console.Write("Sorted array: ");
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
    }
}