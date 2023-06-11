using playground.Strings;

namespace playground.UnitTest.Strings;

public class SmallestStringTest
{
    [Theory]
    [InlineData("cbabc", "baabc")]
    [InlineData("acbbc", "abaab")]
    [InlineData("aaaz", "aaay")]
    [InlineData("aaa", "aaz")]
    [InlineData("baa", "aaa")]
    [InlineData("leetcode", "kddsbncd")]
    public void SmallestString(string s, string expected)
    {
        var actual = SmallestStringClass.SmallestString(s);
        Assert.Equal(expected, actual);
    }
}
