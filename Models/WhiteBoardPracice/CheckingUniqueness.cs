/*
Question #4: Checking for Uniqueness
Write an algorithm that determines whether all the elements in a string are unique. You may not convert the string into an array or use array methods to solve this problem. The algorithm should return a boolean.

Example

Input: "hello"

Output: false

Input: "copyright"

Output: true


function unique(string) {
  for (i=0; i<string.length; i++) {
    //console.log(string[i])
    for(j=0; j<string.length; j++) {
      console.log(string[i], " = ", string[j])
    }
  }
}
unique("hello")
unique("copyright")


NEXT STEPS
PUSH INTO A DICTIONARY
Compare key pairs

*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace WhiteBoarding.Models
{
  class CheckingUniqueness
    {
    public static void Run()
    {
      Console.WriteLine("find a string with unique characters");
      string unique = "hello";
    
      Console.WriteLine(unique);
      //int count1 = 0;


      var result = IsUnique(unique);
      Console.WriteLine(result);

      //Lewis's recursive code
      // var result2 = IsUniqueRecursive(unique);
      // Console.WriteLine(result2);
      // WRITE TO DICTIONARY
      // for(int i = 0; i < unique.Length; i ++)
      // {
      //   //Console.WriteLine(unique[i]);
      //   stringCount.Add(i, unique[i]);
      // }
      // // READ DICTIONARY

      // COMPARE DICTIONARY

    }

    public static bool IsUnique(string wordToCheck)
    {
      // how to throw an exception 
      // if (string.IsNullOrWhiteSpace(wordToCheck))
      // {
      //   throw new ArgumentException("Need non-empty string");
      // }

      //Dictionary<int, char> stringCount = new Dictionary<int, char>();

      var charCount = new Dictionary<char, int>();      

      // maximum count of *any* of the letters in the word
      var maxCount = 0;

      foreach (var letter in wordToCheck)
      {
        if (!charCount.ContainsKey(letter)) //if it does not have the letter we are adding it
        {
          charCount[letter] = 1;
        }
        else // if it does have it, we are ic the count by one
        {
          charCount[letter]++;
        }

        maxCount = Math.Max(maxCount, charCount[letter]); //Math.Max takes two numbers and compares them, 
      }
      foreach (KeyValuePair<char, int> pair in charCount) //KeyValuePair 
      {
        Console.WriteLine("{0},{1}", pair.Key, pair.Value);
      }
      return maxCount == 1;
    }
    
    // SDET Software Engineer in development 
    // write automated tests 

    public static bool IsUniqueRecursive(string wordToCheck, 
      Dictionary<char,int> stringCount=null, 
      int maxCount=0)
    {     
      
      if (stringCount == null)
      {
        stringCount = new Dictionary<char, int>();
      }
      
      char letter = wordToCheck[0];

      if (!stringCount.ContainsKey(letter)) //if it does not have the letter we are adding it
      {
        stringCount[letter] = 1;
      }
      else // if it does have it, we are ic the count by one
      {
        stringCount[letter]++;
      }

      maxCount = Math.Max(maxCount, stringCount[letter]); //Math.Max takes two numbers and compares them, 

      // special case. last letter.
      if (wordToCheck.Length == 1)
      {
        return maxCount == 1;
      }

      var remaining = wordToCheck[1..^1];

      return IsUniqueRecursive(remaining, stringCount, maxCount);      
    }

  }
}
