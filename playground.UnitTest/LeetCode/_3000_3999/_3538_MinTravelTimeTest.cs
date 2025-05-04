using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3538_MinTravelTimeTest
{
    [Theory]
    [InlineData(10, 4, 0, new int[] { 0, 3, 8, 10 }, new int[] { 5, 8, 3, 6 }, 61)]
    [InlineData(10, 4, 1, new int[] { 0, 3, 8, 10 }, new int[] { 5, 8, 3, 6 }, 62)]
    [InlineData(5, 5, 1, new int[] { 0, 1, 2, 3, 5 }, new int[] { 8, 3, 9, 3, 3 }, 34)]
    [InlineData(5, 5, 3, new int[] { 0, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1, 1 }, 5)]
    [InlineData(6, 6, 1, new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1, 1, 1 }, 5)]
    public void Test(int l, int n, int k, int[] ps, int[] ts, int expectedStr)
    {
        var actual = _3538_MinTravelTime.MinTravelTime(l, n, k, ps, ts);
        Assert.Equal(expectedStr, actual);
    }

    [Theory]
    [InlineData(10, 4, 0, new int[] { 0, 3, 8, 10 }, new int[] { 5, 8, 3, 6 }, 61)]
    [InlineData(10, 4, 1, new int[] { 0, 3, 8, 10 }, new int[] { 5, 8, 3, 6 }, 62)]
    [InlineData(5, 5, 1, new int[] { 0, 1, 2, 3, 5 }, new int[] { 8, 3, 9, 3, 3 }, 34)]
    [InlineData(5, 5, 3, new int[] { 0, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1, 1 }, 5)]
    [InlineData(6, 6, 1, new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1, 1, 1 }, 5)]
    public void Test2(int l, int n, int k, int[] ps, int[] ts, int expectedStr)
    {
        var actual = _3538_MinTravelTime.MinTravelTime2(l, n, k, ps, ts);
        Assert.Equal(expectedStr, actual);
    }
}
