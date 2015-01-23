namespace ProjectEulerDotNetProblems.From0To100
{
    using System;
    using System.Numerics;

    public static class Problem016PowerDigitSum
    {
        /// <summary>
        /// Power digit sum
        /// ...............
        /// Problem 16
        /// ----------
        /// 215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
        /// 
        /// What is the sum of the digits of the number 21000?
        /// </summary>
        public static ulong CalculateDigitsSumOfPoweredNum(int number, int power)
        {
            BigInteger poweredNumber = 1;
            for (int powerCount = 0; powerCount < power; powerCount++)
            {
                poweredNumber *= number;
            }

            string poweredNumberDigits = poweredNumber.ToString();

            ulong sum = 0;
            foreach (var digit in poweredNumberDigits)
            {
                sum += (ulong)Char.GetNumericValue(digit);
            }

            return sum;
        }
    }
}
