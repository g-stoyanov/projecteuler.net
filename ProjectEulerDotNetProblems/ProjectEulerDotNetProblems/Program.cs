namespace ProjectEulerDotNetProblems
{
    using ProjectEulerDotNetProblems.From0To100;
    using System;

    class Program
    {
        static void Main()
        {
            // PrintProblemResult<ulong>(1, Problem001MultiplesOf3And5.SumAllMultiplesOf3Or5(1000));
            // PrintProblemResult<ulong>(2, Problem002EvenFibonacciNumbers.SumAllEvenFibonacciNumbers(4000000));
            // !!! PrintProblemResult<ulong>(3, Problem003LargestPrimeFactor.CalculateLargestPrimeFactorOfTheNumber(600851475143));
            // PrintProblemResult<double>(4, Problem004LargestPalindromeProduct.CalculateLargestPalindromeMadeFromProductOfTwoNumbers(3));
            PrintProblemResult<ulong>(5, Problem005SmallestMultiple.CalcSmallestPositiveNumEvenlyDivisibleByRangeOfNums(1, 20));
        }

        private static void PrintProblemResult<T>(int problemNum, T result)
        {
            Console.WriteLine(string.Format("Answer of problem {0:000} is {1}", problemNum, result));
        }
    }
}
