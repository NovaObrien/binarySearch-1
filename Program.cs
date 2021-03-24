using System;

namespace BinarySearch_1
{
  class Program
  {
    static void Main(string[] args)
    {
      int target = 3;
      int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      int guess = 1;
      int max = nums.Length;
      int min = 0;

      //   Console.WriteLine((max - min) / 2);

      while (guess != target)
      {
        guess = (max + min) / 2;
        Console.WriteLine("Current Guess " + guess);
        if (max < min)
        {
          Console.WriteLine("Target is not present");
          break;
        }
        else if (guess == target)
        {
          Console.WriteLine("Found Target is equal to " + guess);
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

      }
    }
  }
}
