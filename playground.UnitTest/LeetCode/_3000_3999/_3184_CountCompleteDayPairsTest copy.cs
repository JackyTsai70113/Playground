namespace playground.UnitTest;

public class _3184_CountCompleteDayPairsTest
{
    [Theory]
    [InlineData(new int[] { 12, 12, 30, 24, 24 }, 2)]
    [InlineData(new int[] { 72, 48, 24, 3 }, 3)]
    public void CountCompleteDayPairs(int[] hours, long expected)
    {
        var actual = _3184_CountCompleteDayPairs.CountCompleteDayPairs(hours);
        Assert.Equal(expected, actual);
    }
}
