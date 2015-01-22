namespace ProjectEulerDotNetProblems.From0To100
{
    using ProjectEulerDotNetProblems.Utilities;
    using System;

    public static class Problem004LargestPalindromeProduct
    {
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
