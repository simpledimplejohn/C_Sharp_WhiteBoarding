using System;
using System.Collections.Generic;

namespace WhiteBoarding.Models
{
  class ArrayFind
  {
    
    public static void Run()
    {
      int count1 = 0;
      int[] array = {4, 2, 3, 3, 4, 1, 8, 8, 9, 2};
      Console.WriteLine("Search through array and find number of repeats");
      Dictionary<int, int> arrayCount = new Dictionary<int, int>(); //instatiate the dictionary

      for(int j = 0; j < array.Length; j ++)
      {
        for(int i = 0; i < array.Length; i ++)
        { 
          if(array[j] == array[i])
          {
            count1 ++;
          }
        }
        arrayCount.Add(j, count1); //adding to the dictionary
        count1 = 0;
      }

      Console.WriteLine("works here");
      Console.WriteLine("count = " + count1);  
      
      foreach (KeyValuePair<int, int> pair in arrayCount)
      {
        Console.WriteLine("works");
        Console.WriteLine("{0},{1}", pair.Key, pair.Value);
      }
      //Console.ReadKey();

    }




// making a basic dictionary and looping through it to the console 
    public static void Dictionary()
    {
      int[] array = {4,2,3,4,4};
      

      Dictionary<int, int> arrayCount = new Dictionary<int, int>();

      Console.WriteLine("Basic Dictionary loop and create");
      
      // remember numbers along the way
      // do it with one
      // make a dictionary
      // count the number of items first
      // key 1 = count 2
      // search dictionary for highest count
      // 

      // write to the dictionary
      for(int i = 0; i < array.Length; i ++)
      { 
        arrayCount.Add(i, array[i]);
      }  




      // read the dictionary      
      foreach (KeyValuePair<int, int> pair in arrayCount)
      {
        Console.WriteLine("{0},{1}", pair.Key, pair.Value);
      }
      Console.ReadKey();
    }
  }
}
