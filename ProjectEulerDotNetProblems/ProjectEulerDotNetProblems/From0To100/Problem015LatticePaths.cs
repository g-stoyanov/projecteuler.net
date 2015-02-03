namespace ProjectEulerDotNetProblems.From0To100
{
    using ProjectEulerDotNetProblems.Utilities;
    using System.Numerics;

    public static class Problem015LatticePaths
    {
        /// <summary>
        /// Lattice paths
        /// .............
        /// Problem 15
        /// ----------
        /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        /// 
        /// How many such routes are there through a 20×20 grid?
        /// </summary>
        public static BigInteger CalculateNumbersOfAllPathsInMatrix(int[,] matrix)
        {
            BigInteger result = MathematicsUtilities.GetAllPathsCount(matrix, 0, 0, new BigInteger(0));
            return result;
        }
    }
}
