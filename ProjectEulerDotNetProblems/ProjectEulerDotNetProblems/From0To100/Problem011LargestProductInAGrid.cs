namespace ProjectEulerDotNetProblems.From0To100
{
    public static class Problem011LargestProductInAGrid
    {
        public static ulong CalculateGreatestProductOfAdjacentNumberAllDirectionsInGrid(int[,] grid, int numOfAdjDigits)
        {
            int rowBorder = grid.GetLength(1) - (numOfAdjDigits - 1);
            int colBorder = grid.GetLength(0) - (numOfAdjDigits - 1);
            ulong maxProduct = 0;
            for (int row = numOfAdjDigits - 1; row < rowBorder; row++)
			{
                for (int col = numOfAdjDigits - 1; col < colBorder; col++)
                {
                    ulong upProduct = 1;
                    ulong upRightProduct = 1;
                    ulong rightProduct = 1;
                    ulong downRightProduct = 1;
                    ulong downProduct = 1;
                    ulong downLeftProduct = 1;
                    ulong leftProduct = 1;
                    ulong upLeftProduct = 1;
                    for (int digitsPositionModificator = 0; digitsPositionModificator < numOfAdjDigits; digitsPositionModificator++)
                    {
                        upProduct *= (ulong)grid[row - digitsPositionModificator, col];
                        upRightProduct *= (ulong)grid[row - digitsPositionModificator, col + digitsPositionModificator];
                        rightProduct *= (ulong)grid[row, col + digitsPositionModificator];
                        downRightProduct *= (ulong)grid[row + digitsPositionModificator, col + digitsPositionModificator];
                        downProduct *= (ulong)grid[row + digitsPositionModificator, col];
                        downLeftProduct *= (ulong)grid[row + digitsPositionModificator, col - digitsPositionModificator];
                        leftProduct *= (ulong)grid[row, col - digitsPositionModificator];
                        upLeftProduct *= (ulong)grid[row - digitsPositionModificator, col - digitsPositionModificator];
                    }

                    if (maxProduct < upProduct)
                    {
                        maxProduct = upProduct;
                    }

                    if (maxProduct < upRightProduct)
                    {
                        maxProduct = upRightProduct;
                    }

                    if (maxProduct < rightProduct)
                    {
                        maxProduct = rightProduct;
                    }

                    if (maxProduct < downRightProduct)
                    {
                        maxProduct = downRightProduct;
                    }

                    if (maxProduct < downProduct)
                    {
                        maxProduct = downProduct;
                    }

                    if (maxProduct < downLeftProduct)
                    {
                        maxProduct = downLeftProduct;
                    }

                    if (maxProduct < leftProduct)
                    {
                        maxProduct = leftProduct;
                    }

                    if (maxProduct < upLeftProduct)
                    {
                        maxProduct = upLeftProduct;
                    }
                }
			}

            return maxProduct;
        }
    }
}
