using System;

namespace WhiteBoarding.Models
{
  class StringPattern
    {
    public static void Run()
    {
      //make a dictionary and insert these into it
      string s = "dog cat cat dog";
      string pattern = "abba";

      Console.WriteLine("next");
      string[] stringArray = s.Split(" ");

      char[] patternArray = pattern.ToCharArray();

      for(int i = 0; i < stringArray.Length; i++)
      {
        Console.WriteLine(stringArray[i] + " " + patternArray[i]);
      }

    }
  }
}