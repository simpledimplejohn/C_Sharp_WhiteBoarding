using System;
using System.Collections.Generic;
using System.Linq;

namespace WhiteBoarding
{
  class DataTypes
  {
    public static void Run() 
    {
      int numberVar = 1000;
      string stringVar = "I'm a string";
      float floatVar = 10.2f;
      double doubleVar = 10.3;
      char charVar = 'A';
      bool boolVar = true;
      var date1 = new DateTime(2008, 5, 1, 8, 30, 52);

      Console.WriteLine("Concatinate a string to a char");
      Console.WriteLine(stringVar + " " + charVar);
      Console.WriteLine("int to string " + numberVar.ToString());
      Console.WriteLine("char to string " + charVar.ToString());
      Console.WriteLine("float number is " + floatVar.ToString());
      Console.WriteLine("double number is: " + doubleVar.ToString());
      Console.WriteLine("A bool variable looks like: " + boolVar);





    }
  }
}