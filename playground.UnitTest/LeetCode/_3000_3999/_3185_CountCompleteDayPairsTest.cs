namespace playground.UnitTest.LeetCode._3000_3999;

public class _3185_CountCompleteDayPairsTest
{
    [Theory]
    [InlineData(new int[] { 12, 12, 30, 24, 24 }, 2)]
    [InlineData(new int[] { 72, 48, 24, 3 }, 3)]
    public void CountCompleteDayPairs(int[] hours, long expected)
    {
        var actual = _3185_CountCompleteDayPairs.CountCompleteDayPairs(hours);
        Assert.Equal(expected, actual);
    }
}
