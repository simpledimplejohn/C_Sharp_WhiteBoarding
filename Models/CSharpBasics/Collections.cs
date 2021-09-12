using System;
using System.Collections.Generic;
using System.Linq;


/*
Collections are ways of handling data in C#, they have different uses
*/

namespace WhiteBoarding.Models
{
  class CollectionPractice
  {
    public static void ForEachListLoop() 
    {
      Console.WriteLine("String List -- the cooler array");
      
      var newList = new List<string>(){"aba", "bab", "cab", "ddab", "eab"};
      Console.WriteLine("newList.ForEach(i => Console.WriteLine(i))");
      newList.ForEach(i => Console.WriteLine(i));
      Console.WriteLine("for each another way");
      foreach(string i in newList)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("single list item newList[0]");
      // best thing about list--accessing by item is O(1), very cheep
      Console.WriteLine(newList[0]);

    }
    public static void IntList() 
    {
      var IntList = new List<int>(){1, 2, 3, 4};
      IntList.Add(5); //adds to the end
      IntList.Insert(0, 0); //insert zero at zero
      IntList.Remove(2); //removes an item from the list, 1 in this case
      IntList.RemoveAt(0); //removes the item at index 0 in this case
      foreach(int i in IntList) 
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("single item", IntList[0]); //item at index 0
      Console.WriteLine(IntList.IndexOf(4)); //returns the index of this item
      Console.WriteLine(IntList.Contains(4)); //returns bool
      Console.WriteLine(IntList.Count); //length of the list

      //adding to the begining will shift everyone over and is expensive in O()
      //adding to the end is cheep
    }
    public static void DictionaryStuff()
    {
      //no matter how large a lookup is O(1) fastest
      var NewDictionary = new Dictionary<char, int>()
      {
        { 'a', 1 },
        { 'b', 2 }
      };
      Console.WriteLine(NewDictionary['a']); //key gives you the value pair
      Console.WriteLine(NewDictionary.ContainsKey('a'));// bool
      Console.WriteLine(NewDictionary.ContainsValue(1));// bool
      Console.WriteLine("count" + NewDictionary.Count);
      foreach(var key in NewDictionary.Keys)
      {
        Console.WriteLine("foreach key " + key);
      }
      foreach(var value in NewDictionary.Values)
      {
        Console.WriteLine("foreach value " + value);
      }

      NewDictionary.Remove('b'); //removes the item pair at key 'a'
      NewDictionary.Clear(); //clears out all items
      Console.WriteLine("new count ", NewDictionary.Count);
      
    }

  }
}