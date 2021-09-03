using System;
using System.Collections.Generic;
using WhiteBoarding.Models;

// height checker, given an array of hights
// sort by the order
// heights = [1, 1, 4, 2, 1, 3]
// when they are ordered, count how many are now in a different possition

//try it out, sort the array, then loop through it

namespace WhiteBoarding
{
  class Program
    {
    static void Main(string[] args)
    {
      // ReverseString newReverseString = new ReverseString();
      // ReverseString.Reverse();
      // ReverseStringSentence newReverseStringSentence = new ReverseStringSentence();
      // ReverseStringSentence.Run();

      if(args[0] == "FizzBuzz")
      {
        //FizzBuzzRefactored newFizzBuzzRefactored = new FizzBuzzRefactored();
        FizzBuzzRefactored.Run();
      }
      if(args[0] == "arrayfind")
      {
        //ArrayFind newArrayFind = new ArrayFind();
        ArrayFind.Run();
      }
      if(args[0] == "next")
      {
        //Next newNext = new Next();
        Next.Run();
      }
      if(args[0] == "reverseInt")
      {
        ReverseInt.Run();
      }
      if(args[0] == "RomanToInt")
      {
        IntToRoman.Run();
      }
      if(args[0] == "InsertPosition")
      {
        InsertPosition.Run();
      }
      if(args[0] == "StringPattern")
      {
        StringPattern.Run();
      }
      if(args[0] == "recursionCoinCounter")
      {
        recursionCoinCounter.Run();
      }
      if(args[0] == "CheckingUniqueness")
      {
        recursionCoinCounter.Run();
      }
    }
 
  }
}