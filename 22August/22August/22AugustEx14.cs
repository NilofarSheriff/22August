﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class _22AugustEx14
    {
        static void Main(string[] args)
        {
            int[] coins = { 1, 2, 3 };
            int n = coins.Length;
            Console.Write(count(coins, n, 4));
            static int count(int[] coins, int n, int sum)
            {
                // If sum is 0 then there is 1 solution
                // (do not include any coin)
                if (sum == 0)
                    return 1;

                // If sum is less than 0 then no
                // solution exists
                if (sum < 0)
                    return 0;

                // If there are no coins and sum
                // is greater than 0, then no
                // solution exist
                if (n <= 0)
                    return 0;

                // count is sum of solutions (i)
                // including coins[n-1] (ii) excluding coins[n-1]
                return count(coins, n - 1, sum)
                    + count(coins, n, sum - coins[n - 1]);

            }
    }
}
