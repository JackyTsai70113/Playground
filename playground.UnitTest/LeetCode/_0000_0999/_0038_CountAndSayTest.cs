using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0038_CountAndSayTest
{
    [Theory]
    [InlineData(4, "1211")]
    [InlineData(1, "1")]
    public void CountAndSay(int n, string expected)
    {
        var actual = _0038_CountAndSay.CountAndSay(n);
        Assert.Equal(expected, actual);
    }
}
