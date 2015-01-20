namespace ProjectEulerDotNetProblems.From0To100
{
    public static class Problem001MultiplesOf3And5
    {
        /// <summary>
        /// Multiples of 3 and 5
        /// ....................
        /// Problem 1
        /// ---------
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static ulong SumAllMultiplesOf3Or5(int below)
        {
            ulong sum = 0;
            int[] dividers = new[] { 3, 5 };
            for (uint i = 0; i < below; i++)
            {
                if (CheckIsMultiple(dividers, i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static bool CheckIsMultiple(int[] dividers, uint number)
        {
            for (int i = 0; i < dividers.Length; i++)
            {
                if (number % dividers[i] == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
