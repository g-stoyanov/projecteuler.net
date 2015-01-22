namespace ProjectEulerDotNetProblems.From0To100
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Problem006SumSquareDifference
    {
        /// <summary>
        /// Sum square difference
        /// .....................
        /// Problem 6
        /// ---------
        /// The sum of the squares of the first ten natural numbers is,
        /// 
        /// 12 + 22 + ... + 102 = 385
        /// The square of the sum of the first ten natural numbers is,
        /// 
        /// (1 + 2 + ... + 10)2 = 552 = 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// 
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        public static ulong CalculateSumSquareDiffRangeOfNaturalNumbers(ulong startNumber, ulong endNumber)
        {
            ulong sumOfSquares = 0;
            ulong sum = 0;
            for (ulong number = startNumber; number <= endNumber; number++)
            {
                sumOfSquares += (number * number);
                sum += number;
            }

            ulong squareOfTheSum = (sum * sum);

            ulong result = squareOfTheSum - sumOfSquares;

            return result;
        }
    }
}
