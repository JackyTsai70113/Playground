using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0636_ExclusiveTimeTest
{
    [Theory]
    [InlineData(2, new string[] { "0:start:0", "1:start:2", "1:end:5", "0:end:6" }, new int[] { 3, 4 })]
    [InlineData(1, new string[] { "0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7" }, new int[] { 8 })]
    [InlineData(2, new string[] { "0:start:0", "0:start:2", "0:end:5", "1:start:6", "1:end:6", "0:end:7" }, new int[] { 7, 1 })]
    [InlineData(1, new string[] { "0:start:0", "0:start:1", "0:start:2", "0:end:3", "0:end:4", "0:end:5" }, new int[] { 6 })]
    public void ExclusiveTime(int n, string[] logs, int[] expected)
    {
        var actual = _0636_ExclusiveTime.ExclusiveTime(n, logs);
        Assert.Equal(expected, actual);
    }
}
