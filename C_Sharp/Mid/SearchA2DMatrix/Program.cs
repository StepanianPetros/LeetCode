using System;

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int n = matrix[0].Length - 1;
        int m = 0;
        
        while (m < matrix.Length && n >= 0)
        {
            int isThere = matrix[m][n];
            
            if (target > isThere)
                m++;
            else if (target < isThere)
                n--;
            else
                return true;
        }
        

        return false;
    }
}

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int[][] matrix = [
                                [1,3,5,7],
                                [10,11,16,20],
                                [23,30,34,60]
                            ];
            int target = 55;

            Solution solution = new Solution();
            Console.WriteLine(solution.SearchMatrix(matrix, target));
        }
    }
}




