using System;
using System.Linq;

namespace Codewars
{
    public class BitCounting
    {
        public static int CountBits(int n)
        {
            var binary = Convert.ToString(n, 2);
            return binary.Count(i => i == '1');
        }
    }
}