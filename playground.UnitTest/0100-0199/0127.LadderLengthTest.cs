namespace playground.UnitTest;

public class LadderLengthTest0127
{
    [Theory]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }, 5)]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }, 0)]
    [InlineData("hit", "aaa", new string[] { "hot", "dot", "dog", "lot", "log", "aaa" }, 0)]
    public void LadderLength(string beginWord, string endWord, IList<string> ws, int expected)
    {
        var actual = LadderLength0127.LadderLength(beginWord, endWord, ws);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }, 5)]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }, 0)]
    [InlineData("hit", "aaa", new string[] { "hot", "dot", "dog", "lot", "log", "aaa" }, 0)]
    public void LadderLength2(string beginWord, string endWord, IList<string> ws, int expected)
    {
        var actual = LadderLength0127.LadderLength2(beginWord, endWord, ws);
        Assert.Equal(expected, actual);
    }
}
