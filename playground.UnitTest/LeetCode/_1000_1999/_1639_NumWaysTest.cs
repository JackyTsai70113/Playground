using playground._1600_1699;

namespace playground.UnitTest._1600_1699;

public class _1639_NumWaysTest
{
    [Theory]
    [InlineData(new string[] { "acca", "bbbb", "caca" }, "aba", 6)]
    [InlineData(new string[] { "abba", "baab" }, "bab", 4)]
    public void NumWays(string[] words, string target, int expected)
    {
        var actual = _1639_NumWays_cs.NumWays(words, target);
        Assert.Equal(expected, actual);
    }
}
