
using System;
using System.Security.Principal;

public class Solution {
    
    public void SortColors(int[] nums)
    {
        int[] colors = [0, 0, 0];
        for(int n = 0; n < nums.Length; n++)
        {
            colors[nums[n]]++;
        }

        int curIndex = 0;
        for (int n = 0; n < 3; n++)
        {
            for (int i = 0; i < colors[n]; i++)
            {
                nums[curIndex] = n;
                curIndex++;
            }
        }


    }
}

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            
            /*
                Constraints:
                n == nums.length
                1 <= n <= 300
                nums[i] is either 0, 1, or 2.
            */
            int[] nums = [2, 0, 2, 1, 1, 0, 0];
            Solution myRes = new Solution();
            myRes.SortColors(nums);
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }
    }
}




