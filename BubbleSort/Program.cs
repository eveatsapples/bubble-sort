using System;

namespace BubbleSort
{
  class Program
  {
    static void Main()
    {
      int[] array = new int[] { 8, -1, 7, 9, 4, -10, 0, 6, 2 };
      int arrayLength =  array.Length;
      Sort(array, arrayLength);
      Console.WriteLine("Result:");
      Console.WriteLine($"{string.Join(", ", array)}");
      Console.ReadLine();
    }

    static void Sort(int[] array, int length)
    {
      for (int i = 0; i < length - 1; i++)
      {
        Console.WriteLine($"i iteration {i}");
        for (int j = 0; j < length - i - 1; j++)
        {
          Console.WriteLine($"j iteration {j}");
          if (array[j] > array[j+1])
          {
            Console.WriteLine($"{array[j]} is bigger than {array[j + 1]} so I'll switch those");
            Console.WriteLine($"{string.Join(", ", array)}");
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
          }
          else {
            Console.WriteLine($"{array[j]} is smaller than {array[j + 1]}");
            Console.WriteLine($"{string.Join(", ", array)}");
          }

          Console.WriteLine();
        }
      }
    }
  }
}
