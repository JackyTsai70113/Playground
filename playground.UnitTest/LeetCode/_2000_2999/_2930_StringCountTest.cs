using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2930_StringCountTest
{
    [Theory]
    [InlineData(4, 12)]
    [InlineData(5, 1460)]
    [InlineData(10, 83943898)]
    public void StringCount(int n, int expected)
    {
        var actual = _2930_StringCount.StringCount(n);
        Assert.Equal(expected, actual);
    }
}
