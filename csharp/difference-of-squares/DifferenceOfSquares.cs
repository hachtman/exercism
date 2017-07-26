using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        int count = 0;
        for (int i = 0; i <= max; i++) {
            count += i;
        }
        return count * count;
    }

    public static int SumOfSquares(int max)
    {
        int count = 0;
        for (int i = 0; i <= max; i++) {
            count += i * i;
        }
        return count;
    }

    public static int DifferenceOfSquares(int max)
    {
        return (SquareOfSums(max) - SumOfSquares(max));
    }
}
