namespace ProjectEulerDotNetProblems.From0To100
{
    using ProjectEulerDotNetProblems.Utilities;

    public static class Problem003LargestPrimeFactor
    {
        /// <summary>
        /// Largest prime factor
        /// ....................
        /// Problem 3
        /// ---------
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        ///
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public static ulong CalculateLargestPrimeFactorOfTheNumber(ulong number)
        {
            if ((number & 1) == 0)
            {
                number -= 1;
            }

            for (ulong candidate = number; candidate >= 0; candidate -= 2)
            {
                if (MathematicsUtilities.IsFactor(number, candidate) && MathematicsUtilities.IsPrime(candidate))
                {
                    return candidate;
                }
            }

            return 0;
        }
    }
}
