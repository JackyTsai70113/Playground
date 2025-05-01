using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
