using NUnit.Framework;
using System.Collections.Generic;

namespace Codewars
{
    [TestFixture]
    public class NarcissisticTest
    {
        private const int TestCase1Input = 1;
        private const int TestCase2Input = 371;
        private const int TestCase3Input = 1111;
        private const int TestCase4Input = 55;
        private const string TestSuccessOutput = " is narcissistic";
        private const string TestFailureOutput = " is not narcissistic";

        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                // success:
                yield return new TestCaseData(TestCase1Input)
                    .Returns(true)
                    .SetDescription($"{TestCase1Input}{TestSuccessOutput}");
                yield return new TestCaseData(TestCase2Input)
                    .Returns(true)
                    .SetDescription($"{TestCase2Input}{TestSuccessOutput}");
                // failures:
                yield return new TestCaseData(TestCase3Input)
                    .Returns(false)
                    .SetDescription($"{TestCase3Input}{TestFailureOutput}");
                yield return new TestCaseData(TestCase4Input)
                    .Returns(false)
                    .SetDescription($"{TestCase4Input}{TestFailureOutput}");

            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public bool Test(int n) => NarcissisticNumber.IsNarcissistic(n);
    }
}
