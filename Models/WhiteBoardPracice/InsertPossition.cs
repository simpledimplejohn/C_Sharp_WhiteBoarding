//https://leetcode.com/problems/search-insert-position/
// input: nums = [1,3,5,6] target = 5
// output: 2


using System;

namespace WhiteBoarding.Models
{
  class InsertPosition
    {
    public static void Run()
    {
      int[] nums = { 5, 6, 7};
      int target = 1;
      //int output = 2;
      Console.WriteLine("Insert Possition");
      for(int i = 0; i < nums.Length; i++)
      {
        if(nums[i] >= target)
        {
          Console.WriteLine("output: " + i );
        }
      }
      
    }
  }
}