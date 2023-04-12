class InsertionSort {
 
    // Function to sort array using insertion sort
    void sort(int[] array)
    {
        
        int length = array.Length;

        // Iterate from arr[1] to arr[N] over the array. 
        for (int i = 1; i < length; ++i) {
            int current_number = array[i];
            int j = i - 1; 
        // Compare the current element (key) to its predecessor.
        // If the key element is smaller than its predecessor, compare it to the elements before. 
        // Move the greater elements one position up to make space for the swapped element.
            while (j >= 0 && array[j] > current_number ) {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = current_number;
        }
    }

 
    // Driver Code
    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        InsertionSort sorter = new InsertionSort();
        sorter.sort(arr);
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
 
        Console.Write("\n");
    }
}
 

