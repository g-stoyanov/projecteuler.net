namespace ProjectEulerDotNetProblems.From0To100
{
    using ProjectEulerDotNetProblems.Utilities;

    class Problem00710001stPrime
    {
        /// <summary>
        /// 10001st prime
        /// .............
        /// Problem 7
        /// ---------
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// 
        /// What is the 10 001st prime number?
        /// </summary>
        public static ulong CalculateNthPrimeNumber(int index)
        {
            ulong result = MathematicsUtilities.GetNthPrime(index);

            return result;
        }
    }
}
