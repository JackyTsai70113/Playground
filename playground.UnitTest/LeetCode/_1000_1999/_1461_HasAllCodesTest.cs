using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1461_HasAllCodesTest
{
    [Theory]
    [InlineData("00110110", 2, true)]
    [InlineData("0110", 1, true)]
    [InlineData("0110", 2, false)]
    public void HasAllCodes(string s, int k, bool expected)
    {
        var actual = _1641_HasAllCodes.HasAllCodes(s, k);
        Assert.Equal(expected, actual);
    }
}
