using playground.DirectedGraph;

namespace playground.UnitTest.UndirectGraph;

public class LadderLengthTest
{
    [Theory]
    [InlineData("hbo", "qbx", new string[] { "abo", "hco", "hbw", "ado", "abq", "hcd", "hcj", "hww", "qbq", "qby", "qbz", "qbx", "qbw" }, 4)]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }, 0)]
    [InlineData("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }, 5)]
    [InlineData("hot", "dog", new string[] { "hot", "dog" }, 0)]
    public void LadderLength(string beginWord, string endWord, string[] ws, int expected)
    {
        var actual = LadderLengthClass.LadderLength(beginWord, endWord, ws);
        Assert.Equal(expected, actual);
    }
}
