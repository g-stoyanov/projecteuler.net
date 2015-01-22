﻿namespace ProjectEulerDotNetProblems
{
    using ProjectEulerDotNetProblems.From0To100;
    using System;

    class Program
    {
        static void Main()
        {
            // PrintProblemResult<ulong>(1, Problem001MultiplesOf3And5.SumAllMultiplesOf3Or5(1000));
            // PrintProblemResult<ulong>(2, Problem002EvenFibonacciNumbers.SumAllEvenFibonacciNumbers(4000000));
            for (ulong i = 0; i < 100; i++)
            {
                Console.WriteLine(Problem003LargestPrimeFactor.CalculateLargestPrimeFactorOfTheNumber(i));
            }
        }

        private static void PrintProblemResult<T>(int problemNum, T result)
        {
            Console.WriteLine(string.Format("Answer of problem {0:000} is {1}", problemNum, result));
        }
    }
}
