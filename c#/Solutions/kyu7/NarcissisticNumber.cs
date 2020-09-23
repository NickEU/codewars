using System;

namespace Codewars
{
    public class NarcissisticNumber
    {
        public static bool IsNarcissistic(int valToTest)
        {
            int numOfDigits = valToTest.ToString().Length;
            int narcissVal = 0;
            int remainingVal = valToTest;
            while (remainingVal > 0)
            {
                int nextDigit = remainingVal % 10;
                remainingVal /= 10;
                narcissVal += (int) Math.Pow(nextDigit, numOfDigits);
            }
            return narcissVal == valToTest;
        }
    }
}
