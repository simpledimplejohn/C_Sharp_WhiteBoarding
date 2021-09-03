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
namespace WhiteBoarding.Models
{
  class CheckingUniqueness
    {
    public static void Run()
    {
      Console.WriteLine("works");
      
    }
  }
}
