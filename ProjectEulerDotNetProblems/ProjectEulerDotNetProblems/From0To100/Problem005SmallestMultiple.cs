namespace ProjectEulerDotNetProblems.From0To100
{
    public static class Problem005SmallestMultiple
    {
        /// <summary>
        /// Smallest multiple
        /// .................
        /// Problem 5
        /// ---------
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        ///
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public static ulong CalcSmallestPositiveNumEvenlyDivisibleByRangeOfNums(ulong startNumber, ulong endNumber)
        {
            ulong result = 0;
            for (ulong candidate = 0; candidate <= ulong.MaxValue; candidate++)
            {
                for (ulong denominator = startNumber; denominator <= endNumber; denominator++)
                {
                    if (candidate % denominator != 0)
                    {
                        break;
                    }

                    if (denominator == endNumber)
                    {
                        result = candidate;
                    }
                }

                if (result != 0)
                {
                    break;
                }
            }

            return result;
        }
    }
}
