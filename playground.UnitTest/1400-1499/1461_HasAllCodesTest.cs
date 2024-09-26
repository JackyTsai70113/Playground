using playground._1400_1499;

namespace playground.UnitTest._1400_1499;

public class _1461_HasAllCodesTest
{
    [Theory]
    [InlineData("cbaebabacd", "abc", true)]
    [InlineData("abab", "ab", true)]
    public void HasAllCodes(string s, int k, bool expected)
    {
        var actual = _1641_HasAllCodes.HasAllCodes(s, k);
        Assert.Equal(expected, actual);
    }
}
