namespace playground.UnitTest.LeetCode._1000_1999;

public class _1475_FinalPricesTest
{
    [Theory]
    [InlineData(new int[] { 8, 4, 6, 2, 3 }, new int[] { 4, 2, 4, 2, 3 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 10, 1, 1, 6 }, new int[] { 9, 0, 1, 6 })]
    public void FinalPrices(int[] A, int[] expected)
    {
        var actual = _1475_FinalPrices.FinalPrices(A);
        Assert.Equal(expected, actual);
    }
}
