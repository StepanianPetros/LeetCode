using System;

public class Solution {
    public int CountPrimes(int n) {
        if (n <= 2)
        {
            return 0;
        }

        var count = n / 2;
        var isPrimesIn = new bool[n];

        for (int i = 3; i * i < n; i += 2)
        {
            if (!isPrimesIn[i])
            {
                for (int j = i * i; j < n; j += 2 * i)
                {
                    if (!isPrimesIn[j])
                    {
                        count--;
                        isPrimesIn[j] = true;
                    }
                }
            }
        }

        return count;
    }
}

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            string? input = Console.ReadLine();
            int num;
            bool success = int.TryParse(input, out num);
            if (success)
            {
                Solution solution = new Solution();
                Console.WriteLine("Answer is: " + solution.CountPrimes(num));
            }
            else
            {
                Console.WriteLine("Input error");
            }
           
        }
    }
}




