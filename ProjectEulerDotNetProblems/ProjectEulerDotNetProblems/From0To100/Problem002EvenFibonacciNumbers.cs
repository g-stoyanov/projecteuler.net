﻿namespace ProjectEulerDotNetProblems.From0To100
{
    using ProjectEulerDotNetProblems.Utilities;

    public static class Problem002EvenFibonacciNumbers
    {
        /// <summary>
        /// Even Fibonacci numbers
        /// ......................
        /// Problem 2
        /// ---------
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        ///
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        ///
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        public static ulong SumAllEvenFibonacciNumbers(ulong fibonacciNumberLimit)
        {
            FibonacciSequence sequence = new FibonacciSequence();
            ulong fibonacciNumber = 0;
            ulong sum = 0;

            while (fibonacciNumber < fibonacciNumberLimit)
            {
                fibonacciNumber = sequence.GetNext();
                if (fibonacciNumber % 2 == 0)
                {
                    sum += fibonacciNumber;
                }
            }

            return sum;
        }
    }
}