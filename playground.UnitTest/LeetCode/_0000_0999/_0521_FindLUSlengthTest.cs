using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0521_FindLUSlengthTest
{
    [Theory]
    [InlineData("aba", "cdc", 3)]
    [InlineData("aaa", "bbb", 3)]
    [InlineData("aaa", "aaa", -1)]
    [InlineData("aefawfawfawfaw", "aefawfeawfwafwaef", 17)]
    [InlineData("aefawfeawfwafwaef", "aefawfawfawfaw", 17)]
    public void FindLUSlength(string a, string b, int expected)
    {
        var actual = _0521_FindLUSlength.FindLUSlength(a, b);
        Assert.Equal(expected, actual);
    }
}
