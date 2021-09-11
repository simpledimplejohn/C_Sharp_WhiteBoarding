using System;

namespace WhiteBoarding.Models
{
  class ReverseInt
    {
    public static void Run()
    {

      int num = 123;
      string numString = num.ToString();
      //string reverseString = "";

      for (int i = numString.Length-1; i >= 0; i--)
      {
        Console.WriteLine(numString[i]);

      }
      
    }
  }
}