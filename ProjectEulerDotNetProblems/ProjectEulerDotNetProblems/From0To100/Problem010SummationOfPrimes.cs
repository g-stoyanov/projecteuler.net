namespace ProjectEulerDotNetProblems
{
    using ProjectEulerDotNetProblems.Utilities;

    public static class Problem010SummationOfPrimes
    {
        /// <summary>
        /// Summation of primes
        /// ...................
        /// Problem 10
        /// ----------
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// 
        /// Find the sum of all the primes below two million.
        /// </summary>
        public static ulong CalculateSumOfAllPrimesBellowGivenBorder(uint border)
        {
            ulong sumOfAllPrimes = 2;
            for (ulong primeCandidate = 3; primeCandidate < border; primeCandidate += 2)
            {
                if (MathematicsUtilities.IsPrime(primeCandidate))
                {
                    sumOfAllPrimes += primeCandidate;
                }
            }

            return sumOfAllPrimes;
        }
    }
}
