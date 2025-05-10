using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3303_MinStartingIndexTest
{
    [Theory]
    [InlineData("abcdefg", "bcdffg", 1)]
    [InlineData("ababbababa", "bacaba", 4)]
    [InlineData("abcd", "dba", -1)]
    [InlineData("dde", "d", 0)]
    [InlineData("kkkkkj", "kjj", 3)]
    public void MinStartingIndex(string s, string pattern, int expected)
    {
        var actual = _3303_MinStartingIndex.MinStartingIndex(s, pattern);
        Assert.Equal(expected, actual);
    }
}
