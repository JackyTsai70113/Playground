namespace playground.UnitTest;

public class CountPairsTest3265
{
    [Theory]
    [InlineData(new int[] { 3, 12, 30, 17, 21 }, 2)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 10)]
    [InlineData(new int[] { 123, 231 }, 0)]
    public void CountPairs(int[] nums, int expected)
    {
        var actual = CountPairs3265.CountPairs(nums);
        Assert.Equal(expected, actual);
    }
}
