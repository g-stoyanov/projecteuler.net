namespace ProjectEulerDotNetProblems.From0To100
{
    using ProjectEulerDotNetProblems.Utilities;
    using System;

    public static class Problem004LargestPalindromeProduct
    {
        /// <summary>
        /// Largest palindrome product
        /// ..........................
        /// Problem 4
        /// ---------
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        ///
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static double CalculateLargestPalindromeMadeFromProductOfTwoNumbers(byte numberOfDigitsInNumbers)
        {
            double startNumber = 0;
            double endNumber = 9;
            double result = 0;
            if (numberOfDigitsInNumbers > 1)
            {
                startNumber = Math.Pow(10, (double)numberOfDigitsInNumbers - 1);
                endNumber = Math.Pow(10, (double)numberOfDigitsInNumbers) - 1;
            }

            for (double firstNumber = endNumber; firstNumber >= startNumber ; firstNumber--)
            {
                for (double secondNumber = firstNumber; secondNumber >= startNumber; secondNumber--)
                {
                    ulong productOfNumbers = (ulong)(firstNumber*secondNumber);
                    if (MathematicsUtilities.IsPalindrome(productOfNumbers))
                    {
                        if (productOfNumbers > result)
                        {
                            result = productOfNumbers;
                        }
                    }                
                }
            }

            return result;
        }
    }
}
