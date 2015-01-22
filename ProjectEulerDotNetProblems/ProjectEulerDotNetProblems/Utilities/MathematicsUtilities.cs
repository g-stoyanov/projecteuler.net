namespace ProjectEulerDotNetProblems.Utilities
{
    using System;

    public static class MathematicsUtilities
    {
        public static bool IsPrime(ulong number)
        {
            bool result = true;
            double border = Math.Sqrt(number);
            for (ulong num = 2; num <= border; num++)
            {
                if (number % num == 0)
                {
                    return false;
                }
            }

            return result;
        }

        public static bool IsFactor(ulong number, ulong candidate)
        {
            if (number % candidate == 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsPalindrome(ulong number)
        {
            ulong numberToTest = number;
            ulong reversedNumber = 0;
            while (number > 0)
            {
                ulong digNumber = number % 10;
                reversedNumber = reversedNumber * 10 + digNumber;
                number = number / 10;
            }

            if (numberToTest == reversedNumber)
            {
                return true;
            }

            return false;
        }
    }
}
