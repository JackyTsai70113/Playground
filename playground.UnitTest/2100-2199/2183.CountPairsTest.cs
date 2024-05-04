namespace playground.UnitTest;

public class CountPairsTest2183
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 7)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 5, 0)]
    public void CountPairs(int[] nums, int k, int expected)
    {
        var actual = CountPairs2183.CountPairs(nums, k);
        Assert.Equal(expected, actual);
    }
}
