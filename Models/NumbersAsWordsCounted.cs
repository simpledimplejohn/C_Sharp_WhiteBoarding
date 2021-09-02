using System;
using System.Collections.Generic;

namespace WhiteBoarding.Models
{
  class NumbersAsWords
    {
    static void Run(string[] args)
    {
      int num = int.Parse(args[0]);

      Dictionary<int, string> wordMap = new Dictionary<int, string> () {
        { 1, "one" },
        { 2, "two" },
        { 3, "three" },
        { 4, "four" },
        { 5, "five" },
        { 6, "six" },
        { 7, "seven" },
        { 8, "eight" },
        { 9, "nine" },
        { 10, "one" },
        { 11, "two" },
        { 12, "three" },
        { 13, "four" },
        { 14, "five" },
        { 15, "six" },
        { 16, "seven" },
        { 17, "eight" },
        { 18, "nine" },
        { 19, "one" },

        { 20, "two" },
        { 30, "three" },
        { 40, "four" },
        { 50, "five" },
        { 60, "six" },
        { 70, "seven" },
        { 80, "eight" },
        { 90, "nine" },

        { 100, "hundred" },
        { 1000, "thousand" },
        
      };


      string result = "";

      if (num == 1000)
      {
        //"one thousand"
        result += wordMap[1] + wordMap[num];
      }

      //hundreds place
      if (num >= 100 && num < 1000) {
        int hundredsDigit = num / 100; //as an int it will floor it 
        result += wordMap[hundredsDigit] +" " + wordMap[100];

        num -= hundredsDigit * 100; //account for hundreds only
        
      }

      // tens place
      if (num >= 20 && num < 100) {
        int onesPlace = num % 10; 
        int doubleDigit = num - onesPlace;


        result += wordMap[doubleDigit] + " " + wordMap[10];

        num -= doubleDigit;

      }

      if (num < 20) {
        result += wordMap[num];
      }
      System.Console.WriteLine(result);
      System.Console.WriteLine(result.Length);
    }
  }
}