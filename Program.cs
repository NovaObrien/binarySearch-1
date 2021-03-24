using System;

namespace BinarySearch_1
{
  class Program
  {
    static void Main(string[] args)
    {
      int target = 8;
      int guess = 0;
      int max = 9;
      //   TODO Max is wrong
      int min = 0;
      int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      while (guess != target)
      {
        guess = max - min / 2;
        if (max < min)
        {
          Console.WriteLine("Target is not present");
          break;
        }
        else if (nums[guess] < target)
        {
          min = guess + 1;
          Console.WriteLine("Guess is to Low " + guess);
        }
        else
        {
          max = guess - 1;
          Console.WriteLine("Guess is to High " + guess);
        }
        Console.WriteLine("Found Target is equal to " + guess);

      }
    }
  }
}
