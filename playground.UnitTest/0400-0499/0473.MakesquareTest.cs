namespace playground.UnitTest;

public class MakesquareTest0473
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 2, 2 }, true)]
    [InlineData(new int[] { 3, 3, 3, 3, 3 }, false)]
    [InlineData(new int[] { 3, 3, 3, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 102 }, false)]
    [InlineData(new int[] { 10, 6, 5, 5, 5, 3, 3, 3, 2, 2, 2, 2 }, true)]
    [InlineData(new int[] { 5969561, 8742425, 2513572, 3352059, 9084275, 2194427, 1017540, 2324577, 6810719, 8936380, 7868365, 2755770, 9954463, 9912280, 4713511 }, false)]
    public void MaximumPrimeDifference(int[] A, bool expected)
    {
        var actual = Makesquare0473.Makesquare(A);
        Assert.Equal(expected, actual);
    }
}
