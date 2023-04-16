using System;
namespace Sort
{
  public class InsertionSort
  {
    public int[] Insertion_sort(int[] input)
    {
      int len = input.Length;

      for (int i = 1; i< len;i++)
      {
        var key = input[i];
        var flag = 0;

        for (int j = i -1;j>=0 && flag != 1;)
        {
          if (key<input[j])
          {
            input[j+1] = input[j];
            j--;
            input[j+1]=key;
          }
          else flag = 1;
        }
      }
      return input;
    }




    static void Main(string[] args)
    {
      var Array = new int[]{10,9,8,7,6,5,4,3,2,1};
      var sort = new InsertionSort();
      var sortedarray = sort.Insertion_sort(Array);
      Console.Write("[");
      foreach(var i in sortedarray)
      {
        Console.Write( i );
      }
      Console.Write("]");
    }
  }
}

