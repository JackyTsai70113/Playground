namespace playground.UnitTest;

public class FindKthSmallestTest3116
{
    [Theory]
    [InlineData(new int[] { 3, 6, 9 }, 3, 9)]
    [InlineData(new int[] { 5, 2 }, 7, 12)]
    [InlineData(new int[] { 5, 4, 2 }, 7, 12)]
    [InlineData(new int[] { 4, 6, 9, 10 }, 10, 24)]
    public void FindKthSmallest(int[] coins, int k, int expected)
    {
        var actual = FindKthSmallest3116.FindKthSmallest(coins, k);
        Assert.Equal(expected, actual);
    }
}
