namespace playground.UnitTest;

public class CountCompleteDayPairsTest3185
{
    [Theory]
    [InlineData(new int[] { 12, 12, 30, 24, 24 }, 2)]
    [InlineData(new int[] { 72, 48, 24, 3 }, 3)]
    public void CountCompleteDayPairs(int[] hours, long expected)
    {
        var actual = CountCompleteDayPairs3185.CountCompleteDayPairs(hours);
        Assert.Equal(expected, actual);
    }
}
