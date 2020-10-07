using System;
using System.Linq;

namespace Codewars.kyu7
{
    internal class BitCounting
    {
        public static int CountBits(int n)
        {
            var binary = Convert.ToString(n, 2);
            return binary.Count(i => i == '1');
        }
    }
}