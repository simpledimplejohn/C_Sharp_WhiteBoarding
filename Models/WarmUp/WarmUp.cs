using System;

namespace WhiteBoarding.Models
{
  class WarmUp
  {
    public static void Run()
    {
      Console.WriteLine("Welcome to your morning C# warm up exercises:");
      //int a = 0;
      char[] charArray = {'a','b','c','b'};
      for (int i = 0; i < charArray.Length; i ++) {
        Console.WriteLine(charArray[i]);
      }
      for (int i = charArray.Length -1; i >= 0; i --) {
        Console.WriteLine(charArray[i] + " " + i);
      }
    }
  }
}




