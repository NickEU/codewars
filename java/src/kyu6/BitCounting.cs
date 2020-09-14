using System;
using System.Linq;

public class Kata
{
  public static int CountBits(int n)
  {
    var binary = Convert.ToString(n, 2);
    return binary.Count(i => i == '1');
  }
}