using System;

namespace WhiteBoarding.Models
{
  class ReverseStringSentence
    {
    public static void Run()
    {
      string sentence = "hello there max";
      int k = 2;
      string result = "";
      string[] splitSentence = sentence.Split(" ");
      for (int i = 0; i < k; i ++)
      {
        result += splitSentence[i] + " "; 
      }
      Console.WriteLine(result.Trim());
      
    }
  }
}