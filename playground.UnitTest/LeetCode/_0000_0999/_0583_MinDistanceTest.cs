using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0583_MinDistanceTest
{
    [Theory]
    [InlineData("a", "b", 2)]
    [InlineData("sea", "eat", 2)]
    [InlineData("leetcode", "etco", 4)]
    [InlineData("etco", "leetcode", 4)]
    public void MinDistance(string word1, string word2, int expected)
    {
        var actual = _0583_MinDistance.MinDistance(word1, word2);
        Assert.Equal(expected, actual);
    }
}
