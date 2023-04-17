class BubbleSort
{
    void sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }

    public static void Main()
    {
        int[] data = {34, 4, 23, 53, 43};
        BubbleSort sorting = new BubbleSort();
        sorting.sort(data);

        Console.Write("{ ");
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.Write("}");  

    }
}
