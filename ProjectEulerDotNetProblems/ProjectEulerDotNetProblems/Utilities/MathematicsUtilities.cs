namespace ProjectEulerDotNetProblems.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

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

        public static ulong GetNthPrime(int index)
        {
            if (index == 1)
            {
                return 2;
            }

            index--;

            for (ulong candidate = 3; candidate <= ulong.MaxValue; candidate += 2)
            {
                if (IsPrime(candidate))
                {
                    index--;
                    if (index == 0)
                    {
                        return candidate;
                    }
                }
            }

            return 0;
        }

        public static bool IsFactor(ulong number, ulong candidate)
        {
            if (number % candidate == 0)
            {
                return true;
            }

            return false;
        }

        public static List<ulong> GetNumberFactors(ulong number)
        {
            ulong limit = number;
            List<ulong> factors = new List<ulong>();

            for (ulong i = 1; i < limit; ++i)
            {
                if (number % i == 0)
                {
                    limit = number / i;
                    if (limit != i)
                    {
                        factors.Add(i);
                    }

                    factors.Add(limit);
                }
            }

            return factors;
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

        public static BigInteger GetAllPathsCount(int[,] matrix, int row, int col, BigInteger pathsCount)
        {
            if ((col + 1) < matrix.GetLength(1))
            {
                pathsCount = GetAllPathsCount(matrix, row, col + 1, pathsCount);
            }

            if ((row + 1) < matrix.GetLength(0))
            {
                pathsCount = GetAllPathsCount(matrix, row + 1, col, pathsCount);
            }

            if ((col + 1) == matrix.GetLength(1) && (row + 1) == matrix.GetLength(0))
            {
                pathsCount++;
            }

            return pathsCount;
        }
    }
}
