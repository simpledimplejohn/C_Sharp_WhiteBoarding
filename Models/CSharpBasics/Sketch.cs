using System;
using System.Collections.Generic;
using System.Linq;



namespace WhiteBoarding.Models
{
  class Sketch
    {
    public static void Run()
    {
      var x = new List<string>(){"a", "b", "c", "d", "d"};
      var y = x.Distinct().ToList();
      y.ForEach(i => Console.WriteLine(i));
    }
  }
}

/*
.Filter
.Sort
.Join()
.SetOperation
.OrderBy
*/
