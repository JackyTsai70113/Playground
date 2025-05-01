using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0127_LadderLengthTest
{
    [Theory]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }, 5)]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }, 0)]
    [InlineData("hit", "aaa", new string[] { "hot", "dot", "dog", "lot", "log", "aaa" }, 0)]
    public void LadderLength(string beginWord, string endWord, IList<string> ws, int expected)
    {
        var actual = _0127_LadderLength.LadderLength(beginWord, endWord, ws);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }, 5)]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }, 0)]
    [InlineData("hit", "aaa", new string[] { "hot", "dot", "dog", "lot", "log", "aaa" }, 0)]
    public void LadderLength2(string beginWord, string endWord, IList<string> ws, int expected)
    {
        var actual = _0127_LadderLength.LadderLength2(beginWord, endWord, ws);
        Assert.Equal(expected, actual);
    }
}
