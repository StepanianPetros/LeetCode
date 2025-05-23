﻿
public class Solution 
{
    public double MyPow(double x, int n)
    {
        long N = n;
        if (N < 0) 
        {
            x = 1 / x;
            N = -N;
        }

        double result = 1.0;
        while (N > 0)
        {
            if (N % 2 == 1)
            {
                result *= x;
            }
            x *= x;
            N /= 2;
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.MyPow(9.0000, -2));
    }
}




