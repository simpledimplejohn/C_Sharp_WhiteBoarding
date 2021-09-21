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

      // Student4 s1 = new Student4(111, "Karan");
      // Student4 s2 = new Student4(222, "Arayan");
      // s1.display();
      // s2.display();

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
        CheckingUniqueness.Run();
      }
      if(args[0] == "mostArrayNumber")
      {
        ArrayFind.Run();
        //ArrayFind.Dictionary();
      }
      if(args[0] == "Sketch")
      {
        Sketch.Run();
      }
      if(args[0] == "CollectionsPractice")
      {
        //CollectionPractice.ForEachListLoop();
        //CollectionPractice.IntList();
        CollectionPractice.DictionaryStuff();
      }
      if(args[0] == "LearningLinq")
      {
        LinqMethods.Run();
      }
      if(args[0] == "DataTypes")
      {
        DataTypes.Run();
      }
      if(args[0] == "WarmUp")
      {
        WarmUp.Run();
      }

    }
 
  }
}