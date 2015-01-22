namespace ProjectEulerDotNetProblems.From0To100
{
    public static class Problem009SpecialPythagoreanTriplet
    {
        /// <summary>
        /// Special Pythagorean triplet
        /// ...........................
        /// Problem 9
        /// ---------
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        /// 
        /// a2 + b2 = c2
        /// For example, 32 + 42 = 9 + 16 = 25 = 52.
        /// 
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        public static uint FindProductOfSetFromPythagoreanTripletWithSetSum1000()
        {
            for (int a = 1; a < 1001; a++)
            {
                for (int b = a; b < 1001; b++)
                {
                    for (int c = b; c < 1001; c++)
                    {
                        int sum = a + b + c;
                        if (sum == 1000 & (a * a) + (b * b) == (c * c))
                        {
                            uint result = (uint)(a * b * c);
                            return result;
                        }

                        if (sum > 1000)
                        {
                            break;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
