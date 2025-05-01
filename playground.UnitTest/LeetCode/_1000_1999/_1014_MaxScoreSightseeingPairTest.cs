using playground.LeetCode._1000_1999;

namespace playground.UnitTest._1000_1099;

public class _1014_MaxScoreSightseeingPairTest
{
    [Theory]
    [InlineData(new int[] { 8, 1, 5, 2, 6 }, 11)]
    [InlineData(new int[] { 1, 2 }, 2)]
    public void MaxScoreSightseeingPair(int[] values, int expected)
    {
        var actual = _1014_MaxScoreSightseeingPair.MaxScoreSightseeingPair(values);
        Assert.Equal(expected, actual);
    }
}
