using System;
using System.Collections.Generic;
using System.Linq;


/*
Different methods in Linq
*/

namespace WhiteBoarding.Models
{
  class LinqMethods
  {
    public static void Run() 
    {
      Console.WriteLine("Distinct excludes duplicates");
          
      var x = new List<string>(){"a", "b", "c", "d", "d"};
      var y = x.Distinct().ToList();
      y.ForEach(i => Console.WriteLine(i));
    
    }

  }
}