using System;
//Fizz Buzz Test
// write a program that prints the numbers from 1 to 100
// for multiples of three print Fizz
// for multiples of five print Buzz
// for multiples of both three and five print fizzbuzz

namespace WhiteBoarding.Models
{
  class FizzBuzzRefactored
    {
    public static void Run()
    {
      for(int i = 1; i < 100; i++)
      {
        // if (i % 3 == 0 && i % 5 == 0)
        // {
        //   Console.WriteLine("fizzbuzz");
        // }
        string next = "";

        if (i % 3 == 0) next = "fizz";

        if (i % 5 == 0) next += "buzz";
        
        if (next == "") next = i.ToString();

        Console.WriteLine(next);
      }
      
    }
  }
}