public class SelectionSort
{
    private static void sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = array[i];
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++) {
                if (array[j] < min) {
                    min = array[j];
                    minIndex = j;
                }
            }

            array[minIndex] = array[i];
            array[i] = min;
        }
    }

    public static void PrintArray(int[] array)
    {
        Console.Write("[");
        foreach (int i in array) {
            Console.Write(i);
            if (i != array[array.Length - 1]) {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    public static void Main(string[] args)
    {
        int[] array = { 5, 3, 2, 1, 4, 6, 7, 10, 8, 9 };
        PrintArray(array);
        sort(array);
        PrintArray(array);
    }
}
