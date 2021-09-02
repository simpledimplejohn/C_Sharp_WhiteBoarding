using System;


namespace WhiteBoarding.Models
{
  public class ReverseString
  {
    public static void Reverse()
    {
      string enterValue = "Let's take LeetCode contest";
      string[] words = enterValue.Split(' ');


      for(int i=0; i < words.Length; i++)
      {
        string individualWord = words[i];

        Console.WriteLine(individualWord);

        for(int j=individualWord.Length -1; j >= 0; j--)
        {
          
          // Console.WriteLine(individualWord[j]);
          char combinedReverseWords = individualWord[j];

        }
      }
    }
  }
}
  



